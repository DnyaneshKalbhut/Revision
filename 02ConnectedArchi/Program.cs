using _02ConnectedArchi.DAL;
using _02ConnectedArchi.Model;

namespace _02ConnectedArchi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DacDBContext dBContext = new DacDBContext();
                int noOfrowAffected = 0;

                Console.WriteLine("Enter choice 1.select 2.insert 3.update 4.delete ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        List<Emp> emp = dBContext.SelectRecords();
                        foreach (var e in emp)
                        {
                            Console.WriteLine($"id is {e.EId} name is {e.EName} address {e.EAddress}");
                        }
                        break;

                        case 2:

                        Emp empToBeInserted = new Emp();
                        Console.WriteLine("Enter id");
                        empToBeInserted.EId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name");
                        empToBeInserted.EName = Console.ReadLine().ToString();
                        Console.WriteLine("Enter Address");
                        empToBeInserted.EAddress = Console.ReadLine().ToString();

                        noOfrowAffected = dBContext.InsertEmp(empToBeInserted);
                        break;
                }
            }
        }
    }
}
