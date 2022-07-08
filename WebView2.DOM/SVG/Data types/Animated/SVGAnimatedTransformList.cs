﻿namespace WebView2.DOM
{
	// https://github.com/chromium/chromium/blob/master/third_party/blink/renderer/core/svg/svg_animated_transform_list.idl

	public sealed class SVGAnimatedTransformList : JsObject
	{
		private SVGAnimatedTransformList() { }

		public SVGTransformList baseVal => Get<SVGTransformList>();
		public SVGTransformList animVal => Get<SVGTransformList>();
	}
}