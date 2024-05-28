using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolTrack.Models
{
    public class Ability
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AbiID { get; set; }
        [Required]
        public int AbiChampID { get; set; }
        [Required]
        [StringLength(50)]
        public string AbilityName { get; set; }
        [Required]
        public string AbilityDesc { get; set; }

        public string AbilitySplash { get; set; }

        public Ability(int abiID, int abiChampID, string abilityName, string abilityDesc, string abilitySplash)
        {
            AbiChampID = abiChampID;
            AbiID = abiID;
            AbilityName = abilityName;
            AbilityDesc = abilityDesc;
            AbilitySplash = abilitySplash;
        }

        public Ability()
        {
        }
    }
}
