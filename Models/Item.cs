namespace LolTrack.Models
{
	public class Item
	{
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        public Enum ItemType { get; set; }
        public int ItemValue { get; set; }

		public Item()
		{
		}

		public Item(int itemID, string itemName, string itemDesc, Enum itemType, int itemValue)
		{
			ItemID = itemID;
			ItemName = itemName;
			ItemDesc = itemDesc;
			ItemType = itemType;
			ItemValue = itemValue;
		}
	}
}
