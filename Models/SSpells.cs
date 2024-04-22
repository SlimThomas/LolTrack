namespace LolTrack.Models
{
    public class SSpells
    {

        public int SSpellID { get; set; }
        public Enum SpellType { get; set; }
        public string SpellDesc { get; set; }

        public SSpells(int sSpellID, Enum spellType, string spellDesc)
        {
            SSpellID = sSpellID;
            SpellType = spellType;
            SpellDesc = spellDesc;
        }
    }
}
