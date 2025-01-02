namespace _09MethodInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.AccountDetails(new SavingAccount());
            account.AccountDetails(new CurrentAccount());

        }
    }

    public class Account
    {
      
      

        public void AccountDetails(IAccont acc)
        {
            acc.printDetails();
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
