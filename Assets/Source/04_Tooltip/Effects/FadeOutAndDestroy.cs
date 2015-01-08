using UnityEngine;
using UnityEngine.EventSystems;

namespace WidgetUI.Examples
{
	public class FadeOutAndDestroy
		: UIBehaviour
	{
		private CanvasGroup m_canvasGroup;

		protected override void Awake()
		{
			base.Awake();

			GameObject go = this.gameObject;
			m_canvasGroup = go.GetComponent<CanvasGroup>();
			if (m_canvasGroup == null)
			{
				m_canvasGroup = go.AddComponent<CanvasGroup>();
			}

			m_canvasGroup.alpha = 1;
		}

		private void Update()
		{
			m_canvasGroup.alpha -= 5.0F * Time.deltaTime;
			if (m_canvasGroup.alpha < 0.0F)
			{
				GameObject.Destroy(this.gameObject);
			}
		}
	}
}
