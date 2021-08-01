using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Hastane_Proje
{
    class sqlconnection
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-2VFLNLS\\SQLEXPRESS;Initial Catalog=Hastane_Proje;Integrated Security=True ");
            connect.Open();
            return connect;
        }
    }
}
