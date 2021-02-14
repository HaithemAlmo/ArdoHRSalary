using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Almotkaml.Resources;
using System.ComponentModel.DataAnnotations;
using Almotkaml.HR.Resources;

namespace Almotkaml.HR.Models
{

    public class CourtModel
    {
        public IEnumerable<CourtGridRow> CourtGrid { get; set; } = new HashSet<CourtGridRow>();
        public bool CanCreate { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }

        public int CourtId { get; set; }

        [Required(ErrorMessageResourceType = typeof(SharedMessages),
          ErrorMessageResourceName = nameof(SharedMessages.IsRequired))]
        [Display(ResourceType = typeof(Title),
          Name = nameof(Title.Court))]
        public string CourtName { get; set; }
    }

    public class CourtGridRow
    {
        public int CourtId { get; set; }
        public string CourtName { get; set; }
    }

    public class CourtListItem
    {
        public int CourtId { get; set; }
        public string CourtName { get; set; }
    }
}
