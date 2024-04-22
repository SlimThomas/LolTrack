using LolTrack.Models;

namespace LolTrack.MockData
{
    public class MockRunes
    {
       
        private static List<Rune> _runes = new List<Rune>();
        public static List<Rune> GetMockRunes()
        {
            return _runes; 
        }

    }
}
