﻿using Microsoft.Web.WebView2.Core;

namespace WebView2.DOM
{
	// https://github.com/chromium/chromium/blob/master/third_party/blink/renderer/core/html/forms/validity_state.idl

	public class ValidityState : JsObject
	{
		protected internal ValidityState(CoreWebView2 coreWebView, string referenceId) : base(coreWebView, referenceId)
		{
		}

		public bool valueMissing	=> Get<bool>();
		public bool typeMismatch	=> Get<bool>();
		public bool patternMismatch	=> Get<bool>();
		public bool tooLong	=> Get<bool>();
		public bool tooShort	=> Get<bool>();
		public bool rangeUnderflow	=> Get<bool>();
		public bool rangeOverflow	=> Get<bool>();
		public bool stepMismatch	=> Get<bool>();
		public bool badInput	=> Get<bool>();
		public bool customError	=> Get<bool>();
		public bool valid	=> Get<bool>();
	}
}
