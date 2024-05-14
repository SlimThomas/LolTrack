using LolTrack.Models;

namespace LolTrack.MockData
{
    public class MockSSpell
    {

        private static List<SSpell> _SSpells = new List<SSpell>()
        {
            new SSpell(1, SSpells.Flash, "placeholder", "Flash_HD.jpg"),
            new SSpell(2, SSpells.Ignite, "placeholder", "Ignite_HD.jpg"),
            new SSpell(3, SSpells.Teleport, "placeholder", "Teleport_HD.jpg"),
            new SSpell(4, SSpells.Heal, "placeholder", "Heal_HD.jpg"),
            new SSpell(5, SSpells.Ghost, "placeholder", "Ghost_HD.jpg"),
            new SSpell(6, SSpells.Barrier, "placeholder", "Barrier_HD.jpg"),
            new SSpell(7, SSpells.Exhaust, "placeholder","Exhaust_HD.jpg"),
            new SSpell(8, SSpells.Smite, "placeholder", "Smite_HD.jpg")
            
        };

        public static List<SSpell> GetMockSSpells()
        {
            return _SSpells; 
        }


    }
}
