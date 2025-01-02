namespace _06TightCoupling
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Account a = new Account();
            a.printAccount();
        }
    }


    public class Account
    {
        SaveAccount sc = new SaveAccount();
        CurrentAccount ca = new CurrentAccount();

        public void printAccount()
        {
            sc.printDetails();
            ca.printDetails();
        }

    }
    public class SaveAccount
    {
        public void printDetails()
        {
            Console.WriteLine("details of saving account");
        }
    }
    public class CurrentAccount
    {
        public void printDetails()
        {
            Console.WriteLine("details of current account");
        }
    }
}
