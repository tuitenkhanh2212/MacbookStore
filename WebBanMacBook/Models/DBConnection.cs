using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebBanMacBook.Models
{
    public class DBConnection
    {
        string strCon;
        public DBConnection()
        {
            strCon = ConfigurationManager.ConnectionStrings["MacBookStoreConnectionString"].ConnectionString;
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(strCon);
        }
    }
}