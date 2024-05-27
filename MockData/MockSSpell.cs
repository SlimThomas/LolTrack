using LolTrack.Models;

namespace LolTrack.MockData
{
    public class MockSSpell
    {

        private static List<SSpell> _SSpells = new List<SSpell>()
        {
            new SSpell(1, SSpells.Flash, "Flash is a location-targeted summoner spell that causes your champion to blink to the location in range of your cursor.", "Flash_HD.jpg"),
            new SSpell(2, SSpells.Ignite, "Ignite is a unit-targeted summoner spell that burns an enemy champion for a few seconds, dealing periodic true damage, applying healing reduction, and revealing the target over the duration.", "Ignite_HD.jpg"),
            new SSpell(3, SSpells.Teleport, "Teleport is a unit-targeted summoner spell that blinks your champion to the target allied unit after a few seconds of channeling.", "Teleport_HD.jpg"),
            new SSpell(4, SSpells.Heal, "Heal is an auto-targeted summoner spell that instantly restores health to your champion and an ally while also granting a small burst of movement speed.", "Heal_HD.jpg"),
            new SSpell(5, SSpells.Ghost, "Ghost is a self-targeted summoner spell that increases your champion's movement speed and grants them the ability to ignore unit collision for a few seconds.", "Ghost_HD.jpg"),
            new SSpell(6, SSpells.Barrier, "Barrier is a self-targeted summoner spell that shields your champion from damage for a few seconds.", "Barrier_HD.jpg"),
            new SSpell(7, SSpells.Exhaust, "Exhaust is a unit-targeted summoner spell that slows an enemy champion's movement speed and reduces their damage dealt for a few seconds.","Exhaust_HD.jpg"),
            new SSpell(8, SSpells.Smite, "Smite is a unit-targeted summoner spell that deals true damage to the target large or medium monster, enemy minion, or pet.", "Smite_HD.jpg")
            
        };

        public static List<SSpell> GetMockSSpells()
        {
            return _SSpells; 
        }


    }
}
