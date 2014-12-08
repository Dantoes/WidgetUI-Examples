using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace WidgetUI.Examples
{
	public class SimpleObjectPool : MonoBehaviour
	{
		private const int BucketSize = 15;
		public static SimpleObjectPool Instance { get; private set; }

		private Dictionary<Type, Stack<object>> m_pool;

		public SimpleObjectPool()
		{
			m_pool = new Dictionary<Type, Stack<object>>();
			Instance = this;
		}

		private void OnDestroy()
		{
			m_pool.Clear();
			Instance = null;
		}

		public bool Push<T>(T p_object) where T : Component
		{
			Stack<object> bucket;
			if(!m_pool.TryGetValue(typeof(T), out bucket))
			{
				bucket = new Stack<object>(BucketSize);
				m_pool[typeof(T)] = bucket;
			}

			if(bucket.Count >= BucketSize)
			{
				return false;
			}
			else
			{
				bucket.Push(p_object);
				p_object.gameObject.SetActive(false);
				p_object.transform.SetParent(this.transform);
				return true;
			}
		}

		public T Pop<T>() where T : Component
		{
			Stack<object> bucket;
			if (m_pool.TryGetValue(typeof(T), out bucket))
			{
				if (bucket.Count >= 1)
				{
					T obj = (T)bucket.Pop();
					obj.gameObject.SetActive(true);
					return obj;
				}
			}

			return null;
		}
	}
}
