using LolTrack.Models;

namespace LolTrack.MockData
{
    public class MockSSpell
    {

        private static List<SSpell> _SSpells = new List<SSpell>()
        {
            new SSpell(1, SSpells.Flash, "placeholder", "Flash.png"),
            new SSpell(2, SSpells.Ignite, "placeholder", "Ignite.png"),
            new SSpell(3, SSpells.Teleport, "placeholder", "TP.png"),
            new SSpell(4, SSpells.Heal, "placeholder", "Heal.png"),
            new SSpell(5, SSpells.Ghost, "placeholder", "Ghost.png"),
            new SSpell(6, SSpells.Barrier, "placeholder", "Barrier.png"),
            new SSpell(7, SSpells.Exhaust, "placeholder","Exhaust.png"),
            new SSpell(8, SSpells.Smite, "placeholder", "Smite.png"),
            new SSpell(9, SSpells.Cleanse, "placeholder", "Cleanse.png")
        };

        public static List<SSpell> GetMockSSpells()
        {
            return _SSpells; 
        }


    }
}
