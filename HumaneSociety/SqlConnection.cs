using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HumaneSociety
{
    public sealed class SqlConnection
    {
        private string v;
        


        //member variables

        //constructor
        public SqlConnection(string v)
        {
            this.v = v;
            SqlConnection myConnection = new SqlConnection("user id = username;" + "password = password;server=serverurl;" + "Trusted_connection=yes;" + "database=database; " + "connection timeout = 30");
            server = tcp:localhost, 9999;

            try
            {
                myConnection.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }


        //member methods
        private static void

    }
}
