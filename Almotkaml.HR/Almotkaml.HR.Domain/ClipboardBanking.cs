using System;
using System.Collections.Generic;

namespace Almotkaml.HR.Domain
{
    public class ClipboardBanking
    {
       
        public int ClipboardBankingId { get;  set; }
        public int BankBranchID { get;  set; }
        public BankBranch  BankBranch { get;  set; }
        public DateTime SalaryMonth { get; set; }
        public decimal TotalSalaries { get; set; }
        public string InstrumentNumber { get; set; }
        public bool IsDelivered { get; set; }

        public static ClipboardBanking New(int bankBranchID,DateTime salaryMonth, decimal totalSalaries ,string instrumentNumber, bool isDelivered)
        {
            Check.NotNull (salaryMonth, nameof(salaryMonth));

            var clipboardBanking = new ClipboardBanking()
            {
                BankBranchID = bankBranchID,
                SalaryMonth = salaryMonth,
                TotalSalaries = totalSalaries,
                InstrumentNumber = instrumentNumber,
                IsDelivered = isDelivered,
            };


            return clipboardBanking;
        }

        public void Modify(int bankBranchID, DateTime salaryMonth, decimal totalSalaries, string instrumentNumber, bool isDelivered)
        {
            Check.NotNull(salaryMonth, nameof(salaryMonth));

            BankBranchID = bankBranchID;
            SalaryMonth = salaryMonth;
            TotalSalaries = totalSalaries;
            InstrumentNumber = instrumentNumber;
            IsDelivered = isDelivered;

        }

        public void Modify( bool isDelivered)
        {
            Check.NotNull(isDelivered, nameof(isDelivered));

            IsDelivered = isDelivered;

        }
    }
}