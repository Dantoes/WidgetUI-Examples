using UnityEngine;
using System.Collections.Generic;
using System;
using System.Linq;

namespace WidgetUI.Examples
{
	public class Init_Scene02 : MonoBehaviour
	{
		public ItemList m_listWidget;
		public Sprite[] m_icons;

		void Start()
		{
			ItemFactory itemFactory = new ItemFactory(m_icons);

			for(int i=0; i<5000; ++i)
			{
				m_listWidget.Add(itemFactory.CreateRandomItem());
			}

			m_listWidget.ScrollTo(0);

			m_listWidget.OnSelectItem.AddListener(this.OnListItemSelected);
		}

		public void SortByPrice()
		{
			// Need to make a copy of the result because IOrderedEnumerator references
			// the list. By clearing the original list the ordered result is lost.
			Item[] sortedList = m_listWidget.OrderBy(i => i.price).ToArray();

			m_listWidget.Clear();
			m_listWidget.AddRange(sortedList);
		}

		public void SortByName()
		{
			Item[] sortedList = m_listWidget.OrderBy(i => i.name).ToArray();

			m_listWidget.Clear();
			m_listWidget.AddRange(sortedList);
		}

		public void RemoveGarbage()
		{
			m_listWidget.Remove(i => i.rarity == Item.Rarity.Garbage);
		}


		void OnListItemSelected(Item p_item)
		{
			Debug.Log("Selected item: " + p_item.name);
		}
	}
}