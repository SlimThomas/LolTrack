using LolTrack.MockData;
using LolTrack.Models;

namespace LolTrack.Services
{
    public class SSpellService
    {
        private List<SSpell> _SSpells; 


        public SSpellService()
        {
            _SSpells = MockSSpell.GetMockSSpells();
        }

        public List<SSpell> GetSSPells()
        {
            return _SSpells;
        }

        public void AddSSpell(SSpell sspell)
        {
            _SSpells.Add(sspell);
        }

        public void UpdateSSpell (SSpell sspell)
        {
            if (sspell != null)
            {
                foreach(SSpell s in _SSpells)
                {
                    if (s.SSpellID == sspell.SSpellID)
                    {
                        s.SpellDesc = sspell.SpellDesc; 
                        s.SpellType = sspell.SpellType;
                    }
                }
            }
        }

        public SSpell DeleteSSpell(int? sspellId)
        {
            SSpell spellTobeDeleted = null; 
            foreach (SSpell s in _SSpells)
            {
                if (s.SSpellID == sspellId)
                {
                    spellTobeDeleted = s; break;
                }
            }
            if (spellTobeDeleted != null)
            {
                _SSpells.Remove(spellTobeDeleted);
            }
            return spellTobeDeleted; 
        }



    }
}
