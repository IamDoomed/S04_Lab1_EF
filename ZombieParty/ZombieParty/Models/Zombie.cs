using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZombieParty.Models
{
    public class Zombie
    {
        [Key]
        public int Id { get; set; }

        [Length(5, 20, ErrorMessage = "{0} requires a value between {1} and {2}.")]
        public string Name { get; set; }

        // FACULTATIF on peut formellement identifier le champ lien
        // sinon le champ de foreignKey sera auto généré dans la BD
        [Display(Name = "Zombie Type")]
        [ForeignKey("ZombieType")]
        public int ZombieTypeId { get; set; }
        public ZombieType ZombieType { get; set; }

        [Range(1, 10, ErrorMessage = "{0} requires a value between {1} and {2}.")]
        public int Point { get; set; }
        [StringLength(255, ErrorMessage = "{0} cannot exceed {1} characters.")]
        public string ShortDesc { get; set; }

        // zombies peuvent avoir plusieurs huntinglogs
        //un HuntingLog peut avoir plusieurs Zombies
        IEnumerable<HuntingLog>? DesHuntingLogs { get; set; }
    }
}
