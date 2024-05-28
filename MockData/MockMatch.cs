using LolTrack.Models;
using System.Runtime.CompilerServices;

namespace LolTrack.MockData
{
    public class MockMatch
    {

        private static List<Match> _matches = new List<Match>()
        {
            new Match(1,1, 1, false, 2, 4, 2, 2, 20, "Top", "Ksante", "Teleport", 202),
            new Match(2,1, 1, true, 10, 2, 20, 15, 40, "Jungle", "Renekton", "Heal", 300),
            new Match(3,3, 3, false, 0, 20, 0, 0, 10, "Top", "Ksante", "Teleport", 10),
            new Match(4,2, 2, true, 10, 5, 20, 6, 20, "Bottom", "Aatrox",  "Heal", 260),
            new Match(5,2, 2, false, 0, 3, 10, 3.33, 10, "Top",  "Teemo", "Teleport", 100),
            new Match(6,2, 2, true, 33, 20, 10, 2.10, 25, "Middle", "Diana", "Flash", 250),
            new Match(7,3, 3, true, 33, 0, 0, 33, 30, "Jungle", "Poppy", "Barrier", 300), 
            new Match(8,3, 3, false, 0, 30, 0, 0, 10, "Middle", "Illaoi", "Teleport", 10),
            new Match(9,3, 3, true, 20, 0, 20, 40, 50, "Support", "Garen", "Teleport", 300), 
            new Match(10,4, 4, true, 16, 2, 8, 12, 20, "Middle", "Yorick", "Ignite", 200), 
            new Match(11,4, 4, true, 34, 22, 3, 1.6, 21, "Bottom", "Caitlyn", "Heal", 200),
            new Match(12,4, 4, false, 0, 14, 2, 0.14, 12, "Bottom", "Illaoi", "Ignite", 120), 
            new Match(13,5, 5, true, 20, 12, 2, 1.83, 34, "Top", "Leona", "Barrier", 202),
            new Match(14,5, 5, false, 8, 30, 2, 0.33, 20, "Jungle", "Renekton", "Barrier", 80),
            new Match(15,5, 5, true, 54, 2, 22, 38, 50, "Support", "Yorick", "Exhaust", 450)
            
        };

        public static List<Match> GetMockMatches()
        {
            return _matches; 
        }
        
        
       



    }
}
