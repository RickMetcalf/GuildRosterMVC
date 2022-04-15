using Microsoft.AspNetCore.Mvc.Rendering;

namespace GuildRosterMVC.Models
{
    public class CascadingModel
    {
        public List<SelectListItem> WowClasses { get; set; }
        public List<SelectListItem> Specializations { get; set; }
        public int WowClassId { get; set; }
        public int SpecializationId { get; set; }   
        public CascadingModel()
        {
            this.WowClasses = new List<SelectListItem>();
            this.Specializations = new List<SelectListItem>();
        }
    }
}
