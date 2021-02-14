using Almotkaml.Attributes;
using Almotkaml.HR.Models.Resources;
using Almotkaml.HR.Resources;
using Almotkaml.Resources;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Almotkaml.HR.Models
{
    public class PersonalModel : IValidatable
    {
        public int EmployeeId { get; set; }

        /// <summary>
        /// add by ali alherbade 19-08-2019
        /// </summary>
        /// 
        [Required(ErrorMessageResourceType = typeof(SharedMessages),ErrorMessageResourceName = nameof(SharedMessages.IsRequired))]
        [Display(ResourceType = typeof(Title), Name = nameof(Title.IsActive))]
        public bool IsActive { get; set; }

        [RegularExpression(@"^[\u0600-\u06FF,-][ \u0600-\u06FF,-]*$", ErrorMessage = "الرجاء إدخال حروف عربية فقط")]
        [Required(ErrorMessageResourceType = typeof(SharedMessages),ErrorMessageResourceName = nameof(SharedMessages.IsRequired))]
        [Display(ResourceType = typeof(Title),Name = nameof(Title.FirstName))]
        public string FirstName { get; set; }

        [RegularExpression(@"^[\u0600-\u06FF,-][ \u0600-\u06FF,-]*$", ErrorMessage = "الرجاء إدخال حروف عربية فقط")]
        [Required(ErrorMessageResourceType = typeof(SharedMessages),ErrorMessageResourceName = nameof(SharedMessages.IsRequired))]
        [Display(ResourceType = typeof(Title), Name = nameof(Title.FatherName))]
        public string FatherName { get; set; }

        [RegularExpression(@"^[\u0600-\u06FF,-][ \u0600-\u06FF,-]*$", ErrorMessage = "الرجاء إدخال حروف عربية فقط")]
        [Required(ErrorMessageResourceType = typeof(SharedMessages),ErrorMessageResourceName = nameof(SharedMessages.IsRequired))]
        [Display(ResourceType = typeof(Title), Name = nameof(Title.GrandfatherName))]
        public string GrandfatherName { get; set; }

        [RegularExpression(@"^[\u0600-\u06FF,-][ \u0600-\u06FF,-]*$", ErrorMessage = "الرجاء إدخال حروف عربية فقط")]
        [Required(ErrorMessageResourceType = typeof(SharedMessages),ErrorMessageResourceName = nameof(SharedMessages.IsRequired))]
        [Display(ResourceType = typeof(Title),Name = nameof(Title.LastName))]
        public string LastName { get; set; }

        [RegularExpression(@"^[a-zA-Z]+[a-zA-Z-_]*$", ErrorMessage = "االرجاء إدخال حروف إنجليزية فقط")]
        [Display(ResourceType = typeof(Title), Name = nameof(Title.EnglishFirstName))]
        public virtual string EnglishFirstName { get; set; }

        [RegularExpression(@"^[a-zA-Z]+[a-zA-Z-_]*$", ErrorMessage = "االرجاء إدخال حروف إنجليزية فقط")]
        [Display(ResourceType = typeof(Title),Name = nameof(Title.EnglishFatherName))]
        public virtual string EnglishFatherName { get; set; }

        [RegularExpression(@"^[a-zA-Z]+[a-zA-Z-_]*$", ErrorMessage = "االرجاء إدخال حروف إنجليزية فقط")]
        [Display(ResourceType = typeof(Title),Name = nameof(Title.EnglishGrandfatherName))]
        public virtual string EnglishGrandfatherName { get; set; }

        [RegularExpression(@"^[a-zA-Z]+[a-zA-Z-_]*$", ErrorMessage = "االرجاء إدخال حروف إنجليزية فقط")]
        [Display(ResourceType = typeof(Title),Name = nameof(Title.EnglishLastName))]
        public virtual string EnglishLastName { get; set; }

        [RegularExpression(@"^[\u0600-\u06FF,-][ \u0600-\u06FF,-]*$", ErrorMessage = "الرجاء إدخال حروف عربية فقط")]
        [Display(ResourceType = typeof(Title),Name = nameof(Title.MotherName))]
        public string MotherName { get; set; }
          
        [Required(ErrorMessageResourceType = typeof(SharedMessages),ErrorMessageResourceName = nameof(SharedMessages.IsRequired))]
        [Display(ResourceType = typeof(Title), Name = nameof(Title.Gender))]
        public Gender Gender { get; set; }           

        [Date]
        [Display(ResourceType = typeof(Title),Name = nameof(Title.BirthDate))]
          public string BirthDate { get; set; }

        [RegularExpression(@"^[a-zA-Z\u0600-\u06FF,-][ a-zA-Z-_\u0600-\u06FF,-]*$", ErrorMessage = "الرجاء إدخال حروف  فقط")]
        [Display(ResourceType = typeof(Title),Name = nameof(Title.BirthPlace))]
        public string BirthPlace { get; set; }

        [RegularExpression(@"^[0-9]*$", ErrorMessage = "الرجاء إدخال ارقام فقط")]
        [MaxLength(12, ErrorMessageResourceType = typeof(ValidationMessages),ErrorMessageResourceName = nameof(ValidationMessages.NationalNumber))]
        [MinLength(12, ErrorMessageResourceType = typeof(ValidationMessages),ErrorMessageResourceName = nameof(ValidationMessages.NationalNumber))]
        [Display(ResourceType = typeof(Title), Name = nameof(Title.NationalNumber))]
        public string NationalNumber { get; set; }
                        
        [Required(ErrorMessageResourceType = typeof(SharedMessages),ErrorMessageResourceName = nameof(SharedMessages.IsRequired))]
        [Display(ResourceType = typeof(Title),Name = nameof(Title.Religion))]
        public Religion Religion { get; set; }
           
        public IEnumerable<NationalityListItem> NationalityList { get; set; } = new HashSet<NationalityListItem>();
        public IEnumerable<BranchListItem> BranchList { get; set; } = new HashSet<BranchListItem>();
        public IEnumerable<PlaceListItem> PlaceList { get; set; } = new HashSet<PlaceListItem>();
           
        [Display(ResourceType = typeof(Title), Name = nameof(Title.Nationality))]
        public int? NationalityId { get; set; }
            
        [Display(ResourceType = typeof(Title),Name = nameof(Title.Branch))]
        public int? BranchId { get; set; }

        [Display(ResourceType = typeof(Title),Name = nameof(Title.Place))]
        public int? PlaceId { get; set; }

        [RegularExpression(@"^[a-zA-Z\u0600-\u06FF,-][ a-zA-Z-_\u0600-\u06FF,-]*$", ErrorMessage = "الرجاء إدخال حروف فقط")]
        [Display(ResourceType = typeof(Title),Name = nameof(Title.Address))]
        public string Address { get; set; }

        [RegularExpression(@"^[0-9]*$", ErrorMessage = "االرجاء إدخال ارقام فقط")]
        [Display(ResourceType = typeof(Title), Name = nameof(Title.Phone))]
        public string Phone { get; set; }

        [RegularExpression(@"^[a-zA-Z]+[a-zA-Z-_]*$", ErrorMessage = "االرجاء إدخال حروف إنجليزية فقط")]
        [Display(ResourceType = typeof(Title),Name = nameof(Title.Email))]
        public string Email { get; set; }   
        
        [Display(ResourceType = typeof(Title),Name = nameof(Title.SocialStatus))]
        public SocialStatus SocialStatus { get; set; }

        [RegularExpression(@"^[0-9]*$", ErrorMessage = "االرجاء إدخال ارقام فقط")]
        [MaxLength(30, ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = nameof(ValidationMessages.ChildernCount))]
        [MinLength(1, ErrorMessageResourceType = typeof(ValidationMessages), ErrorMessageResourceName = nameof(ValidationMessages.ChildernCount))]
        [Display(ResourceType = typeof(Title),Name = nameof(Title.ChildernCount))]
        public int? ChildernCount { get; set; }   
        
        [Display(ResourceType = typeof(Title), Name = nameof(Title.LibyanOrForeigner))]
        public LibyanOrForeigner LibyanOrForeigner { get; set; }

        [Display(ResourceType = typeof(Title), Name = nameof(Title.BloodType))]
        public BloodType BloodType { get; set; }

        public byte[] Image { get; set; }
        public bool ImageIsSet => Image != null && Image.Length > 0;
        public bool HaveImage { get; set; }
        public BookletModel Booklet { get; set; }
        public PassportModel Passport { get; set; }
        public IdentificationCardModel IdentificationCard { get; set; }
        public ContactInfoModel ContactInfo { get; set; }
        public bool CanSubmit { get; set; }


        public virtual void Validate(ModelState modelState)
        {
            if (LibyanOrForeigner == LibyanOrForeigner.Libyan &&
                string.IsNullOrWhiteSpace(NationalNumber))
                modelState.AddError(m => NationalNumber,
                    string.Format(SharedMessages.IsRequired, Title.NationalNumber));
        }


    }
}