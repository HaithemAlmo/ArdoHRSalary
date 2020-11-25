namespace Almotkaml.HR.Abstraction
{
    public interface IHumanResource : IApplication<IApplicationUser, ISettings, ICompanyInfo, Permission>
    {
        IUserActivityBusiness UserActivity { get; }
        IAccountBusiness Account { get; }
        IUserBusiness User { get; }
        IUserGroupBusiness UserGroup { get; }
        IAdjectiveEmployeeBusiness AdjectiveEmployee { get; }
        IAdjectiveEmployeeTypeBusiness AdjectiveEmployeeType { get; }
        IBranchBusiness Branch { get; }
        ICurrentSituationBusiness CurrentSituation { get; }
        IDepartmentBusiness Department { get; }
        IDivisionBusiness Division { get; }
        IEmployeeBusiness Employee { get; }
        IEmploymentTypeBusiness EmploymentType { get; }
        IJobBusiness Job { get; }
        //IJobInfoBusiness JobInfo { get; }
        //IMilitaryDataBusiness MilitaryData { get; }
        INationalityBusiness Nationality { get; }
        IPlaceBusiness Place { get; }
        IQualificationBusiness Qualification { get; }
        IQualificationTypeBusiness QualificationType { get; }
        IRewardBusiness Reward { get; }
        IRewardTypeBusiness RewardType { get; }
        ISanctionBusiness Sanction { get; }
        ISanctionTypeBusiness SanctionType { get; }
        ISpecialtyBusiness Specialty { get; }
        IStaffingBusiness Staffing { get; }
        IStaffingTypeBusiness StaffingType { get; }
        IStaffingClassificationBusiness StaffingClassification { get; }
        ISubSpecialtyBusiness SubSpecialty { get; }
        IUnitBusiness Unit { get; }
        IVacationBusiness Vacation { get; }
        IVacationTypeBusiness VacationType { get; }
        IExtraWorkBusiness ExtraWork { get; }
        ISelfCoursesBusiness SelfCourses { get; }
        IEvaluationBusiness Evaluation { get; }
        ITrainingCourseBusiness TrainingCourse { get; }
        IEndServicesBusiness EndServices { get; }
        IBounsBusiness Bouns { get; }
        IDegreeBusiness Degree { get; }
        IBankBusiness Bank { get; }
        IBankBranchBusiness BankBranch { get; }
        ISituationResolveJobBusiness SituationResolveJob { get; }
        ICountryBusiness Country { get; }
        ICityBusiness City { get; }
        IAbsenceBusiness Absence { get; }
        ITransferBusiness Transfer { get; }
        ICorporationBusiness Corporation { get; }
        IDelegationBusiness Delegation { get; }
        ISettingsBusiness Setting { get; }
        IPremiumBusiness Premium { get; }
        ISalaryBusiness Salary { get; }
        IAdvancePaymentBusiness AdvancePayment { get; }
        ISalaryInfoBusiness SalaryInfo { get; }
        IExactSpecialtyBusiness ExactSpecialty { get; }
        ICenterBusiness Center { get; }
        IOldSalaryBusiness OldSalary { get; }
        ISocialSecurityFundReportBusiness SocialSecurityFundReport { get; }
        ISolidarityFundReportBusiness SolidarityFundReport { get; }
        ITaxReportBusiness TaxReport { get; }
        IAdvancePaymentReportBusiness AdvancePaymentReport { get; }
        IHolidayBusiness Holiday { get; }
        ICompanyInfoBusiness CompanyInfo { get; }
        IHomeBusiness Home { get; }
        IBackUpRestoreBusiness BackUpRestore { get; }
        IRequestedQualificationBusiness RequestedQualification { get; }
        ITrainingBusiness Training { get; }
        IDevelopmentStateBusiness DevelopmentState { get; }
        IDevelopmentTypeABusiness DevelopmentTypeA { get; }
        IDevelopmentTypeBBusiness DevelopmentTypeB { get; }
        IDevelopmentTypeCBusiness DevelopmentTypeC { get; }
        IDevelopmentTypeDBusiness DevelopmentTypeD { get; }
        //IDevelopmentTypeEBusiness DevelopmentTypeE { get; }
        IDocumentTypeBusiness DocumentType { get; }
        ISalaryUnitBusiness SalaryUnit { get; }
        IClassificationOnWorkBusiness ClassificationOnWork { get; }
        IClassificationOnSearchingBusiness ClassificationOnSearching { get; }
        IRetirementBusiness Retirement { get; }
        ICoachBusiness Coach { get; }
        ICourseBusiness Course { get; }
        IEmployeeReportBusiness EmployeeReport { get; }
        ISettlementReportBusiness SettlementReport { get; }
        ISettlementVacationReportBusiness SettlementVacationReport { get; }
        ISettlementAbsenceReportBusiness SettlementAbsenceReport { get; }
        ISalarySettlementReportBusiness SalarySettlementReport { get; }
        IDiscountSettlementReportBusiness DiscountSettlementReport { get; }
        IPremiumSettlementReportBusiness PremiumSettlementReport { get; }
        IWorkTimePaperBusiness WorkTimePaper { get; }
    }
}