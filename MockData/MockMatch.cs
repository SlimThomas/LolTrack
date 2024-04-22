using LolTrack.Models;
using System.Runtime.CompilerServices;

namespace LolTrack.MockData
{
    public class MockMatch
    {
        
        private static List<Match> _matches = new List<Match>();

        public static List<Match> GetMockMatches()
        {
            return _matches; 
        }
        
        
       



    }
}
