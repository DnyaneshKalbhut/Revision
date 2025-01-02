using _03EntityFramework.DAL;
using _03EntityFramework.Model;

namespace _03EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeDbContext dBContext = new EmployeeDbContext();
            while (true)
            {
                Console.WriteLine("Enter operation choice 1. Select, 2. Insert, 3.Update, 4.Delete");
                int opChoice = Convert.ToInt32(Console.ReadLine());

                switch (opChoice)
                {
                    case 1:
                        var allEmployees = dBContext.employees.ToList();
                        foreach (var emp in allEmployees)
                        {
                            Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Address: {emp.Address}");
                        }
                        break;

                    case 2:
                        Employee empRecordToBeInserted = new Employee();
                        Console.WriteLine("Enter Name:");
                        empRecordToBeInserted.Name = Console.ReadLine();
                        Console.WriteLine("Enter Address:");
                        empRecordToBeInserted.Address = Console.ReadLine();

                        dBContext.employees.Add(empRecordToBeInserted);
                        break;

                    case 3:
                        Console.WriteLine("Enter Id");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Employee empRecordToBeUpdated = dBContext.employees.Find(id);
                        Console.WriteLine("Enter Name:");
                        empRecordToBeUpdated.Name = Console.ReadLine();
                        Console.WriteLine("Enter Address:");
                        empRecordToBeUpdated.Address = Console.ReadLine();

                        dBContext.SaveChanges();
                        break;

                    case 4:

                        Console.WriteLine("Enter Id");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        Employee empToBeDeleted = dBContext.employees.Find(id1);

                        dBContext.employees.Remove(empToBeDeleted);
                        dBContext.SaveChanges();
                        break;
                }
            }
        }
    }
}
