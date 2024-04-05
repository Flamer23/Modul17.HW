namespace Modul17.HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account regularAccount = new Account { Type = "Обычный", Balance = 70000 };
            Account salaryAccount = new Account { Type = "Зарплатный", Balance = 10000 };

            Calculator.CalculateInterest(regularAccount);
            Calculator.CalculateInterest(salaryAccount);

            Console.WriteLine($"Доля обычного аккаунта: {regularAccount.Interest}");
            Console.WriteLine($"Доля зарплатного аккаунта: {salaryAccount.Interest}");

        }
    }
}
