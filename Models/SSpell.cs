namespace LolTrack.Models
{
    public enum SSpells
    {
        Flash,
        Ignite,
        Teleport,
        Heal,
        Ghost,
        Barrier,
        Exhaust,
        Smite,
        Cleanse
    }
    public class SSpell
    {

        public int SSpellID { get; set; }
        public SSpells SpellType { get; set; }
        public string SpellDesc { get; set; }
        public string SSpellSplash { get; set; }

        public SSpell(int sSpellID, SSpells spellType, string spellDesc, string sSpellSplash)
        {
            SSpellID = sSpellID;
            SpellType = spellType;
            SpellDesc = spellDesc;
            SSpellSplash = sSpellSplash;
        }
    }
}
