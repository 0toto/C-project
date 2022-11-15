using System;
namespace NoonGilFBA
{
    public class UserExpenses
    {
        private decimal expFood;            // groceries
        private decimal expHousing;         // rent
        private decimal expHealth;          // medications, doctor visits
        private decimal expInsurance;       // all types of insurance: car, life, housing
        private decimal expEducation;       // optional
        private decimal expPersonal;        // personal expenses: clothing, gifts, hobbies
        private PreAutoPayments userPreAutoPayments;

        public UserExpenses(decimal expFood, decimal expHousing, decimal expHealth, decimal expInsurance, decimal expEducation, decimal expPersonal, PreAutoPayments userPreAutoPayments)
        {
            ExpFood = expFood;
            ExpHousing = expHousing;
            ExpHealth = expHealth;
            ExpInsurance = expInsurance;
            ExpEducation = expEducation;
            ExpPersonal = expPersonal;
            UserPreAutoPayments = userPreAutoPayments;
        }

        public decimal ExpFood
        {
            get { return expFood; }
            set { expFood = value; }
        }

        public decimal ExpHousing
        {
            get { return expHousing; }
            set { expHousing = value; }
        }

        public decimal ExpHealth
        {
            get { return expHealth; }
            set { expHealth = value; }
        }

        public decimal ExpInsurance
        {
            get { return expInsurance; }
            set { expInsurance = value; }
        }

        public decimal ExpEducation
        {
            get { return expEducation; }
            set { expEducation= value; }
        }

        public decimal ExpPersonal
        {
            get { return expPersonal; }
            set { expPersonal = value; }
        }

        public PreAutoPayments UserPreAutoPayments
        {
            get { return userPreAutoPayments; }
            set { userPreAutoPayments = value; }
        }

        public decimal TotalUserExpenses()
        {
            return ExpFood + ExpHousing + ExpHealth + ExpInsurance + ExpEducation + ExpPersonal + UserPreAutoPayments.TotalPreAutoPay();
        }
    }
}

