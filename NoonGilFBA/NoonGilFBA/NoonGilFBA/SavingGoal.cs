using System;
namespace NoonGilFBA
{
    public class SavingGoal
    {
        private decimal currentSavings;
        private decimal savingGoals;
        private decimal deposits;
        private int months;
        private int weeks;
        private int days;

        public SavingGoal(decimal currentSavings ,decimal savingGoals, decimal deposits,int months, int weeks, int days)
        {
            CurrentSavings = currentSavings;
            SavingGoals = savingGoals;
            Deposits = deposits;
            Months = months;
            Weeks = weeks;
            Days = days;
        }

        public decimal CurrentSavings
        {
            get { return currentSavings; }
            set { currentSavings = value; }
        }

        public decimal SavingGoals
        {
            get { return savingGoals; }
            set { savingGoals = value; }
        }

        public decimal Deposits
        {
            get { return deposits; }
            set { deposits = value; }
        }

        public int Months
        {
            get { return months; }
            set { months = value; }
        }

        public int Weeks
        {
            get { return weeks; }
            set { weeks = value; }
        }

        public int Days
        {
            get { return days; }
            set { days = value; }
        }


    }
}

