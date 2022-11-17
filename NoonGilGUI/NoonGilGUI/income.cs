using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoonGilGUI
{

    internal class income
    {
        private double housing;
        private double transportation;
        private double education;
        private double food;
        private double prePay;
        private double other;

        public income(double housing, double transportation, double education, double food, double prePay, double other)
        {
            this.housing = housing;
            this.transportation = transportation;
            this.education = education;
            this.food = food;
            this.prePay = prePay;
            this.other = other;
        }
        public double Housing
        {
            get { return housing; }
            set { housing = value; }
        }
        public double Transportation
        {
            get { return transportation; }
            set { transportation = value; }
        }
        public double Education
        {
            set { education = value; }
            get { return education; }
        }
        public double Food
        {
            get { return food; }
            set { food = value; }
        }
        public double PrePay
        {
            get { return prePay; }
            set { prePay = value;}
        }
        public double Other
        {
            get { return other; }
            set { other = value; }
        }

    }
}
