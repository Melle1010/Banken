namespace Banken
{
    public class Account
    {
        private int AccountNumber { get; set; }
        private decimal Balance { get; set; }
        //private User Owner { get; set; }
        //private List<Transaction> Transactions { get; set; }

        public Account(int  accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Your account number is: {AccountNumber} \nYour balance is: {Balance}");
        }
    }


}
