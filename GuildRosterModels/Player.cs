using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace GuildRosterModels
{
    public class Player
    {
        [Required]
        public int Id { get; set; } 
        [Required, StringLength(12)]
        public string PlayerName { get; set; }

        [Required]
        public int WowClassId { get; set; }
        [Required]
        public int? SpecializationId { get; set; }
       
        
        [Required]
        public int RoleId { get; set; }
        public int? TeamId { get; set; }
        [Required]
        public int GuildRankId { get; set; }
        public virtual WowClass? WowClass { get; set; }
        public virtual Specialization? Specialization { get; set; }

        public virtual PlayerRole? Role { get; set; }
        public virtual Team? Team { get; set; }
        public virtual GuildRank? GuildRank { get; set; }

        public override string ToString()
        {
            return PlayerName + " ";
        }
    }
}
