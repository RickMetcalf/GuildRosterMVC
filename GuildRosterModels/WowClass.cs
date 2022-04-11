using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GuildRosterModels
{
    public class WowClass
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(16)]
        public string ClassName { get; set; }
        public virtual List<Specialization> Spec { get; set; } = new List<Specialization>();
        public virtual List<Player> Player { get; set; } = new List<Player>();

    }
}
