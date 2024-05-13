using LolTrack.Models;
using System.Runtime.CompilerServices;

namespace LolTrack.MockData
{
    public class MockMatch
    {

        private static List<Match> _matches = new List<Match>()
        {
            new Match(1, false, 2, 4, 2, 2, 20, LaneType.Top, Items.HealthPotion, Champions.Ksante, Runes.Resolve, SSpells.Teleport, 202),
            new Match(2, true, 10, 2, 20, 15, 40, LaneType.Jungle, Items.DoransBlade, Champions.Renekton, Runes.Domination, SSpells.Heal, 300),
            new Match(3, false, 0, 20, 0, 0, 10, LaneType.Middle, Items.WardingTotem, Champions.Annie, Runes.Precision, SSpells.Exhaust, 10)
        };

        public static List<Match> GetMockMatches()
        {
            return _matches; 
        }
        
        
       



    }
}
