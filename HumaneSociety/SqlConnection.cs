using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HumaneSociety
{
    public sealed class SqlConnection /*: DbConnection, ICloneable*/
    {
        //member variables
        string connectionString;


        //constructor
        public SqlConnection(/*string connectionString*/)
        {
            //this.connectionString = connectionString;
        }

        //member variables
        //public override string ConnectionString { get; set; }



        //private static void CreateCommand(string queryString, string connectionString)
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand command = new SqlCommand(queryString, connection);
        //        command.Connection.Open();
        //        command.ExecuteNonQuery();
        //    }
        //}


        //private static void OpenSqlConnection()
        //{
        //    string connectionString = GetConnectionString();
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.ConnectionString = connectionString;
        //        connection.Open();
        //        Console.WriteLine("State: {0}", connection.State);
        //        Console.WriteLine("ConnectionString: {0}", connection.ConnectionString);
        //    }
        //}

        //private static string GetConnectionString()
        //{
        //    return "Data Source=";
        //}

        //public object Clone()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
