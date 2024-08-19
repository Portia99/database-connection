using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB1Project
{
    class DataBaseConnection
    {
        static SqlConnection connectionString = new SqlConnection(@"Data Source=  ;Initial Catalog=pubs;Integrated Security=True");
        public static DataTable dataAdapterSelect(string sqlQuery)
        {
            SqlDataAdapter DataAdapter = new SqlDataAdapter(sqlQuery, connectionString);
            DataTable dt = new DataTable();
            DataAdapter.Fill(dt);
            return dt;
        }

        public static string sqlCommandQuery(string sqlQuery)
        {
            SqlCommand myCommand = new SqlCommand(sqlQuery, connectionString);
            myCommand.Connection.Open();

            int numberOfRowsAffected = myCommand.ExecuteNonQuery();
            
            myCommand.Connection.Close();

            return numberOfRowsAffected + "rows affected";
        }

        public static void sqlCommandQueryReader(string sqlQuery)
        {
            SqlCommand myCommand = new SqlCommand(sqlQuery, connectionString);
            myCommand.Connection.Open();
            SqlDataReader dr;
            dr = myCommand.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0]);
                Console.WriteLine(dr[1]);
            }
            myCommand.Connection.Close();
        }

    }
}
