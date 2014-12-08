using UnityEngine;
using System.Collections.Generic;
using System;
using System.Linq;

namespace WidgetUI.Examples
{
	public class Init_Scene03 : MonoBehaviour
	{
		public ItemSelectbox m_selectbox1, m_selectbox2;
		public Sprite[] m_icons;

		void Start()
		{
			ItemFactory itemFactory = new ItemFactory(m_icons);

			for(int i=0; i<50; ++i)
			{
				Item item = itemFactory.CreateRandomItem();
				m_selectbox1.Add(item);
				m_selectbox2.Add(item);
			}

			m_selectbox1.OnSelectItem.AddListener(this.OnListItemSelected);
			m_selectbox2.OnSelectItem.AddListener(this.OnListItemSelected);
		}



		void OnListItemSelected(Item p_item)
		{
			Debug.Log("Selected item: " + p_item.name);
		}
	}
}