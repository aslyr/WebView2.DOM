﻿using Microsoft.Web.WebView2.Core;
using SmartAnalyzers.CSharpExtensions.Annotations;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;
using WebView2.DOM.Helpers;

namespace WebView2.DOM
{
	public static class WebView2Extensions
	{
		internal static readonly ConditionalWeakTable<Microsoft.Web.WebView2.WinForms.WebView2, CoreWebView2>
			winformsWebViews =
			new ConditionalWeakTable<Microsoft.Web.WebView2.WinForms.WebView2, CoreWebView2>();

		internal static readonly ConditionalWeakTable<Microsoft.Web.WebView2.Wpf.WebView2, CoreWebView2>
			wpfWebViews =
			new ConditionalWeakTable<Microsoft.Web.WebView2.Wpf.WebView2, CoreWebView2>();

		private static readonly ConditionalWeakTable<Microsoft.Web.WebView2.WinForms.WebView2, WinFormsEvents>
			winFormsEvents =
			new ConditionalWeakTable<Microsoft.Web.WebView2.WinForms.WebView2, WinFormsEvents>();

		private static readonly ConditionalWeakTable<Microsoft.Web.WebView2.Wpf.WebView2, WpfEvents>
			wpfEvents =
			new ConditionalWeakTable<Microsoft.Web.WebView2.Wpf.WebView2, WpfEvents>();

		private static readonly ConditionalWeakTable<CoreWebView2, References>
			references =
			new ConditionalWeakTable<CoreWebView2, References>();

		private static readonly ConditionalWeakTable<CoreWebView2, Coordinator>
			coordinators =
			new ConditionalWeakTable<CoreWebView2, Coordinator>();

		private static readonly ConditionalWeakTable<CoreWebView2, JsonSerializerOptions>
			options =
			new ConditionalWeakTable<CoreWebView2, JsonSerializerOptions>();

		private static readonly ConditionalWeakTable<JsonSerializerOptions, CoreWebView2>
			optionsToWebViews =
			new ConditionalWeakTable<JsonSerializerOptions, CoreWebView2>();

		public sealed class WinFormsEvents
		{
			private Microsoft.Web.WebView2.WinForms.WebView2 webView;
			private CoreWebView2 coreWebView;

			public WinFormsEvents(Microsoft.Web.WebView2.WinForms.WebView2 webView)
			{
				this.webView = webView;
				coreWebView = winformsWebViews.GetValue(webView, _webView => _webView.CoreWebView2);
			}

			private EventHandler<CoreWebView2DOMContentLoadedEventArgs>? _handler;

			public event EventHandler<CoreWebView2DOMContentLoadedEventArgs>? Handler
			{
				add
				{
					_handler += value;
					if (_handler != null) { coreWebView.DOMContentLoaded += CoreWebView_DOMContentLoaded; }
				}
				remove
				{
					_handler -= value;
					if (_handler == null) { coreWebView.DOMContentLoaded -= CoreWebView_DOMContentLoaded; }
				}
			}

			private void CoreWebView_DOMContentLoaded(object? sender, CoreWebView2DOMContentLoadedEventArgs e)
			{
				_handler?.Invoke(webView, e);
			}
		}

		public sealed class WpfEvents
		{
			private Microsoft.Web.WebView2.Wpf.WebView2 webView;
			private CoreWebView2 coreWebView;

			public WpfEvents(Microsoft.Web.WebView2.Wpf.WebView2 webView)
			{
				this.webView = webView;
				coreWebView = wpfWebViews.GetValue(webView, _webView => _webView.CoreWebView2);
			}

			private EventHandler<CoreWebView2DOMContentLoadedEventArgs>? _handler;

			public event EventHandler<CoreWebView2DOMContentLoadedEventArgs>? Handler
			{
				add
				{
					_handler += value;
					if (_handler != null) { coreWebView.DOMContentLoaded += CoreWebView_DOMContentLoaded; }
				}
				remove
				{
					_handler -= value;
					if (_handler == null) { coreWebView.DOMContentLoaded -= CoreWebView_DOMContentLoaded; }
				}
			}

			private void CoreWebView_DOMContentLoaded(object? sender, CoreWebView2DOMContentLoadedEventArgs e)
			{
				_handler?.Invoke(webView, e);
			}
		}

		public static References References(this CoreWebView2 coreWebView)
		{
			return references.GetValue(coreWebView, x => new References(x));
		}

		public static Coordinator Coordinator(this CoreWebView2 coreWebView, Action<Action>? dispatcher = null)
		{
			return coordinators.GetValue(coreWebView, x => new Coordinator(x, dispatcher));
		}

		public static JsonSerializerOptions Options(this CoreWebView2 coreWebView)
		{
			var result = options.GetValue(coreWebView, _ => new JsonSerializerOptions
			{
				Converters =
				{
					new EnumJsonConverter(),
					new JsObjectJsonConverter(),
					new TaskJsonConverter(),
					new ActionJsonConverter(),
					new anyJsonConverter(),
					//new LocalDateTimeJsonConverter(),
				},
			});

			optionsToWebViews.AddOrUpdate(result, coreWebView);

			return result;
		}

		public static CoreWebView2 CoreWebView(this JsonSerializerOptions options)
		{
			if (!optionsToWebViews.TryGetValue(options, out var result)) { throw new InvalidOperationException(); }
			return result;
		}

		public static WinFormsEvents DOMContentLoaded(this Microsoft.Web.WebView2.WinForms.WebView2 webView)
		{
			return winFormsEvents.GetValue(webView, _webView => new WinFormsEvents(_webView));
		}

		public static WpfEvents DOMContentLoaded(this Microsoft.Web.WebView2.Wpf.WebView2 webView)
		{
			return wpfEvents.GetValue(webView, _webView => new WpfEvents(_webView));
		}

		public static async Task Run(this Microsoft.Web.WebView2.WinForms.WebView2 webView, Action<Window> action)
		{
			await (Task)webView.Invoke((Func<Task>)(async () =>
			{
				var coreWebView = winformsWebViews.GetValue(webView, _webView => _webView.CoreWebView2);
				await coreWebView.Run(action);
			}));
		}

		public static async Task Run(this Microsoft.Web.WebView2.Wpf.WebView2 webView, Action<Window> action)
		{
			await webView.Dispatcher.Invoke(async () =>
			{
				var coreWebView = wpfWebViews.GetValue(webView, _webView => _webView.CoreWebView2);
				await coreWebView.Run(action);
			});
		}

		public static async Task Run(this CoreWebView2 coreWebView, Action<Window> action)
		{
			var runId = coreWebView.Coordinator().AddRunHandler(action);

			await coreWebView.ExecuteScriptAsync($@"
				(() => {{
					const Coordinator = () => window.chrome.webview.hostObjects.sync.Coordinator;
					Coordinator().{nameof(DOM.Coordinator.OnRun)}(WebView2DOM.GetId(window), '{runId}');
					WebView2DOM.EventLoop();
				}})()
			");
		}
	}

	public sealed class Guid
	{
		public string NewGuid() => System.Guid.NewGuid().ToString();
	}
}
