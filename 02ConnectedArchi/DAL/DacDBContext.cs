using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02ConnectedArchi.Model;
using Azure.Core;
using Microsoft.Data.SqlClient;

namespace _02ConnectedArchi.DAL
{
    public class DacDBContext
    {
        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Dac24;Integrated Security=True";
        List<Emp> emps = new List<Emp>();


        public List<Emp> SelectRecords()
        {
            SqlConnection conn = new SqlConnection(constr);
            string SelectQuery = "Select * from Emp";
            SqlCommand cmd = new SqlCommand(SelectQuery, conn);
            conn.Open();

            SqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read()) {
                emps.Add(new Emp()
                {
                    EId=Convert.ToInt32(dataReader["ID"]),
                    EName=dataReader["Name"].ToString(),
                    EAddress=dataReader["Address"].ToString(),
                });
            }
            conn.Close();


            return emps;
        }

        internal int InsertEmp(Emp emp)
        {
            SqlConnection con = new SqlConnection();
            string SqlQuery = $"Insert into Emp values ({emp.Id},'{emp.Name}',' {emp.Address} ')";
            SqlCommand cmd = new SqlCommand(SqlQuery,con);
            con.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            
            return rowAffected;

        }
    }
}
