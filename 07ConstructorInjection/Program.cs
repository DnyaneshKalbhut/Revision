namespace _07ConstructorInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAccont acc = new SavingAccount();
            Account A= new Account(acc);
            A.AccountDetails();

            IAccont ca = new CurrentAccount();
            Account a1 = new Account(ca);
            a1.AccountDetails();
        }
    }

    public class Account
    {
        private IAccont account;

        public Account(IAccont accont)
        {
            this.account = accont;
        }

        public  void AccountDetails()
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
