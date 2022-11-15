using System;
using System.Text.RegularExpressions;

namespace NoonGilFBA
{
    public class Account
    {
        private string fName;
        private string lName;
        private string email;
        private string password;
        UserIncome income;
        UserExpenses expenses;


        public Account(string fName, string lName, string email, string password)
        {
            FullName = fName;
            LastName = lName;
            Email = email;
            Password = password;
        }

        public Account(Account acc, UserIncome income, UserExpenses expenses)
        {
            FullName = acc.fName;
            LastName = acc.lName;
            Email = acc.email;
            Password = acc.password;
            Income = income;
            Expenses = expenses;

        }

        public Account(string fName, string lName, string email, string password, UserIncome income, UserExpenses expenses)
        {
            FullName = fName;
            LastName = lName;
            Email = email;
            Password = password;
            Income = income;
            Expenses = expenses;

        }

        public string FullName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string LastName
        {
            get { return lName; }
            set { lName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public UserIncome Income
        {
            get { return income; }
            set { income = value; }
        }

        public UserExpenses Expenses
        {
            get { return expenses; }
            set { expenses = value; }
        }

        public bool IsEmailValid()
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(ca|com)$";

            return Regex.IsMatch(Email, regex, RegexOptions.IgnoreCase);
        }

        // min 10 max 30, atleast 1 uppercase and 1 lowercase, no whitespace REDO THIS USE REGEX
        public bool IsPasswordValid()
        {
            if (Password.Length < 10 || Password.Length > 30)
            {
                return false;
            }
            else
                if (!Password.Any(char.IsUpper) && !Password.Any(char.IsLower))
            {
                return false;
            }
            else
                if (Password.Contains(" "))
            {
                return false;
            }
            return true;
        }





    }
}

