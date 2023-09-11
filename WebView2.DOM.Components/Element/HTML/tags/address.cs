﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace WebView2.DOM.Components;

public sealed class @address : HTMLElementBuilder, IEnumerable
{
	protected override HTMLElement CreateElement() =>
		document.createHTMLElement(HTMLElementTag.address);

	internal override bool CanAddChild(Node child)
	{
		var extraChild = NodeExtraInfo.For(child);

		return extraChild.IsFlowContent
			&& (extraChild.ContainsAddress == false)
			&& (extraChild.ContainsHeadingContent == false)
			&& (extraChild.ContainsSectioningContent == false)
			&& (extraChild.ContainsHeader == false)
			&& (extraChild.ContainsFooter == false)
			;
	}

	public void Add(string text) => ChildNodesHelper.Add(this, text);
	public void Add(Func<string> text) => ChildNodesHelper.Add(this, text);
	public void Add(Node child) => ChildNodesHelper.Add(this, child);
	public void Add(IReadOnlyList<NodeBuilder> list) => ChildNodesHelper.Add(this, list);

	public @address this[ChildNodes childNodes]
	{
		get
		{
			foreach (var action in childNodes.actions)
			{
				action(this);
			}
			return this;
		}
	}

	public class ChildNodes : IEnumerable
	{
		internal readonly List<Action<@address>> actions = new();

		public void Add(string text) => actions.Add(@this => ChildNodesHelper.Add(@this, text));
		public void Add(Func<string> text) => actions.Add(@this => ChildNodesHelper.Add(@this, text));
		public void Add(Node child) => actions.Add(@this => ChildNodesHelper.Add(@this, child));
		public void Add(IReadOnlyList<NodeBuilder> list) => actions.Add(@this => ChildNodesHelper.Add(@this, list));

		IEnumerator IEnumerable.GetEnumerator() => throw new NotSupportedException();
	}

	IEnumerator IEnumerable.GetEnumerator() => throw new NotSupportedException();
}


