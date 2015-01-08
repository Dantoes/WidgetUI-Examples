using UnityEngine;
using UnityEngine.EventSystems;

namespace WidgetUI.Examples
{
	public class FadeIn
		: UIBehaviour
	{
		private CanvasGroup m_canvasGroup;
		private bool m_destroyCanvasGroup = false;

		protected override void Awake()
		{
			base.Awake();

			GameObject go = this.gameObject;
			m_canvasGroup = go.GetComponent<CanvasGroup>();

			if (m_canvasGroup == null)
			{
				m_canvasGroup = go.AddComponent<CanvasGroup>();
				m_destroyCanvasGroup = true;
			}

			m_canvasGroup.alpha = 0;
		}

		private void Update()
		{
			m_canvasGroup.alpha += 5.0F * Time.deltaTime;
			if (m_canvasGroup.alpha > 1.0F)
			{
				if(m_destroyCanvasGroup)
				{
					GameObject.Destroy(m_canvasGroup);
				}
				GameObject.Destroy(this);
			}
		}
	}
}
