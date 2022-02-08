using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace _2022022_training_2
{
    internal class ConnectionProvider
    {
        public static string ConnectionString { get; set; } = "server=.;database=Northwind;UID=sa;PWD=admin;MultipleActiveResultSets=True";
       // public static SqlConnection SqlConnection { get; set; }= new SqlConnection("server =.; database=Northwind;UID=sa;PWD=admin");

        public static SqlConnection SqlConnection { get; set;}=new SqlConnection(ConnectionString);

        //public static SqlConnection SqlConnectionConfiguration { get; set; } = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        //public static SqlConnection SqlConnection { get; set; }="server=.;database=northwind;Trusted Connection=true";
        //public static SqlConnection SqlConnection { get; set; } = "server=.;database=northwind;Integrated Security=true";


    }
}
