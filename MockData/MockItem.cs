using LolTrack.Models;

namespace LolTrack.MockData
{
	public class MockItem
	{
		private static List<Item> _items = new List<Item>();
		public static List<Item> GetMockItems()
		{
			return _items;
		}
	}
}
