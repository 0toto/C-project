using System;
namespace NoonGilFBA
{
    public class UserIncome
    {
        private string jobName;
        private decimal salaryWage;
        private int hoursWorked;        // in a day
        private int daysWorked;         // in a week

        public UserIncome(string jobName, decimal salaryWage, int hoursWorked, int daysWorked)
        {
            JobName = jobName;
            SalaryWage = salaryWage;
            HoursWorked = hoursWorked;
            DaysWorked = daysWorked;
        }

        public string JobName
        {
            get { return jobName; }
            set { jobName = value; }
        }

        public decimal SalaryWage
        {
            get { return salaryWage; }
            set { salaryWage = value; }
        }

        public int HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        public int DaysWorked
        {
            get { return daysWorked; }
            set { daysWorked = value; }
        }

        public decimal TotalSalary()  // in a week
        {
            return SalaryWage * HoursWorked * DaysWorked;
        }



    }
}

