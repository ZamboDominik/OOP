namespace Encapsulation
{
    internal class Program
    {

        class BankAccount 
        {
            private int money { get; set; }

            public int Money 
            {
                get { return money; }
                set {
                    if (value > 0)
                    {
                        Deposit(value);
                    }
                    else
                    {
                        Withdraw(-value);
                    }
                }
            }
            public BankAccount()
            {
                money = 0;
            }
            public void Deposit(int amount)
            {
                if (amount > 0)
                {
                    money += amount;
                    Console.WriteLine($"Deposited: {amount}. New balance: {money}");
                }
                else
                {
                    Console.WriteLine("Deposit amount must be positive.");
                }
            }
            public void Withdraw(int amount)
            {
                if (amount > 0 && amount <= money)
                {
                    money -= amount;
                    Console.WriteLine($"Withdrew: {amount}. New balance: {money}");
                }
                else
                {
                    Console.WriteLine("Invalid withdrawal amount.");
                }
            }


        }

        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            //Console.WriteLine($"Penz:{account.Money}");
            account.Money = 500;
            //Console.WriteLine($"Penz:{account.Money}");
            account.Money = -200;
            //Console.WriteLine($"Penz:{account.Money}");
        }
    }
}
