using _01ConnectedArchitecture.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace _01ConnectedArchitecture.DAL
{
    public class IETDbContext
    {
        string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Dac24;Integrated Security=True";
        List<Emp> emps = new List<Emp>();

        public List<Emp> SelectRecords()
        {
            SqlConnection conn = new SqlConnection(constr);
            string SelectQuery = "select * from Emp";
            SqlCommand cmd = new SqlCommand(SelectQuery, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                emps.Add(new Emp()
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    Name = reader["Name"].ToString(),
                    Address = reader["Address"].ToString()

                });
            }
            conn.Close();

            return emps;
        }

        internal int DeleteEmployee(Emp empToBeDeleted)
        {
            SqlConnection conn = new SqlConnection(constr);
            string Sqlquery = $"Delete from Emp where Id = {empToBeDeleted.Id}";
            SqlCommand cmd = new SqlCommand(Sqlquery, conn);
            conn.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowAffected;
        }

        internal int InsertEmployee(Emp emp)
        {
            SqlConnection conn = new SqlConnection(constr);
            string SqlQuery = $"Insert into Emp values ({emp.Id},'{emp.Name}',' {emp.Address} ')";

            SqlCommand cmd = new SqlCommand(SqlQuery, conn);
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            return rowsAffected;
        }

        internal int UpdateEmployee(Emp emp)
        {
           SqlConnection con = new SqlConnection(constr);
            string SqlQuery = $"Update Emp set Name= '{emp.Name}',Address=' {emp.Address}' where Id = {emp.Id}";
            SqlCommand cmd = new SqlCommand(SqlQuery,con);

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();    
            return rowsAffected;
        }
    }
}