using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SSpellID { get; set; }
        [Required]
        public SSpells SpellType { get; set; }
        [Required]
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
