using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace WidgetUI.Examples
{
	public class TextWidget 
		: UIBehaviour
		, IWidget<String>
	{
		Text m_textComponent;

		protected override void Awake()
		{
			base.Awake();
			m_textComponent = this.GetComponentInChildren<Text>();
		}

		public void Enable(string p_dataObject)
		{
			m_textComponent.text = p_dataObject;
		}

		public void Disable()
		{
		}
	}
}
