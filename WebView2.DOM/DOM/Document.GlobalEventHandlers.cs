﻿using System;

namespace WebView2.DOM
{
	public partial class Document : GlobalEventHandlers
	{
		public event EventHandler<Event/*	*/>? onabort/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<AnimationEvent/*	*/>? onanimationend/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<AnimationEvent/*	*/>? onanimationiteration/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<AnimationEvent/*	*/>? onanimationstart/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<MouseEvent/*	*/>? onauxclick/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<FocusEvent/*	*/>? onblur/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? oncancel/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? oncanplay/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? oncanplaythrough/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onchange/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<MouseEvent/*	*/>? onclick/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onclose/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<MouseEvent/*	*/>? oncontextmenu/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? oncuechange/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<MouseEvent/*	*/>? ondblclick/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<DragEvent/*	*/>? ondrag/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<DragEvent/*	*/>? ondragend/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<DragEvent/*	*/>? ondragenter/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<DragEvent/*	*/>? ondragleave/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<DragEvent/*	*/>? ondragover/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<DragEvent/*	*/>? ondragstart/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<DragEvent/*	*/>? ondrop/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? ondurationchange/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onemptied/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onended/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<FocusEvent/*	*/>? onfocus/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<FormDataEvent/*	*/>? onformdata/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<PointerEvent/*	*/>? ongotpointercapture/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<InputEvent/*	*/>? oninput/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? oninvalid/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<KeyboardEvent/*	*/>? onkeydown/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<KeyboardEvent/*	*/>? onkeypress/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<KeyboardEvent/*	*/>? onkeyup/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onload/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onloadeddata/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onloadedmetadata/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<ProgressEvent/*	*/>? onloadstart/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<PointerEvent/*	*/>? onlostpointercapture/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<MouseEvent/*	*/>? onmousedown/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<MouseEvent/*	*/>? onmouseenter/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<MouseEvent/*	*/>? onmouseleave/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<MouseEvent/*	*/>? onmousemove/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<MouseEvent/*	*/>? onmouseout/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<MouseEvent/*	*/>? onmouseover/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<MouseEvent/*	*/>? onmouseup/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onpause/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onplay/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onplaying/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<PointerEvent/*	*/>? onpointercancel/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<PointerEvent/*	*/>? onpointerdown/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<PointerEvent/*	*/>? onpointerenter/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<PointerEvent/*	*/>? onpointerleave/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<PointerEvent/*	*/>? onpointermove/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<PointerEvent/*	*/>? onpointerout/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<PointerEvent/*	*/>? onpointerover/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<PointerEvent/*	*/>? onpointerrawupdate/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<PointerEvent/*	*/>? onpointerup/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<ProgressEvent/*	*/>? onprogress/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onratechange/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onreset/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<UIEvent/*	*/>? onresize/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onscroll/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onseeked/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onseeking/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onselect/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onselectionchange/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onselectstart/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onstalled/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<SubmitEvent/*	*/>? onsubmit/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onsuspend/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? ontimeupdate/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? ontoggle/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<TouchEvent/*	*/>? ontouchcancel/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<TouchEvent/*	*/>? ontouchend/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<TouchEvent/*	*/>? ontouchmove/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<TouchEvent/*	*/>? ontouchstart/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<TransitionEvent/*	*/>? ontransitioncancel/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<TransitionEvent/*	*/>? ontransitionend/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<TransitionEvent/*	*/>? ontransitionrun/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<TransitionEvent/*	*/>? ontransitionstart/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onvolumechange/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<Event/*	*/>? onwaiting/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
		public event EventHandler<WheelEvent/*	*/>? onwheel/*	*/{ add => AddEvent(value); remove => RemoveEvent(value); }
	}
}
