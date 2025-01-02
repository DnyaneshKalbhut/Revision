namespace _08PropertiesInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            acc.account = new SavingAccount();
            acc.AccountDetails();
            acc.account = new CurrentAccount();

        }
    }

    public class Account
    {

        public IAccont account { get; set; }

        public void AccountDetails()
        {
            account.printDetails();
        }


    }

    public interface IAccont
    {
        public void printDetails();
    }

    public class SavingAccount : IAccont
    {
        public void printDetails()
        {
            Console.WriteLine("details of saving account");
        }

    }
    public class CurrentAccount : IAccont
    {
        public void printDetails()
        {
            Console.WriteLine("details of current account");
        }

    }
}
