using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildRosterModels
{
    public class GuildRank
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string GuildRankName { get; set; }

        public virtual List<Player> Players { get; set; } = new List<Player> { };
    }
}
