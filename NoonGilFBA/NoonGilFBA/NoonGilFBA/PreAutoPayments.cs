using System;
namespace NoonGilFBA
{
    public class PreAutoPayments
    {
        private decimal billPhone;
        private decimal billInternet;
        private decimal billGym;
        private decimal billEntertainment;      // music subscriptions, netflix or other monthly subscriptions

        public PreAutoPayments(decimal billPhone, decimal billInternet, decimal billGym, decimal billEntertainment)
        {
            BillPhone = billPhone;
            BillInternet = billInternet;
            BillGym = billGym;
            BillEntertainment = billEntertainment;
        }

        public decimal BillPhone
        {
            get { return billPhone; }
            set { billPhone = value; }
        }

        public decimal BillInternet
        {
            get { return billInternet; }
            set { billInternet = value; }
        }

        public decimal BillGym
        {
            get { return billGym; }
            set { billGym = value; }
        }

        public decimal BillEntertainment
        {
            get { return billEntertainment; }
            set { billEntertainment = value; }
        }

        public decimal TotalPreAutoPay()
        {
            return BillPhone + BillInternet + BillGym + BillEntertainment;
        }


    }
}

