using System.Data;
using Microsoft.Data.SqlClient;

namespace _02DisconnectedArchitecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Dac24;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conStr);

            string selectQuery = $"Select * from Emp";
            SqlDataAdapter da = new SqlDataAdapter(selectQuery, conn);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"Id: {row["Id"]}, Name: {row["Name"]}, Address: {row["Address"]}");
            }

            //Console.WriteLine("Enter Id");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Name of New Employee");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter Adress of New Employee");
            //string address = Console.ReadLine();

            //DataRow dr = dt.NewRow();
            //dr["Id"] = id;
            //dr["Name"]=name;
            //dr["Address"]=address;

            //dt.Rows.Add(dr);
            //da.Update(dt);


            //Console.WriteLine("Enter Id ");
            //int id = Convert.ToInt32(Console.ReadLine());

            //DataRow empToBeEdited = dt.Rows.Find(id);

            //Console.WriteLine("Enter Name of Emp ");
            //empToBeEdited["Name"]=Console.ReadLine();

            //Console.WriteLine("Enter Address");
            //empToBeEdited["Address"] = Console.ReadLine();

            //da.Update(dt);



            Console.WriteLine("enter id");
            int id = Convert.ToInt32(Console.ReadLine());

            DataRow? empToBeDeleted = dt.Rows.Find(id);

            empToBeDeleted.Delete();

            da.Update(dt);

        }
    }
}
