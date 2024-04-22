using LolTrack.Models;

namespace LolTrack.MockData
{
    public class MockSSpells
    {
        
        private static List<SSpells> _SSpells = new List<SSpells>();

        public static List<SSpells> GetMockSSpells()
        {
            return _SSpells; 
        }


    }
}
