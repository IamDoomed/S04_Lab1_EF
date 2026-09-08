using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class HuntingLog
    {
        [Length(2, 25, ErrorMessage = "{0} requires a value between {1} and {2}.")]
        public string Title { get; set; }

        [StringLength(255, ErrorMessage = "{0} cannot exceed {1} characters.")]
        public string Description { get; set; }

        //un HuntingLog peut avoir plusieurs Zombies
        IEnumerable<Zombie> DesZombies { get; set; }
    }
}
