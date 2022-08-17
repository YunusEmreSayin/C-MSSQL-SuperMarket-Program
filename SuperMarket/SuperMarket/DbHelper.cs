using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SuperMarket
{
    internal class DbHelper
    {
        static string Constring = "Server=.;Database=SuperMarket;Trusted_Connection=True;";
        internal static SqlConnection getConnection()
        {
            SqlConnection Con = new SqlConnection(Constring);
            Con.Open();
            return Con;
        }

    }
}
