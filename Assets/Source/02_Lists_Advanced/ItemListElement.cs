using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace WidgetUI.Examples
{
	public class ItemListElement 
		: UIBehaviour
		, IWidget<Item>
	{
		[SerializeField]
		private Text m_nameField;

		[SerializeField]
		private Text m_priceField;

		[SerializeField]
		private Text m_rarityField;

		[SerializeField]
		private Image m_iconField;

		public void Enable(Item p_item)
		{
			m_nameField.text = p_item.name;
			m_priceField.text = String.Format("{0} Gold", Mathf.CeilToInt(p_item.price));
			m_rarityField.text = p_item.rarity.ToString();
			m_iconField.sprite = p_item.icon;
		}

		public void Disable()
		{
			m_iconField.sprite = null;
		}
	}
}
