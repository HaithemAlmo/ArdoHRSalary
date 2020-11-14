using System.ComponentModel.DataAnnotations;
using Almotkaml.HR.Resources;

namespace Almotkaml.HR
{
    public enum LeaderType
    {
        [Display(ResourceType = typeof(Title), Name = nameof(Title.Unknown))]
        unknown = 0,
        [Display(ResourceType = typeof(Title), Name = nameof(Title.OfficeManager))]
        OfficeManager = 1,
        [Display(ResourceType = typeof(Title), Name = nameof(Title.DirectorDepartmen))]
        DirectorDepartmen =2
    }
}
