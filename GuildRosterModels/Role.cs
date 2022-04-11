using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildRosterModels
{
    public class Role
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string RoleName { get; set; }

        public virtual List<Specialization> Specs { get; set; } = new List<Specialization>();

        public virtual List<Player> Players { get; set; } = new List<Player>();
    }
}
