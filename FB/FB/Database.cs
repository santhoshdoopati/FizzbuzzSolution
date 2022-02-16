using System;
using System.Data;
using System.Data.SqlClient;

namespace FB
{
    public class Database
    {
        
        public string verifyData()
        {
            //string dataSource = "";
            SqlConnection dataconn = new SqlConnection();
            SqlCommand cmnd = new SqlCommand("SELECT * FROM INPUT");
            cmnd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmnd);

            /* Incomplete code to be used in Mock */

            return null;

        }
    }
}
