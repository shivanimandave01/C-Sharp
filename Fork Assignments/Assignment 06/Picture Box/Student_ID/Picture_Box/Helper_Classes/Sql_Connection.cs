using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Picture_Box.Helper_Classes
{
    class Sql_Connection
    {
        public static SqlConnection SCon = new SqlConnection(@"Data Source=Shivani;Initial Catalog=Picture_Box_DB;Integrated Security=True");

        public static void SconStart()
        {
            if (ConnectionState.Open != SCon.State)
            {
                SCon.Open();
            }
        }
        public static void SconStop()
        {
            if (ConnectionState.Closed != SCon.State)
            {
                SCon.Close();
            }
        }
    }
}
