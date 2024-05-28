using LolTrack.MockData;
using LolTrack.Models;

namespace LolTrack.Services
{
    public class SSpellService
    {
        private List<SSpell> _SSpells;
        private DbService _dbService;

        public SSpellService(DbService dbService)
        {
            _SSpells = MockSSpell.GetMockSSpells();
            _dbService = dbService;
            //_dbService.SaveSSpels(_SSpells);
            //_SSpells = _dbService.GetSspells().Result;
        }

        public List<SSpell> GetSspells()
        {
            return _SSpells;
        }
        public SSpell GetSSpell(int id)
        {
            foreach (SSpell sspell in _SSpells)
            {
                if (sspell.SSpellID == id)
                {
                    return sspell; 
                }
            }
            return null; 
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
