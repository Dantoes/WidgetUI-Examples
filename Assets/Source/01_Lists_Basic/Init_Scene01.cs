using UnityEngine;
using System.Collections;
using System;

namespace WidgetUI.Examples
{
	public class Init_Scene01 : MonoBehaviour
	{
		public StringList m_listWidget;
		public StringList_UnityLayout m_unityListWidget;

		void Start()
		{
			for(int i=0; i<100; ++i)
			{
				string text = String.Format("{0} {1}", RandomWords.PickOne(), RandomWords.PickOne());
				
				m_listWidget.Add(text);
				m_unityListWidget.Add(text);
			}

			m_listWidget.ScrollTo(0);

			m_listWidget.OnSelectItem.AddListener(this.OnListItemSelected);
			m_unityListWidget.OnSelectItem.AddListener(this.OnListItemSelected);
		}

		void OnListItemSelected(string p_item)
		{
			Debug.Log("Selected item: " + p_item);
		}
	}
}