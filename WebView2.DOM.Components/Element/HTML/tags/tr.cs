﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace WebView2.DOM.Components;

public sealed class @tr : HTMLTableRowElementBuilder, IEnumerable
{
	protected override HTMLTableRowElement CreateElement() =>
		document.createHTMLElement(HTMLElementTag.tr);

	internal override bool CanAddChild(Node child)
	{
		return child is HTMLTableCellElement;
	}

	public void Add(Node child) => ChildNodesHelper.Add(this, child);
	public void Add(IReadOnlyList<NodeBuilder> list) => ChildNodesHelper.Add(this, list);

	public @tr this[ChildNodes childNodes]
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
		internal readonly List<Action<@tr>> actions = new();

		public void Add(Node child) => actions.Add(@this => ChildNodesHelper.Add(@this, child));
		public void Add(IReadOnlyList<NodeBuilder> list) => actions.Add(@this => ChildNodesHelper.Add(@this, list));

		IEnumerator IEnumerable.GetEnumerator() => throw new NotSupportedException();
	}

	IEnumerator IEnumerable.GetEnumerator() => throw new NotSupportedException();
}


