using UnityEngine;
using UnityEngine.EventSystems;

namespace WidgetUI.Examples
{
	public class FadeEffectAllocator<WidgetType> 
		: DefaultWidgetAllocator<WidgetType>
		where WidgetType : UIBehaviour, IWidget
	{
		public FadeEffectAllocator(GameObject p_widgetPrefab)
			: base(p_widgetPrefab)
		{
		}

		public override WidgetType Construct()
		{
			WidgetType widget = base.Construct();
			widget.gameObject.AddComponent<FadeIn>();
			return widget;
		}

		public override void Destroy(WidgetType p_widget)
		{
			p_widget.gameObject.AddComponent<FadeOutAndDestroy>();
		}
	}
}
