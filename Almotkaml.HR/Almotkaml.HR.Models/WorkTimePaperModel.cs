using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Almotkaml.HR.Resources;
using Almotkaml.Resources;

namespace Almotkaml.HR.Models
{
    public class WorkTimePaperModel
    {
        public bool CanCreate { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }
        public bool CanSave { get; set; }
        public IEnumerable<WorkTimePaperGridRow> WorkTimePaperGrid { get; set; } = new HashSet<WorkTimePaperGridRow>();
        public IEnumerable<EmployeeGridRow> EmployeeGrid { get; set; } = new HashSet<EmployeeGridRow>();

        public int WorkTimePaperId { get; set; }
        [Display(ResourceType = typeof(Title), Name = nameof(Title.Name))]
        public string DayWork { get; set; }
        [Display(ResourceType = typeof(Title), Name = nameof(Title.EmployeeName))]
        public int EmployeeId { get; set; }
        [Display(ResourceType = typeof(Title),Name = nameof(Title.EmployeeName))]
        public string EmployeeName { get; set; }
        [Required(ErrorMessageResourceType = typeof(SharedMessages), ErrorMessageResourceName = nameof(SharedMessages.IsRequired))]
        [Range(1, 12, ErrorMessageResourceType = typeof(SharedMessages), ErrorMessageResourceName = nameof(SharedMessages.ShouldSelected))]
        [Display(ResourceType = typeof(Title), Name = nameof(Title.Month))]
        public int ThisMonth { get; set; }
        [Required(ErrorMessageResourceType = typeof(SharedMessages),
         ErrorMessageResourceName = nameof(SharedMessages.IsRequired))]
        [Range(1900, 2100, ErrorMessageResourceType = typeof(SharedMessages), ErrorMessageResourceName = nameof(SharedMessages.ShouldSelected))]
        [Display(ResourceType = typeof(Title), Name = nameof(Title.Year))]
        public int ThisYear { get; set; }
        public bool CanSubmit { get; set; }
        [Display(ResourceType = typeof(Title), Name = nameof(Title.Saturday))]
        public bool Saturday { get; set; }
        [Display(ResourceType = typeof(Title), Name = nameof(Title.Sunday))]
        public bool Sunday { get; set; }
        [Display(ResourceType = typeof(Title), Name = nameof(Title.Monday))]
        public bool Monday { get; set; }
        [Display(ResourceType = typeof(Title), Name = nameof(Title.Tuesday))]
        public bool Tuesday { get; set; }
        [Display(ResourceType = typeof(Title), Name = nameof(Title.Wednesday))]
        public bool Wednesday { get; set; }
        [Display(ResourceType = typeof(Title), Name = nameof(Title.Thursday))]
        public bool Thursday { get; set; }
        [Display(ResourceType = typeof(Title), Name = nameof(Title.Friday))]
        public bool Friday { get; set; }

        public IEnumerable<WorkTimePaperCheck> Check { get; set; } = new HashSet<WorkTimePaperCheck>();
        public class WorkTimePaperCheck
        {
            public bool SaCheck { get; set; }
            public bool SuCheck { get; set; }
            public bool MoCheck { get; set; }
            public bool TuCheck { get; set; }
            public bool WeCheck { get; set; }
            public bool ThCheck { get; set; }
            public bool FrCheck { get; set; }
        }


    }

    public class WorkTimePaperGridRow
    {


        public int WorkTimePaperId { get; set; }
 
        public string DayWork { get; set; }
        public string MonthYear { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
    }

      
    

        public class WorkTimePaperFormModel
{
        public int WorkTimePaperId { get; set; }

        public string DayWork { get; set; }
        [Display(ResourceType = typeof(Title), Name = nameof(Title.Name))]

        public IEnumerable<EmployeeGridRow> EmployeeGrid { get; set; } = new HashSet<EmployeeGridRow>();
    

        public IEnumerable<WorkTimePaperGridRow> WorkTimePaperGridRow { get; set; } = new HashSet<WorkTimePaperGridRow>();
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }


    }
    public class WorkTimePaperListItem
    {
        public int WorkTimePaperId { get; set; }
        public string Name { get; set; }
    }

}
