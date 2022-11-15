// See https://aka.ms/new-console-template for more information
using NoonGilFBA;

// account class email and password isValid method
Account a1 = new Account("xed", "abary", "xedabary@gmail.com", "Password12");
Console.WriteLine("email valid method: " + a1.IsEmailValid());
Console.WriteLine("password valid method: " + a1.IsPasswordValid());

// userIncome salary class
UserIncome user1 = new UserIncome("nurse", 30.00m, 8, 5);
Console.WriteLine("salary: " + user1.TotalSalary());

// userPreAuthorizedPay class (phone, internet bills, etc)
PreAutoPayments userAutoPay = new PreAutoPayments(40.50m, 70.20m, 15.70m, 35.15m);
Console.WriteLine("entertainment bill : " + userAutoPay.BillEntertainment);
Console.WriteLine("total of preAutoPay: " + userAutoPay.TotalPreAutoPay());

// userExpenses class (housing, health, insurance + preAuthorizedPay class)
UserExpenses userExpenses = new UserExpenses(90.20m, 400.10m, 120.40m, 80.25m, 200.00m, 54.34m, userAutoPay);
Console.WriteLine("preAutoPay + userExpenses tota: " + userExpenses.TotalUserExpenses());



// Working
Account realA1 = new Account(a1, user1, userExpenses);
Console.WriteLine();
Console.WriteLine("testinggggg inheritance");
Console.WriteLine(realA1.Income.TotalSalary());
Console.WriteLine(realA1.Expenses.TotalUserExpenses());