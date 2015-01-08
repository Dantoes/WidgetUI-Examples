using System;
using UnityEngine;

namespace WidgetUI.Examples
{
	public class FadeEffectTooltip
		: TextTooltip
	{
		protected override IWidgetAllocator<TextTooltipWidget> GetWidgetAllocator()
		{
			return new FadeEffectAllocator<TextTooltipWidget>(m_widgetPrefab.gameObject);
		}
	}
}
