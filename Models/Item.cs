using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LolTrack.Models
{
	public class Item
	{
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemID { get; set; }
		[Required]
        public string ItemName { get; set; }
		[Required]
        public string ItemDesc { get; set; }
		[Required]
        public int ItemValue { get; set; }

		public Item()
		{
		}

		public Item(int itemID, string itemName, string itemDesc, int itemValue)
		{
			ItemID = itemID;
			ItemName = itemName;
			ItemDesc = itemDesc;
			ItemValue = itemValue;
		}
	}
}
