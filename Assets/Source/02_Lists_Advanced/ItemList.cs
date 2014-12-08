using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WidgetUI.Examples
{
	public class ItemList : InspectableFixedListWidget<Item, ItemListElement>
	{
		protected override IWidgetAllocator<ItemListElement> GetWidgetAllocator()
		{
			return new PooledAllocator<ItemListElement>(base.m_widgetPrefab.gameObject);
		}
	}
}
