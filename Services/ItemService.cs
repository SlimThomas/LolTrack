using LolTrack.MockData;
using LolTrack.Models;

namespace LolTrack.Services
{
	public class ItemService
	{
		private List<Item> _items;
		public ItemService()
		{
			_items = MockItem.GetMockItems();
		}
		public void Add(Item item)
		{
			_items.Add(item);
		}
		public Item GetItem(int id)
		{
			foreach (Item item in _items)
			{
				if (item.ItemID == id) return item;
			}
			return null;
		}
		public void UpdateChamp(Item item)
		{
			if (item != null)
			{
				foreach (Item i in _items)
				{
					if (i.ItemID == item.ItemID)
					{
						i.ItemDesc = item.ItemDesc;
						i.ItemName = item.ItemName;
						i.ItemValue = item.ItemValue;
						i.ItemType = item.ItemType;
					}
				}
			}
		}
		public Item DeleteItem(int? itemid)
		{
			Item itemToBeDeleted = null;
			foreach (Item item in _items)
			{
				if (item.ItemID == itemid)
				{
					itemToBeDeleted = item;
					break;
				}
			}
			if (itemToBeDeleted != null)
			{
				_items.Remove(itemToBeDeleted);
			}
			return itemToBeDeleted;
		}

		public List<Item> GetItems()
		{
			return _items;
		}
		public IEnumerable<Item> ItemSearch(string str)
		{
			var ItemSearchQ = from I in _items
							   where I.ItemName.Contains(str)
							   select I;
			return ItemSearchQ;
		}
		public IEnumerable<Item> SortByName()
		{
			var NameQ = from I in _items
						orderby I.ItemName ascending
						select I;
			return NameQ;
		}

		public IEnumerable<Item> SortByNameDesc()
		{
			var NameQ = from I in _items
						orderby I.ItemName descending
						select I;
			return NameQ;
		}
		public IEnumerable<Item> SortByValue()
		{
			var ValueQuery = from I in _items
							 orderby I.ItemValue ascending
							 select I;
			return ValueQuery;
		}

		public IEnumerable<Item> SortByPriceDescending()
		{
			var ValueQuery = from I in _items
							 orderby I.ItemValue descending
							 select I;
			return ValueQuery;
		}
	}
}
