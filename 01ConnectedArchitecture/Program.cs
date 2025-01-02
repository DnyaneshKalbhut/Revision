using _01ConnectedArchitecture.DAL;
using _01ConnectedArchitecture.Model;

namespace _01ConnectedArchitecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
            IETDbContext db = new IETDbContext();
                int noOfRowAffected = 0;
                Console.WriteLine("Enter your choice 1.Select 2.Insert 3.Update 4.Delete");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        List<Emp> emplst = db.SelectRecords();
                        foreach (var emp in emplst)
                        {
                            Console.WriteLine($"id is {emp.Id} name is {emp.Name} Address is {emp.Address}");
                        }
                        break;
                    case 2:
                        Emp empToBeInserted = new Emp();
                        Console.WriteLine("Enter id of Empl");
                        empToBeInserted.Id =Convert.ToInt32( Console.ReadLine());
                        Console.WriteLine("Enter name of Empl");
                        empToBeInserted.Name = Console.ReadLine();
                        Console.WriteLine("Enter Address of Empl");
                        empToBeInserted.Address = Console.ReadLine();

                        noOfRowAffected = db.InsertEmployee(empToBeInserted);

                        break;

                        case 3:

                        Emp empToBeUpdate = new Emp();
                        Console.WriteLine("Enter id of Empl");
                        empToBeUpdate.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name of Empl");
                        empToBeUpdate.Name = Console.ReadLine();
                        Console.WriteLine("Enter Address of Empl");
                        empToBeUpdate.Address = Console.ReadLine();
                        noOfRowAffected = db.UpdateEmployee(empToBeUpdate);
                        if (noOfRowAffected > 0)
                        {
                            Console.WriteLine("Records updated in DB successfully");
                        }
                        break;

                    case 4:

                        Emp empToBeDeleted = new Emp();
                        Console.WriteLine("enter Id of Employee");
                        empToBeDeleted.Id = Convert.ToInt32( Console.ReadLine());
                        noOfRowAffected = db.DeleteEmployee(empToBeDeleted);
                        break;

                }
            }
        }
    }
}
