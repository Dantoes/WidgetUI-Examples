using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.EventSystems;

namespace WidgetUI.Examples
{
	public class PooledAllocator<WidgetType> 
		: DefaultWidgetAllocator<WidgetType>
		where WidgetType : UIBehaviour, IWidget
	{
		public PooledAllocator(GameObject p_widgetPrefab)
			: base(p_widgetPrefab)
		{
		}

		public override WidgetType Construct()
		{
			WidgetType widget = SimpleObjectPool.Instance.Pop<WidgetType>();
			if (widget == null)
			{
				widget = base.Construct();
			}

			return widget;
		}

		public override void Destroy(WidgetType p_widget)
		{
			if(!SimpleObjectPool.Instance.Push(p_widget))
			{
				base.Destroy(p_widget);
			}
		}
	}
}
