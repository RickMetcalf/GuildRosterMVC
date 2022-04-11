using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GuildRosterModels
{
    public class Team
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string TeamName { get; set; }

        public virtual List<Player> Players { get; set; } = new List<Player> { };

    }
}
