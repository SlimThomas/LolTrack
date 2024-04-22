using LolTrack.Models;

namespace LolTrack.MockData
{
    public class MockSSpell
    {
        
        private static List<SSpell> _SSpells = new List<SSpell>();

        public static List<SSpell> GetMockSSpells()
        {
            return _SSpells; 
        }


    }
}
