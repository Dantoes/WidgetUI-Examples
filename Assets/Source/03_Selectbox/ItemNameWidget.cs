using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace WidgetUI.Examples
{
	public class ItemNameWidget 
		: UIBehaviour
		, IWidget<Item>
	{
		Text m_textComponent;

		protected override void Awake()
		{
			base.Awake();
			m_textComponent = this.GetComponentInChildren<Text>();
		}

		public void Enable(Item p_item)
		{
			m_textComponent.text = p_item.name;
		}

		public void Disable()
		{
		}
	}
}
