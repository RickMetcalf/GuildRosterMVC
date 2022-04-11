using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GuildRosterModels
{
    public class Specialization
    {

        [Required]
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string SpecName { get; set; }
        [Required]
        public int WowClassId { get; set; }
        [Required]
        public int RoleId { get; set; }

        public virtual List<Player> Player { get; set; } = new List<Player>();
        public virtual WowClass? WowClass { get; set; }

        public virtual Role? Role { get; set; }
    }
}
