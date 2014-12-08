using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace WidgetUI.Examples
{
	public class Item
	{
		public enum Rarity
		{
			Garbage,
			Common,
			Uncommon,
			Rare,
			Legendary,
		}

		public string name;
		public Sprite icon;
		public float price;
		public Rarity rarity;
	}
}
