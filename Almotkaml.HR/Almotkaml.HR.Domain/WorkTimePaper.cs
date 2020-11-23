using System.Collections.Generic;


namespace Almotkaml.HR.Domain
{
    public class WorkTimePaper
    {
        public static WorkTimePaper New(string dayWork, int employeeId,bool saturday,bool sunday, bool monday, bool tuesday, bool wednesday, bool thursday, bool friday, int thisMonth, int thisYear)
        {
           Check.MoreThanZero(employeeId, nameof(employeeId));


            var workTimePaper = new WorkTimePaper()
            {
                DayWork = dayWork,
                EmployeeId = employeeId,
                Saturday=saturday,
                Sunday=sunday,
                Monday=monday,
                Tuesday=tuesday,
                Wednesday=wednesday,
                Thursday=thursday,
                Friday=friday,
                ThisMonth=thisMonth,
                ThisYear=thisYear,

            };


            return workTimePaper;
        }
    
        private WorkTimePaper()
        {

        }
        public int EmployeeId { get; internal set; }
        public Employee Employee { get; internal set; }
        public int WorkTimePaperId { get; private set; }
        public string DayWork { get; private set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public int ThisMonth { get; private set; }
        public int ThisYear { get; private set; }
        public void Modify(string dayWork, int employeeId, bool saturday, bool sunday, bool monday, bool tuesday, bool wednesday, bool thursday, bool friday,int thisMonth,int thisYear)
        {
            Check.MoreThanZero(employeeId, nameof(employeeId));

            DayWork = dayWork;
            EmployeeId = employeeId;          
            Saturday = saturday;
            Sunday = sunday;
            Monday = monday;
            Tuesday = tuesday;
            Wednesday = wednesday;
            Thursday = thursday;
            Friday = friday;
            ThisMonth = thisMonth;
            ThisYear = thisYear;

        }
        public void DAY(string dayWork, Employee employee, string saturday, string sunday, string monday, string tuesday, string wednesday, string thursday, string friday)
        {
            Check.NotEmpty(dayWork, nameof(dayWork));
            Check.NotNull(employee, nameof(employee));

          
          if(  Saturday == true)
            {
                saturday = "السبت";
            }
            if (Sunday == true)
            {
                sunday = "الاحد";
            }
           
            if (Tuesday  == true)
            {
                tuesday = "التلاثاء";
            }
            if (Wednesday == true)
            {
                wednesday = "الاربعاء";
            }
            if (Thursday == true)
            {
                thursday = "الخميس";
            }
            if (Friday == true)
            {
                friday = "الجمعة";
            }
        }
        public void Modify(string dayWork, Employee employee, bool saturday, bool sunday, bool monday, bool tuesday, bool wednesday, bool thursday, bool friday, int thisMonth, int thisYear)
        {
            Check.NotEmpty(dayWork, nameof(dayWork));
            Check.NotNull(employee, nameof(employee));

            DayWork = dayWork;
            Employee = employee;
            Saturday = saturday;
            Sunday = sunday;
            Monday = monday;
            Tuesday = tuesday;
            Wednesday = wednesday;
            Thursday = thursday;
            Friday = friday;
            ThisMonth = thisMonth;
            ThisYear = thisYear;

        }


    }

}