using LolTrack.MockData;
using LolTrack.Models;

namespace LolTrack.Services
{
    public class RuneService
    {
        private List<Rune> _runes; 

        public RuneService() 
        {
            _runes = MockRunes.GetMockRunes();
        }

        public void AddRunes(Rune rune)
        {
            _runes.Add(rune);
        }

        public void UpdateRune(Rune rune)
        {
            if (rune != null)
            {
                foreach (Rune r in _runes)
                {
                    if (r.RuneID == rune.RuneID)
                    {
                        r.RuneDesc = rune.RuneDesc;
                        r.RuneType = rune.RuneType;
                        r.RunePageName = rune.RunePageName;
                    }
                }
            }
        }
        public List<Rune> GetRunes()
        {
            return _runes;
        }

        public Rune GetRune(int runeid)
        {
            foreach (Rune rune in _runes)
            {
                if (rune.RuneID == runeid)
                {
                    return rune; 
                }
            }
            return null; 

        }

        public Rune DeleteRune (int? runeId)
        {
            Rune runeToBeDeleted = null; 
            foreach (Rune rune in _runes)
            {
                if (rune.RuneID == runeId)
                {
                    runeToBeDeleted = rune;
                    break; 
                }
            }
            if (runeToBeDeleted != null)
            {
                _runes.Remove(runeToBeDeleted); 
            }
            return runeToBeDeleted; 
        }

    }
}
