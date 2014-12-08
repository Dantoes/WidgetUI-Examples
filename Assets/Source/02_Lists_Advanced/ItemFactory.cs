using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace WidgetUI.Examples
{
	public class ItemFactory
	{
		private static readonly string[] RandomAdjectives = 
		{
			"annoying", "bad", "better", "beautiful", "brainy", "breakable", "busy", "careful", "cautious", "clever", "clumsy", "concerned", "crazy", "curious", "dead", "different", 
			"difficult", "doubtful", "easy", "expensive", "famous", "fragile", "frail", "gifted", "helpful", "helpless", "horrible", "important", "impossible", "inexpensive", 
			"innocent", "inquisitive", "modern", "mushy", "odd", "open", "outstanding", "poor", "powerful", "prickly", "puzzled", "real", "rich", "stupid", "super", "talented", 
			"tame", "tender", "tough", "uninterested", "vast", "wandering", "wild", "wrong", "angry", "annoyed", "anxious", "arrogant", "ashamed", "awful", "bad", "bewildered", 
			"black", "blue", "bored", "clumsy", "combative", "condemned", "confused", "crazy, flipped-out", "creepy", "cruel", "dangerous", "defeated", "defiant", "depressed", 
			"disgusted", "disturbed", "dizzy", "dull", "embarrassed", "envious", "evil", "fierce", "foolish", "frantic", "frightened", "grieving", "broad", "chubby", "crooked", 
			"curved", "deep", "flat", "high", "hollow", "low", "narrow", "round", "shallow", "skinny", "square", "steep", "straight", "wide", "big", "colossal", "fat", "gigantic", 
			"great", "huge", "immense", "large", "little", "massive", "miniature", "petite", "puny", "scrawny", "short", "small", "tall", "tiny", "cooing", "deafening", "faint", 
			"harsh", "high-pitched", "hissing", "hushed", "husky", "loud", "melodic", "moaning", "mute", "noisy", "purring", "quiet", "raspy", "resonant", "screeching", "shrill", 
			"silent", "soft", "squealing", "thundering", "voiceless", "whispering", "ancient", "brief", "Early", "fast", "late", "long", "modern", "old", "old-fashioned", "quick", 
			"rapid", "short", "slow", "swift", "young", "bitter", "delicious", "fresh", "juicy", "ripe", "rotten", "salty", "sour", "spicy", "stale", "sticky", "strong", "sweet", 
			"tart", "tasteless", "tasty", "thirsty", "fluttering", "fuzzy", "greasy", "grubby", "hard", "hot", "icy", "loose", "melted", "nutritious", "plastic", "prickly", "rainy", 
			"rough", "scattered", "shaggy", "shaky", "sharp", "shivering", "silky", "slimy", "slippery", "smooth", "soft", "solid", "steady", "sticky", "tender", "tight", "uneven", 
			"weak", "wet", "wooden", "yummy", "boiling", "breezy", "broken", "bumpy", "chilly", "cold", "cool", "creepy", "crooked", "cuddly", "curly", "damaged", "damp", "dirty", 
			"dry", "dusty", "filthy", "flaky", "fluffy", "freezing", "hot", "warm", "wet ", "abundant", "empty", "few", "heavy", "light", "substantial"
		};

		private static readonly string[] RandomObjects = 
		{
			"apple", "bag", "ball","bed", "berry", "blade", "boat", "bone", "book", "boot", "bottle", "brain", "bucket", "chain", "door", "drain", "drawer", "dress", "fish", "fork", 
			"glove", "gun", "hammer", "hat", "horse","jewel", "knife", "map", "plate", "potato", "ring", "shirt", "shoes", "socks", "stick"
		};

		private static readonly string[] RandomTowns = 
		{
			"Redmaple", "Belwall", "Wellhollow", "Swyngate", "Hollowwyn", "Highcrest", "Redford", "Crystalden", "Lochwell", "Bywall", "Bluehedge", "Northden", "Foxpond", "Beachgate", 
			"Deepapple", "Woodviolet", "Eastborough", "Wyvernview", "Dorport", "Esterhaven", "Merrowport", "Highbush", "Fallness", "Aldbush", "Westcastle", "Waypond", "Wellglass", 
			"Falldeer", "Waterbank", "Mallowshade", "Bayhedge", "Orbeach", "Ironmoor", "Bridgeacre", "Orlea", "Valmead", "Freymont", "Ironhollow", "Ironpond", "Fairmallow", "Waterham", 
			"Goldby", "Griffindell", "Flowermeadow"
		};

		private Sprite[] m_icons;

		public ItemFactory(Sprite[] p_icons)
		{
			m_icons = p_icons;
		}

		public Item CreateRandomItem()
		{
			Item item = new Item();
			item.rarity = (Item.Rarity)UnityEngine.Random.Range(0, 5);
			item.price = 5 + 100 * (int)item.rarity + 50 * (int)item.rarity * UnityEngine.Random.value;
			item.icon = m_icons[UnityEngine.Random.Range(0, m_icons.Length - 1)];

			item.name = Capitalize(RandomObjects[UnityEngine.Random.Range(0, RandomObjects.Length - 1)]);
			if (item.rarity >= Item.Rarity.Uncommon)
			{
				string adjective = Capitalize(RandomAdjectives[UnityEngine.Random.Range(0, RandomAdjectives.Length - 1)]);
				item.name = String.Format("{0} {1}", adjective, item.name);
			}
			if (item.rarity >= Item.Rarity.Legendary)
			{
				string town = Capitalize(RandomTowns[UnityEngine.Random.Range(0, RandomTowns.Length - 1)]);
				item.name = String.Format("{0} of {1}", item.name, town);
			}


			return item;
		}

		private String Capitalize(string p_string)
		{
			return Char.ToUpper(p_string[0]) + p_string.Substring(1);
		}
	}
}
