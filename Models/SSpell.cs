namespace LolTrack.Models
{
    public class SSpell
    {

        public int SSpellID { get; set; }
        public Enum SpellType { get; set; }
        public string SpellDesc { get; set; }

        public SSpell(int sSpellID, Enum spellType, string spellDesc)
        {
            SSpellID = sSpellID;
            SpellType = spellType;
            SpellDesc = spellDesc;
        }
    }
}
