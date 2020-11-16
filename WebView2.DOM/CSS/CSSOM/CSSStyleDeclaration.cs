﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace WebView2.DOM
{
	// https://github.com/chromium/chromium/blob/master/third_party/blink/renderer/core/css/css_style_declaration.idl

	[DebuggerTypeProxy(typeof(JsCollectionProxy))]
	public class CSSStyleDeclaration : JsObject, ICollection<KeyValuePair<string, string>>, IReadOnlyCollection<KeyValuePair<string, string>>
	{
		public string cssText { get => Get<string>(); set => Set(value); }
		public string this[uint index] =>
			IndexerGet<string?>(index) ?? throw new ArgumentOutOfRangeException(nameof(index));
		public uint length => Get<uint>();
		public string getPropertyValue(string property) => Method<string>().Invoke(property);
		public string getPropertyPriority(string property) => Method<string>().Invoke(property);
		public void setProperty(string property, string value, string priority = "") =>
			Method().Invoke(property, value, priority);
		public string removeProperty(string property) => Method<string>().Invoke(property);
		public CSSRule? parentRule => Get<CSSRule?>();

		public string this[string property]
		{
			get => IndexerGet<string>(property);
			set => IndexerSet(property, value);
		}
		public void Remove(string property) => IndexerDelete(property);

		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			var enumerator = SymbolMethod<ArrayIterator<string>>("iterator").Invoke();
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				yield return KeyValuePair.Create(current, this[current]);
			}
		}

		#region ICollection
		int IReadOnlyCollection<KeyValuePair<string, string>>.Count => (int)length;
		int ICollection<KeyValuePair<string, string>>.Count => (int)length;
		bool ICollection<KeyValuePair<string, string>>.IsReadOnly => true;
		void ICollection<KeyValuePair<string, string>>.Add(KeyValuePair<string, string> item) => throw new NotSupportedException();
		void ICollection<KeyValuePair<string, string>>.Clear() => throw new NotSupportedException();
		bool ICollection<KeyValuePair<string, string>>.Contains(KeyValuePair<string, string> item) => this.Any(x => x.Equals(item));
		void ICollection<KeyValuePair<string, string>>.CopyTo(KeyValuePair<string, string>[] array, int arrayIndex) => this.ToArray().CopyTo(array, arrayIndex);
		bool ICollection<KeyValuePair<string, string>>.Remove(KeyValuePair<string, string> item) => throw new NotSupportedException();
		IEnumerator<KeyValuePair<string, string>> IEnumerable<KeyValuePair<string, string>>.GetEnumerator() => GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
		#endregion

		public string alignContent { get => Get<string>(); set => Set(value); }
		public string alignItems { get => Get<string>(); set => Set(value); }
		public string alignSelf { get => Get<string>(); set => Set(value); }
		public string alignmentBaseline { get => Get<string>(); set => Set(value); }
		public string all { get => Get<string>(); set => Set(value); }
		public string animation { get => Get<string>(); set => Set(value); }
		public string animationDelay { get => Get<string>(); set => Set(value); }
		public string animationDirection { get => Get<string>(); set => Set(value); }
		public string animationDuration { get => Get<string>(); set => Set(value); }
		public string animationFillMode { get => Get<string>(); set => Set(value); }
		public string animationIterationCount { get => Get<string>(); set => Set(value); }
		public string animationName { get => Get<string>(); set => Set(value); }
		public string animationPlayState { get => Get<string>(); set => Set(value); }
		public string animationTimingFunction { get => Get<string>(); set => Set(value); }
		public string appearance { get => Get<string>(); set => Set(value); }
		public string backdropFilter { get => Get<string>(); set => Set(value); }
		public string backfaceVisibility { get => Get<string>(); set => Set(value); }
		public string background { get => Get<string>(); set => Set(value); }
		public string backgroundAttachment { get => Get<string>(); set => Set(value); }
		public string backgroundBlendMode { get => Get<string>(); set => Set(value); }
		public string backgroundClip { get => Get<string>(); set => Set(value); }
		public string backgroundColor { get => Get<string>(); set => Set(value); }
		public string backgroundImage { get => Get<string>(); set => Set(value); }
		public string backgroundOrigin { get => Get<string>(); set => Set(value); }
		public string backgroundPosition { get => Get<string>(); set => Set(value); }
		public string backgroundPositionX { get => Get<string>(); set => Set(value); }
		public string backgroundPositionY { get => Get<string>(); set => Set(value); }
		public string backgroundRepeat { get => Get<string>(); set => Set(value); }
		public string backgroundRepeatX { get => Get<string>(); set => Set(value); }
		public string backgroundRepeatY { get => Get<string>(); set => Set(value); }
		public string backgroundSize { get => Get<string>(); set => Set(value); }
		public string baselineShift { get => Get<string>(); set => Set(value); }
		public string blockSize { get => Get<string>(); set => Set(value); }
		public string border { get => Get<string>(); set => Set(value); }
		public string borderBlockEnd { get => Get<string>(); set => Set(value); }
		public string borderBlockEndColor { get => Get<string>(); set => Set(value); }
		public string borderBlockEndStyle { get => Get<string>(); set => Set(value); }
		public string borderBlockEndWidth { get => Get<string>(); set => Set(value); }
		public string borderBlockStart { get => Get<string>(); set => Set(value); }
		public string borderBlockStartColor { get => Get<string>(); set => Set(value); }
		public string borderBlockStartStyle { get => Get<string>(); set => Set(value); }
		public string borderBlockStartWidth { get => Get<string>(); set => Set(value); }
		public string borderBottom { get => Get<string>(); set => Set(value); }
		public string borderBottomColor { get => Get<string>(); set => Set(value); }
		public string borderBottomLeftRadius { get => Get<string>(); set => Set(value); }
		public string borderBottomRightRadius { get => Get<string>(); set => Set(value); }
		public string borderBottomStyle { get => Get<string>(); set => Set(value); }
		public string borderBottomWidth { get => Get<string>(); set => Set(value); }
		public string borderCollapse { get => Get<string>(); set => Set(value); }
		public string borderColor { get => Get<string>(); set => Set(value); }
		public string borderImage { get => Get<string>(); set => Set(value); }
		public string borderImageOutset { get => Get<string>(); set => Set(value); }
		public string borderImageRepeat { get => Get<string>(); set => Set(value); }
		public string borderImageSlice { get => Get<string>(); set => Set(value); }
		public string borderImageSource { get => Get<string>(); set => Set(value); }
		public string borderImageWidth { get => Get<string>(); set => Set(value); }
		public string borderInlineEnd { get => Get<string>(); set => Set(value); }
		public string borderInlineEndColor { get => Get<string>(); set => Set(value); }
		public string borderInlineEndStyle { get => Get<string>(); set => Set(value); }
		public string borderInlineEndWidth { get => Get<string>(); set => Set(value); }
		public string borderInlineStart { get => Get<string>(); set => Set(value); }
		public string borderInlineStartColor { get => Get<string>(); set => Set(value); }
		public string borderInlineStartStyle { get => Get<string>(); set => Set(value); }
		public string borderInlineStartWidth { get => Get<string>(); set => Set(value); }
		public string borderLeft { get => Get<string>(); set => Set(value); }
		public string borderLeftColor { get => Get<string>(); set => Set(value); }
		public string borderLeftStyle { get => Get<string>(); set => Set(value); }
		public string borderLeftWidth { get => Get<string>(); set => Set(value); }
		public string borderRadius { get => Get<string>(); set => Set(value); }
		public string borderRight { get => Get<string>(); set => Set(value); }
		public string borderRightColor { get => Get<string>(); set => Set(value); }
		public string borderRightStyle { get => Get<string>(); set => Set(value); }
		public string borderRightWidth { get => Get<string>(); set => Set(value); }
		public string borderSpacing { get => Get<string>(); set => Set(value); }
		public string borderStyle { get => Get<string>(); set => Set(value); }
		public string borderTop { get => Get<string>(); set => Set(value); }
		public string borderTopColor { get => Get<string>(); set => Set(value); }
		public string borderTopLeftRadius { get => Get<string>(); set => Set(value); }
		public string borderTopRightRadius { get => Get<string>(); set => Set(value); }
		public string borderTopStyle { get => Get<string>(); set => Set(value); }
		public string borderTopWidth { get => Get<string>(); set => Set(value); }
		public string borderWidth { get => Get<string>(); set => Set(value); }
		public string bottom { get => Get<string>(); set => Set(value); }
		public string boxShadow { get => Get<string>(); set => Set(value); }
		public string boxSizing { get => Get<string>(); set => Set(value); }
		public string breakAfter { get => Get<string>(); set => Set(value); }
		public string breakBefore { get => Get<string>(); set => Set(value); }
		public string breakInside { get => Get<string>(); set => Set(value); }
		public string bufferedRendering { get => Get<string>(); set => Set(value); }
		public string captionSide { get => Get<string>(); set => Set(value); }
		public string caretColor { get => Get<string>(); set => Set(value); }
		public string clear { get => Get<string>(); set => Set(value); }
		public string clip { get => Get<string>(); set => Set(value); }
		public string clipPath { get => Get<string>(); set => Set(value); }
		public string clipRule { get => Get<string>(); set => Set(value); }
		public string color { get => Get<string>(); set => Set(value); }
		public string colorInterpolation { get => Get<string>(); set => Set(value); }
		public string colorInterpolationFilters { get => Get<string>(); set => Set(value); }
		public string colorRendering { get => Get<string>(); set => Set(value); }
		public string colorScheme { get => Get<string>(); set => Set(value); }
		public string columnCount { get => Get<string>(); set => Set(value); }
		public string columnFill { get => Get<string>(); set => Set(value); }
		public string columnGap { get => Get<string>(); set => Set(value); }
		public string columnRule { get => Get<string>(); set => Set(value); }
		public string columnRuleColor { get => Get<string>(); set => Set(value); }
		public string columnRuleStyle { get => Get<string>(); set => Set(value); }
		public string columnRuleWidth { get => Get<string>(); set => Set(value); }
		public string columnSpan { get => Get<string>(); set => Set(value); }
		public string columnWidth { get => Get<string>(); set => Set(value); }
		public string columns { get => Get<string>(); set => Set(value); }
		public string contain { get => Get<string>(); set => Set(value); }
		public string containIntrinsicSize { get => Get<string>(); set => Set(value); }
		public string content { get => Get<string>(); set => Set(value); }
		public string contentVisibility { get => Get<string>(); set => Set(value); }
		public string counterIncrement { get => Get<string>(); set => Set(value); }
		public string counterReset { get => Get<string>(); set => Set(value); }
		public string counterSet { get => Get<string>(); set => Set(value); }
		public string cursor { get => Get<string>(); set => Set(value); }
		public string cx { get => Get<string>(); set => Set(value); }
		public string cy { get => Get<string>(); set => Set(value); }
		public string d { get => Get<string>(); set => Set(value); }
		public string direction { get => Get<string>(); set => Set(value); }
		public string display { get => Get<string>(); set => Set(value); }
		public string dominantBaseline { get => Get<string>(); set => Set(value); }
		public string emptyCells { get => Get<string>(); set => Set(value); }
		public string fill { get => Get<string>(); set => Set(value); }
		public string fillOpacity { get => Get<string>(); set => Set(value); }
		public string fillRule { get => Get<string>(); set => Set(value); }
		public string filter { get => Get<string>(); set => Set(value); }
		public string flex { get => Get<string>(); set => Set(value); }
		public string flexBasis { get => Get<string>(); set => Set(value); }
		public string flexDirection { get => Get<string>(); set => Set(value); }
		public string flexFlow { get => Get<string>(); set => Set(value); }
		public string flexGrow { get => Get<string>(); set => Set(value); }
		public string flexShrink { get => Get<string>(); set => Set(value); }
		public string flexWrap { get => Get<string>(); set => Set(value); }
		public string @float { get => Get<string>(); set => Set(value); }
		public string floodColor { get => Get<string>(); set => Set(value); }
		public string floodOpacity { get => Get<string>(); set => Set(value); }
		public string font { get => Get<string>(); set => Set(value); }
		public string fontDisplay { get => Get<string>(); set => Set(value); }
		public string fontFamily { get => Get<string>(); set => Set(value); }
		public string fontFeatureSettings { get => Get<string>(); set => Set(value); }
		public string fontKerning { get => Get<string>(); set => Set(value); }
		public string fontOpticalSizing { get => Get<string>(); set => Set(value); }
		public string fontSize { get => Get<string>(); set => Set(value); }
		public string fontStretch { get => Get<string>(); set => Set(value); }
		public string fontStyle { get => Get<string>(); set => Set(value); }
		public string fontVariant { get => Get<string>(); set => Set(value); }
		public string fontVariantCaps { get => Get<string>(); set => Set(value); }
		public string fontVariantEastAsian { get => Get<string>(); set => Set(value); }
		public string fontVariantLigatures { get => Get<string>(); set => Set(value); }
		public string fontVariantNumeric { get => Get<string>(); set => Set(value); }
		public string fontVariationSettings { get => Get<string>(); set => Set(value); }
		public string fontWeight { get => Get<string>(); set => Set(value); }
		public string forcedColorAdjust { get => Get<string>(); set => Set(value); }
		public string gap { get => Get<string>(); set => Set(value); }
		public string grid { get => Get<string>(); set => Set(value); }
		public string gridArea { get => Get<string>(); set => Set(value); }
		public string gridAutoColumns { get => Get<string>(); set => Set(value); }
		public string gridAutoFlow { get => Get<string>(); set => Set(value); }
		public string gridAutoRows { get => Get<string>(); set => Set(value); }
		public string gridColumn { get => Get<string>(); set => Set(value); }
		public string gridColumnEnd { get => Get<string>(); set => Set(value); }
		public string gridColumnGap { get => Get<string>(); set => Set(value); }
		public string gridColumnStart { get => Get<string>(); set => Set(value); }
		public string gridGap { get => Get<string>(); set => Set(value); }
		public string gridRow { get => Get<string>(); set => Set(value); }
		public string gridRowEnd { get => Get<string>(); set => Set(value); }
		public string gridRowGap { get => Get<string>(); set => Set(value); }
		public string gridRowStart { get => Get<string>(); set => Set(value); }
		public string gridTemplate { get => Get<string>(); set => Set(value); }
		public string gridTemplateAreas { get => Get<string>(); set => Set(value); }
		public string gridTemplateColumns { get => Get<string>(); set => Set(value); }
		public string gridTemplateRows { get => Get<string>(); set => Set(value); }
		public string height { get => Get<string>(); set => Set(value); }
		public string hyphens { get => Get<string>(); set => Set(value); }
		public string imageOrientation { get => Get<string>(); set => Set(value); }
		public string imageRendering { get => Get<string>(); set => Set(value); }
		public string inherits { get => Get<string>(); set => Set(value); }
		public string initialValue { get => Get<string>(); set => Set(value); }
		public string inlineSize { get => Get<string>(); set => Set(value); }
		public string isolation { get => Get<string>(); set => Set(value); }
		public string justifyContent { get => Get<string>(); set => Set(value); }
		public string justifyItems { get => Get<string>(); set => Set(value); }
		public string justifySelf { get => Get<string>(); set => Set(value); }
		public string left { get => Get<string>(); set => Set(value); }
		public string letterSpacing { get => Get<string>(); set => Set(value); }
		public string lightingColor { get => Get<string>(); set => Set(value); }
		public string lineBreak { get => Get<string>(); set => Set(value); }
		public string lineHeight { get => Get<string>(); set => Set(value); }
		public string listStyle { get => Get<string>(); set => Set(value); }
		public string listStyleImage { get => Get<string>(); set => Set(value); }
		public string listStylePosition { get => Get<string>(); set => Set(value); }
		public string listStyleType { get => Get<string>(); set => Set(value); }
		public string margin { get => Get<string>(); set => Set(value); }
		public string marginBlockEnd { get => Get<string>(); set => Set(value); }
		public string marginBlockStart { get => Get<string>(); set => Set(value); }
		public string marginBottom { get => Get<string>(); set => Set(value); }
		public string marginInlineEnd { get => Get<string>(); set => Set(value); }
		public string marginInlineStart { get => Get<string>(); set => Set(value); }
		public string marginLeft { get => Get<string>(); set => Set(value); }
		public string marginRight { get => Get<string>(); set => Set(value); }
		public string marginTop { get => Get<string>(); set => Set(value); }
		public string marker { get => Get<string>(); set => Set(value); }
		public string markerEnd { get => Get<string>(); set => Set(value); }
		public string markerMid { get => Get<string>(); set => Set(value); }
		public string markerStart { get => Get<string>(); set => Set(value); }
		public string mask { get => Get<string>(); set => Set(value); }
		public string maskType { get => Get<string>(); set => Set(value); }
		public string maxBlockSize { get => Get<string>(); set => Set(value); }
		public string maxHeight { get => Get<string>(); set => Set(value); }
		public string maxInlineSize { get => Get<string>(); set => Set(value); }
		public string maxWidth { get => Get<string>(); set => Set(value); }
		public string maxZoom { get => Get<string>(); set => Set(value); }
		public string minBlockSize { get => Get<string>(); set => Set(value); }
		public string minHeight { get => Get<string>(); set => Set(value); }
		public string minInlineSize { get => Get<string>(); set => Set(value); }
		public string minWidth { get => Get<string>(); set => Set(value); }
		public string minZoom { get => Get<string>(); set => Set(value); }
		public string mixBlendMode { get => Get<string>(); set => Set(value); }
		public string objectFit { get => Get<string>(); set => Set(value); }
		public string objectPosition { get => Get<string>(); set => Set(value); }
		public string offset { get => Get<string>(); set => Set(value); }
		public string offsetDistance { get => Get<string>(); set => Set(value); }
		public string offsetPath { get => Get<string>(); set => Set(value); }
		public string offsetRotate { get => Get<string>(); set => Set(value); }
		public string opacity { get => Get<string>(); set => Set(value); }
		public string order { get => Get<string>(); set => Set(value); }
		public string orientation { get => Get<string>(); set => Set(value); }
		public string orphans { get => Get<string>(); set => Set(value); }
		public string outline { get => Get<string>(); set => Set(value); }
		public string outlineColor { get => Get<string>(); set => Set(value); }
		public string outlineOffset { get => Get<string>(); set => Set(value); }
		public string outlineStyle { get => Get<string>(); set => Set(value); }
		public string outlineWidth { get => Get<string>(); set => Set(value); }
		public string overflow { get => Get<string>(); set => Set(value); }
		public string overflowAnchor { get => Get<string>(); set => Set(value); }
		public string overflowWrap { get => Get<string>(); set => Set(value); }
		public string overflowX { get => Get<string>(); set => Set(value); }
		public string overflowY { get => Get<string>(); set => Set(value); }
		public string overscrollBehavior { get => Get<string>(); set => Set(value); }
		public string overscrollBehaviorBlock { get => Get<string>(); set => Set(value); }
		public string overscrollBehaviorInline { get => Get<string>(); set => Set(value); }
		public string overscrollBehaviorX { get => Get<string>(); set => Set(value); }
		public string overscrollBehaviorY { get => Get<string>(); set => Set(value); }
		public string padding { get => Get<string>(); set => Set(value); }
		public string paddingBlockEnd { get => Get<string>(); set => Set(value); }
		public string paddingBlockStart { get => Get<string>(); set => Set(value); }
		public string paddingBottom { get => Get<string>(); set => Set(value); }
		public string paddingInlineEnd { get => Get<string>(); set => Set(value); }
		public string paddingInlineStart { get => Get<string>(); set => Set(value); }
		public string paddingLeft { get => Get<string>(); set => Set(value); }
		public string paddingRight { get => Get<string>(); set => Set(value); }
		public string paddingTop { get => Get<string>(); set => Set(value); }
		public string page { get => Get<string>(); set => Set(value); }
		public string pageBreakAfter { get => Get<string>(); set => Set(value); }
		public string pageBreakBefore { get => Get<string>(); set => Set(value); }
		public string pageBreakInside { get => Get<string>(); set => Set(value); }
		public string pageOrientation { get => Get<string>(); set => Set(value); }
		public string paintOrder { get => Get<string>(); set => Set(value); }
		public string perspective { get => Get<string>(); set => Set(value); }
		public string perspectiveOrigin { get => Get<string>(); set => Set(value); }
		public string placeContent { get => Get<string>(); set => Set(value); }
		public string placeItems { get => Get<string>(); set => Set(value); }
		public string placeSelf { get => Get<string>(); set => Set(value); }
		public string pointerEvents { get => Get<string>(); set => Set(value); }
		public string position { get => Get<string>(); set => Set(value); }
		public string quotes { get => Get<string>(); set => Set(value); }
		public string r { get => Get<string>(); set => Set(value); }
		public string resize { get => Get<string>(); set => Set(value); }
		public string right { get => Get<string>(); set => Set(value); }
		public string rowGap { get => Get<string>(); set => Set(value); }
		public string rubyPosition { get => Get<string>(); set => Set(value); }
		public string rx { get => Get<string>(); set => Set(value); }
		public string ry { get => Get<string>(); set => Set(value); }
		public string scrollBehavior { get => Get<string>(); set => Set(value); }
		public string scrollMargin { get => Get<string>(); set => Set(value); }
		public string scrollMarginBlock { get => Get<string>(); set => Set(value); }
		public string scrollMarginBlockEnd { get => Get<string>(); set => Set(value); }
		public string scrollMarginBlockStart { get => Get<string>(); set => Set(value); }
		public string scrollMarginBottom { get => Get<string>(); set => Set(value); }
		public string scrollMarginInline { get => Get<string>(); set => Set(value); }
		public string scrollMarginInlineEnd { get => Get<string>(); set => Set(value); }
		public string scrollMarginInlineStart { get => Get<string>(); set => Set(value); }
		public string scrollMarginLeft { get => Get<string>(); set => Set(value); }
		public string scrollMarginRight { get => Get<string>(); set => Set(value); }
		public string scrollMarginTop { get => Get<string>(); set => Set(value); }
		public string scrollPadding { get => Get<string>(); set => Set(value); }
		public string scrollPaddingBlock { get => Get<string>(); set => Set(value); }
		public string scrollPaddingBlockEnd { get => Get<string>(); set => Set(value); }
		public string scrollPaddingBlockStart { get => Get<string>(); set => Set(value); }
		public string scrollPaddingBottom { get => Get<string>(); set => Set(value); }
		public string scrollPaddingInline { get => Get<string>(); set => Set(value); }
		public string scrollPaddingInlineEnd { get => Get<string>(); set => Set(value); }
		public string scrollPaddingInlineStart { get => Get<string>(); set => Set(value); }
		public string scrollPaddingLeft { get => Get<string>(); set => Set(value); }
		public string scrollPaddingRight { get => Get<string>(); set => Set(value); }
		public string scrollPaddingTop { get => Get<string>(); set => Set(value); }
		public string scrollSnapAlign { get => Get<string>(); set => Set(value); }
		public string scrollSnapStop { get => Get<string>(); set => Set(value); }
		public string scrollSnapType { get => Get<string>(); set => Set(value); }
		public string shapeImageThreshold { get => Get<string>(); set => Set(value); }
		public string shapeMargin { get => Get<string>(); set => Set(value); }
		public string shapeOutside { get => Get<string>(); set => Set(value); }
		public string shapeRendering { get => Get<string>(); set => Set(value); }
		public string size { get => Get<string>(); set => Set(value); }
		public string speak { get => Get<string>(); set => Set(value); }
		public string src { get => Get<string>(); set => Set(value); }
		public string stopColor { get => Get<string>(); set => Set(value); }
		public string stopOpacity { get => Get<string>(); set => Set(value); }
		public string stroke { get => Get<string>(); set => Set(value); }
		public string strokeDasharray { get => Get<string>(); set => Set(value); }
		public string strokeDashoffset { get => Get<string>(); set => Set(value); }
		public string strokeLinecap { get => Get<string>(); set => Set(value); }
		public string strokeLinejoin { get => Get<string>(); set => Set(value); }
		public string strokeMiterlimit { get => Get<string>(); set => Set(value); }
		public string strokeOpacity { get => Get<string>(); set => Set(value); }
		public string strokeWidth { get => Get<string>(); set => Set(value); }
		public string syntax { get => Get<string>(); set => Set(value); }
		public string tabSize { get => Get<string>(); set => Set(value); }
		public string tableLayout { get => Get<string>(); set => Set(value); }
		public string textAlign { get => Get<string>(); set => Set(value); }
		public string textAlignLast { get => Get<string>(); set => Set(value); }
		public string textAnchor { get => Get<string>(); set => Set(value); }
		public string textCombineUpright { get => Get<string>(); set => Set(value); }
		public string textDecoration { get => Get<string>(); set => Set(value); }
		public string textDecorationColor { get => Get<string>(); set => Set(value); }
		public string textDecorationLine { get => Get<string>(); set => Set(value); }
		public string textDecorationSkipInk { get => Get<string>(); set => Set(value); }
		public string textDecorationStyle { get => Get<string>(); set => Set(value); }
		public string textIndent { get => Get<string>(); set => Set(value); }
		public string textOrientation { get => Get<string>(); set => Set(value); }
		public string textOverflow { get => Get<string>(); set => Set(value); }
		public string textRendering { get => Get<string>(); set => Set(value); }
		public string textShadow { get => Get<string>(); set => Set(value); }
		public string textSizeAdjust { get => Get<string>(); set => Set(value); }
		public string textTransform { get => Get<string>(); set => Set(value); }
		public string textUnderlinePosition { get => Get<string>(); set => Set(value); }
		public string top { get => Get<string>(); set => Set(value); }
		public string touchAction { get => Get<string>(); set => Set(value); }
		public string transform { get => Get<string>(); set => Set(value); }
		public string transformBox { get => Get<string>(); set => Set(value); }
		public string transformOrigin { get => Get<string>(); set => Set(value); }
		public string transformStyle { get => Get<string>(); set => Set(value); }
		public string transition { get => Get<string>(); set => Set(value); }
		public string transitionDelay { get => Get<string>(); set => Set(value); }
		public string transitionDuration { get => Get<string>(); set => Set(value); }
		public string transitionProperty { get => Get<string>(); set => Set(value); }
		public string transitionTimingFunction { get => Get<string>(); set => Set(value); }
		public string unicodeBidi { get => Get<string>(); set => Set(value); }
		public string unicodeRange { get => Get<string>(); set => Set(value); }
		public string userSelect { get => Get<string>(); set => Set(value); }
		public string userZoom { get => Get<string>(); set => Set(value); }
		public string vectorEffect { get => Get<string>(); set => Set(value); }
		public string verticalAlign { get => Get<string>(); set => Set(value); }
		public string visibility { get => Get<string>(); set => Set(value); }
		//public string webkitAlignContent { get => Get<string>(); set => Set(value); }
		//public string webkitAlignItems { get => Get<string>(); set => Set(value); }
		//public string webkitAlignSelf { get => Get<string>(); set => Set(value); }
		//public string webkitAnimation { get => Get<string>(); set => Set(value); }
		//public string webkitAnimationDelay { get => Get<string>(); set => Set(value); }
		//public string webkitAnimationDirection { get => Get<string>(); set => Set(value); }
		//public string webkitAnimationDuration { get => Get<string>(); set => Set(value); }
		//public string webkitAnimationFillMode { get => Get<string>(); set => Set(value); }
		//public string webkitAnimationIterationCount { get => Get<string>(); set => Set(value); }
		//public string webkitAnimationName { get => Get<string>(); set => Set(value); }
		//public string webkitAnimationPlayState { get => Get<string>(); set => Set(value); }
		//public string webkitAnimationTimingFunction { get => Get<string>(); set => Set(value); }
		//public string webkitAppRegion { get => Get<string>(); set => Set(value); }
		//public string webkitAppearance { get => Get<string>(); set => Set(value); }
		//public string webkitBackfaceVisibility { get => Get<string>(); set => Set(value); }
		//public string webkitBackgroundClip { get => Get<string>(); set => Set(value); }
		//public string webkitBackgroundOrigin { get => Get<string>(); set => Set(value); }
		//public string webkitBackgroundSize { get => Get<string>(); set => Set(value); }
		//public string webkitBorderAfter { get => Get<string>(); set => Set(value); }
		//public string webkitBorderAfterColor { get => Get<string>(); set => Set(value); }
		//public string webkitBorderAfterStyle { get => Get<string>(); set => Set(value); }
		//public string webkitBorderAfterWidth { get => Get<string>(); set => Set(value); }
		//public string webkitBorderBefore { get => Get<string>(); set => Set(value); }
		//public string webkitBorderBeforeColor { get => Get<string>(); set => Set(value); }
		//public string webkitBorderBeforeStyle { get => Get<string>(); set => Set(value); }
		//public string webkitBorderBeforeWidth { get => Get<string>(); set => Set(value); }
		//public string webkitBorderBottomLeftRadius { get => Get<string>(); set => Set(value); }
		//public string webkitBorderBottomRightRadius { get => Get<string>(); set => Set(value); }
		//public string webkitBorderEnd { get => Get<string>(); set => Set(value); }
		//public string webkitBorderEndColor { get => Get<string>(); set => Set(value); }
		//public string webkitBorderEndStyle { get => Get<string>(); set => Set(value); }
		//public string webkitBorderEndWidth { get => Get<string>(); set => Set(value); }
		//public string webkitBorderHorizontalSpacing { get => Get<string>(); set => Set(value); }
		//public string webkitBorderImage { get => Get<string>(); set => Set(value); }
		//public string webkitBorderRadius { get => Get<string>(); set => Set(value); }
		//public string webkitBorderStart { get => Get<string>(); set => Set(value); }
		//public string webkitBorderStartColor { get => Get<string>(); set => Set(value); }
		//public string webkitBorderStartStyle { get => Get<string>(); set => Set(value); }
		//public string webkitBorderStartWidth { get => Get<string>(); set => Set(value); }
		//public string webkitBorderTopLeftRadius { get => Get<string>(); set => Set(value); }
		//public string webkitBorderTopRightRadius { get => Get<string>(); set => Set(value); }
		//public string webkitBorderVerticalSpacing { get => Get<string>(); set => Set(value); }
		//public string webkitBoxAlign { get => Get<string>(); set => Set(value); }
		//public string webkitBoxDecorationBreak { get => Get<string>(); set => Set(value); }
		//public string webkitBoxDirection { get => Get<string>(); set => Set(value); }
		//public string webkitBoxFlex { get => Get<string>(); set => Set(value); }
		//public string webkitBoxOrdinalGroup { get => Get<string>(); set => Set(value); }
		//public string webkitBoxOrient { get => Get<string>(); set => Set(value); }
		//public string webkitBoxPack { get => Get<string>(); set => Set(value); }
		//public string webkitBoxReflect { get => Get<string>(); set => Set(value); }
		//public string webkitBoxShadow { get => Get<string>(); set => Set(value); }
		//public string webkitBoxSizing { get => Get<string>(); set => Set(value); }
		//public string webkitClipPath { get => Get<string>(); set => Set(value); }
		//public string webkitColumnBreakAfter { get => Get<string>(); set => Set(value); }
		//public string webkitColumnBreakBefore { get => Get<string>(); set => Set(value); }
		//public string webkitColumnBreakInside { get => Get<string>(); set => Set(value); }
		//public string webkitColumnCount { get => Get<string>(); set => Set(value); }
		//public string webkitColumnGap { get => Get<string>(); set => Set(value); }
		//public string webkitColumnRule { get => Get<string>(); set => Set(value); }
		//public string webkitColumnRuleColor { get => Get<string>(); set => Set(value); }
		//public string webkitColumnRuleStyle { get => Get<string>(); set => Set(value); }
		//public string webkitColumnRuleWidth { get => Get<string>(); set => Set(value); }
		//public string webkitColumnSpan { get => Get<string>(); set => Set(value); }
		//public string webkitColumnWidth { get => Get<string>(); set => Set(value); }
		//public string webkitColumns { get => Get<string>(); set => Set(value); }
		//public string webkitFilter { get => Get<string>(); set => Set(value); }
		//public string webkitFlex { get => Get<string>(); set => Set(value); }
		//public string webkitFlexBasis { get => Get<string>(); set => Set(value); }
		//public string webkitFlexDirection { get => Get<string>(); set => Set(value); }
		//public string webkitFlexFlow { get => Get<string>(); set => Set(value); }
		//public string webkitFlexGrow { get => Get<string>(); set => Set(value); }
		//public string webkitFlexShrink { get => Get<string>(); set => Set(value); }
		//public string webkitFlexWrap { get => Get<string>(); set => Set(value); }
		//public string webkitFontFeatureSettings { get => Get<string>(); set => Set(value); }
		//public string webkitFontSizeDelta { get => Get<string>(); set => Set(value); }
		//public string webkitFontSmoothing { get => Get<string>(); set => Set(value); }
		//public string webkitHighlight { get => Get<string>(); set => Set(value); }
		//public string webkitHyphenateCharacter { get => Get<string>(); set => Set(value); }
		//public string webkitJustifyContent { get => Get<string>(); set => Set(value); }
		//public string webkitLineBreak { get => Get<string>(); set => Set(value); }
		//public string webkitLineClamp { get => Get<string>(); set => Set(value); }
		//public string webkitLocale { get => Get<string>(); set => Set(value); }
		//public string webkitLogicalHeight { get => Get<string>(); set => Set(value); }
		//public string webkitLogicalWidth { get => Get<string>(); set => Set(value); }
		//public string webkitMarginAfter { get => Get<string>(); set => Set(value); }
		//public string webkitMarginBefore { get => Get<string>(); set => Set(value); }
		//public string webkitMarginEnd { get => Get<string>(); set => Set(value); }
		//public string webkitMarginStart { get => Get<string>(); set => Set(value); }
		//public string webkitMask { get => Get<string>(); set => Set(value); }
		//public string webkitMaskBoxImage { get => Get<string>(); set => Set(value); }
		//public string webkitMaskBoxImageOutset { get => Get<string>(); set => Set(value); }
		//public string webkitMaskBoxImageRepeat { get => Get<string>(); set => Set(value); }
		//public string webkitMaskBoxImageSlice { get => Get<string>(); set => Set(value); }
		//public string webkitMaskBoxImageSource { get => Get<string>(); set => Set(value); }
		//public string webkitMaskBoxImageWidth { get => Get<string>(); set => Set(value); }
		//public string webkitMaskClip { get => Get<string>(); set => Set(value); }
		//public string webkitMaskComposite { get => Get<string>(); set => Set(value); }
		//public string webkitMaskImage { get => Get<string>(); set => Set(value); }
		//public string webkitMaskOrigin { get => Get<string>(); set => Set(value); }
		//public string webkitMaskPosition { get => Get<string>(); set => Set(value); }
		//public string webkitMaskPositionX { get => Get<string>(); set => Set(value); }
		//public string webkitMaskPositionY { get => Get<string>(); set => Set(value); }
		//public string webkitMaskRepeat { get => Get<string>(); set => Set(value); }
		//public string webkitMaskRepeatX { get => Get<string>(); set => Set(value); }
		//public string webkitMaskRepeatY { get => Get<string>(); set => Set(value); }
		//public string webkitMaskSize { get => Get<string>(); set => Set(value); }
		//public string webkitMaxLogicalHeight { get => Get<string>(); set => Set(value); }
		//public string webkitMaxLogicalWidth { get => Get<string>(); set => Set(value); }
		//public string webkitMinLogicalHeight { get => Get<string>(); set => Set(value); }
		//public string webkitMinLogicalWidth { get => Get<string>(); set => Set(value); }
		//public string webkitOpacity { get => Get<string>(); set => Set(value); }
		//public string webkitOrder { get => Get<string>(); set => Set(value); }
		//public string webkitPaddingAfter { get => Get<string>(); set => Set(value); }
		//public string webkitPaddingBefore { get => Get<string>(); set => Set(value); }
		//public string webkitPaddingEnd { get => Get<string>(); set => Set(value); }
		//public string webkitPaddingStart { get => Get<string>(); set => Set(value); }
		//public string webkitPerspective { get => Get<string>(); set => Set(value); }
		//public string webkitPerspectiveOrigin { get => Get<string>(); set => Set(value); }
		//public string webkitPerspectiveOriginX { get => Get<string>(); set => Set(value); }
		//public string webkitPerspectiveOriginY { get => Get<string>(); set => Set(value); }
		//public string webkitPrintColorAdjust { get => Get<string>(); set => Set(value); }
		//public string webkitRtlOrdering { get => Get<string>(); set => Set(value); }
		//public string webkitRubyPosition { get => Get<string>(); set => Set(value); }
		//public string webkitShapeImageThreshold { get => Get<string>(); set => Set(value); }
		//public string webkitShapeMargin { get => Get<string>(); set => Set(value); }
		//public string webkitShapeOutside { get => Get<string>(); set => Set(value); }
		//public string webkitTapHighlightColor { get => Get<string>(); set => Set(value); }
		//public string webkitTextCombine { get => Get<string>(); set => Set(value); }
		//public string webkitTextDecorationsInEffect { get => Get<string>(); set => Set(value); }
		//public string webkitTextEmphasis { get => Get<string>(); set => Set(value); }
		//public string webkitTextEmphasisColor { get => Get<string>(); set => Set(value); }
		//public string webkitTextEmphasisPosition { get => Get<string>(); set => Set(value); }
		//public string webkitTextEmphasisStyle { get => Get<string>(); set => Set(value); }
		//public string webkitTextFillColor { get => Get<string>(); set => Set(value); }
		//public string webkitTextOrientation { get => Get<string>(); set => Set(value); }
		//public string webkitTextSecurity { get => Get<string>(); set => Set(value); }
		//public string webkitTextSizeAdjust { get => Get<string>(); set => Set(value); }
		//public string webkitTextStroke { get => Get<string>(); set => Set(value); }
		//public string webkitTextStrokeColor { get => Get<string>(); set => Set(value); }
		//public string webkitTextStrokeWidth { get => Get<string>(); set => Set(value); }
		//public string webkitTransform { get => Get<string>(); set => Set(value); }
		//public string webkitTransformOrigin { get => Get<string>(); set => Set(value); }
		//public string webkitTransformOriginX { get => Get<string>(); set => Set(value); }
		//public string webkitTransformOriginY { get => Get<string>(); set => Set(value); }
		//public string webkitTransformOriginZ { get => Get<string>(); set => Set(value); }
		//public string webkitTransformStyle { get => Get<string>(); set => Set(value); }
		//public string webkitTransition { get => Get<string>(); set => Set(value); }
		//public string webkitTransitionDelay { get => Get<string>(); set => Set(value); }
		//public string webkitTransitionDuration { get => Get<string>(); set => Set(value); }
		//public string webkitTransitionProperty { get => Get<string>(); set => Set(value); }
		//public string webkitTransitionTimingFunction { get => Get<string>(); set => Set(value); }
		//public string webkitUserDrag { get => Get<string>(); set => Set(value); }
		//public string webkitUserModify { get => Get<string>(); set => Set(value); }
		//public string webkitUserSelect { get => Get<string>(); set => Set(value); }
		//public string webkitWritingMode { get => Get<string>(); set => Set(value); }
		public string whiteSpace { get => Get<string>(); set => Set(value); }
		public string widows { get => Get<string>(); set => Set(value); }
		public string width { get => Get<string>(); set => Set(value); }
		public string willChange { get => Get<string>(); set => Set(value); }
		public string wordBreak { get => Get<string>(); set => Set(value); }
		public string wordSpacing { get => Get<string>(); set => Set(value); }
		public string wordWrap { get => Get<string>(); set => Set(value); }
		public string writingMode { get => Get<string>(); set => Set(value); }
		public string x { get => Get<string>(); set => Set(value); }
		public string y { get => Get<string>(); set => Set(value); }
		public string zIndex { get => Get<string>(); set => Set(value); }
		public string zoom { get => Get<string>(); set => Set(value); }
	}
}







