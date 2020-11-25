﻿using Microsoft.Web.WebView2.Core;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace WebView2.DOM
{
	public class JsObject
	{
		internal readonly CoreWebView2 coreWebView;
		internal readonly string referenceId;

		protected internal JsObject(CoreWebView2 coreWebView, string referenceId)
		{
			this.coreWebView = coreWebView;
			this.referenceId = referenceId;
		}

		internal void Construct(params object?[] args)
		{
			coreWebView.References().Add(this);
			coreWebView.Coordinator().Construct(referenceId, GetType().Name, args);
		}

		internal T Get<T>([CallerMemberName] string property = "")
		{
			var json = coreWebView.Coordinator().Get(referenceId, property);
			return JsonSerializer.Deserialize<T>(json, coreWebView.Options())!;
		}

		internal void Set<T>(T value, [CallerMemberName] string property = "")
		{
			coreWebView.Coordinator().Set(referenceId, property, value);
		}

		internal T IndexerGet<T>(object? index)
		{
			var json = coreWebView.Coordinator().IndexerGet(referenceId, index);
			return JsonSerializer.Deserialize<T>(json, coreWebView.Options())!;
		}

		internal void IndexerSet<T>(object? index, T value)
		{
			coreWebView.Coordinator().IndexerSet(referenceId, index, value);
		}

		internal void IndexerDelete(object? index)
		{
			coreWebView.Coordinator().IndexerDelete(referenceId, index);
		}

		internal Invoker Method([CallerMemberName] string method = "")
			=> new Invoker(this, method);

		internal struct Invoker
		{
			public Invoker(JsObject @this, string method) => (this.@this, this.method) = (@this, method);
			private JsObject @this;
			private string method;

			public void Invoke(params object?[] args)
			{
				@this.coreWebView.Coordinator().Invoke(@this.referenceId, method, args);
			}
		}

		internal Invoker<T> Method<T>([CallerMemberName] string method = "")
			=> new Invoker<T>(this, method);

		internal struct Invoker<T>
		{
			public Invoker(JsObject @this, string method) => (this.@this, this.method) = (@this, method);
			private JsObject @this;
			private string method;

			public T Invoke(params object?[] args)
			{
				var json = @this.coreWebView.Coordinator().Invoke(@this.referenceId, method, args);
				return JsonSerializer.Deserialize<T>(json, @this.coreWebView.Options())!;
			}
		}

		internal SymbolInvoker<T> SymbolMethod<T>([CallerMemberName] string method = "")
			=> new SymbolInvoker<T>(this, method);

		internal struct SymbolInvoker<T>
		{
			public SymbolInvoker(JsObject @this, string method) => (this.@this, this.method) = (@this, method);
			private JsObject @this;
			private string method;

			public T Invoke(params object?[] args)
			{
				var json = @this.coreWebView.Coordinator().InvokeSymbol(@this.referenceId, method, args);
				return JsonSerializer.Deserialize<T>(json, @this.coreWebView.Options())!;
			}
		}
	}

	public class Function : JsObject
	{
		protected internal Function(CoreWebView2 coreWebView, string referenceId) : base(coreWebView, referenceId)
		{
		}
	}
}
