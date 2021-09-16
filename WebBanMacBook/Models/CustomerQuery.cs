using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebBanMacBook.Models
{
    public class CustomerQuery
    {
        private DBConnection db;

        public CustomerQuery()
        {
            db = new DBConnection();
        }

        public ListAccount getCustomerID(string account)
        {
            string sql = "select * from Customer where Account = '" + account + "'";

            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();


            ListAccount la = new ListAccount();
            la.CustomerID = Convert.ToInt32(dt.Rows[0]["CustomerID"].ToString());
            la.FirstName = dt.Rows[0]["FirstName"].ToString();
            la.LastName = dt.Rows[0]["LastName"].ToString();
            la.Account = dt.Rows[0]["Account"].ToString();
            la.Password = dt.Rows[0]["Password"].ToString();
            la.Email = dt.Rows[0]["Email"].ToString();
            la.Birth = Convert.ToDateTime(dt.Rows[0]["Birth"].ToString());
            la.Address = dt.Rows[0]["Address"].ToString();
            la.PhoneNumber = dt.Rows[0]["PhoneNumber"].ToString();
           

            return la;
        }
        public List<ListAccount> getCustomerList(string id)
        {
            string sql;

            if (string.IsNullOrEmpty((id)))
            {
                sql = "select * from Customer";

            }
            else
            {
                sql = "select * from Customer where CustomerID = '" + id + "'";

            }

            List<ListAccount> strList = new List<ListAccount>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListAccount la;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                la = new ListAccount();
                la.CustomerID = Convert.ToInt32(dt.Rows[i]["CustomerID"].ToString());
                la.FirstName = dt.Rows[i]["FirstName"].ToString();
                la.LastName = dt.Rows[i]["LastName"].ToString();
                la.Account = dt.Rows[i]["Account"].ToString();
                la.Password = dt.Rows[i]["Password"].ToString();
                la.Email = dt.Rows[i]["Email"].ToString();
                la.Birth = Convert.ToDateTime(dt.Rows[i]["Birth"].ToString());
                la.Address = dt.Rows[i]["Address"].ToString();
                la.PhoneNumber = dt.Rows[i]["PhoneNumber"].ToString();
                strList.Add(la);
            }
            return strList;
        }
        public bool CreateAccount(ListAccount model)
        {
            string sql = "If not Exists (Select * from Customer where Account = '" + model.Account + "' ) begin insert into Customer(FirstName,LastName,Account,Password,Email,Birth,Address,PhoneNumber) values (N'" + model.FirstName + "',N'" + model.LastName + "','" + model.Account + "','" + model.Password + "','" + model.Email + "','" + model.Birth.ToString("") + "','" + model.Address + "','" + model.PhoneNumber + "') end";
            SqlConnection con = db.GetConnection();
            //tạo mới biến toàn cục, reset lại command
            SqlCommand cmd = new SqlCommand(sql, con);

            con.Open();
            //Số dòng thực thi 0 được trả về 0
            var kq = cmd.ExecuteNonQuery();
            con.Close();
            if (kq <= 0)
            {
                return false;
            }

            return true;
        }
        public bool UpdateAccount(ListAccount model)
        {
            string sql = "Update Customer set FirstName = N'"+model.FirstName+"',LastName = N'"+model.LastName+"',Password = '"+model.Password+"',Email = '"+model.Email+"',Birth = '"+model.Birth.ToString("")+"',Address = N'"+model.Address+"',PhoneNumber = '"+model.PhoneNumber+"' Where Account = '"+model.Account+"'";
            SqlConnection con = db.GetConnection();
            //tạo mới biến toàn cục, reset lại command
            SqlCommand cmd = new SqlCommand(sql, con);

            con.Open();
            //Số dòng thực thi 0 được trả về 0
            var kq = cmd.ExecuteNonQuery();
            con.Close(); 
            return kq>0;
        }
        public bool CheckAccount(string account, string password)
        {
            string sql = "select * from Customer where Account = '" + account + "' AND Password = '" + password + "'";
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            con.Open();
            cmd.Fill(dt);
            con.Close();

            if (dt.Rows.Count <= 0)
            {
                return false;
            }

            return true;
        }
        public ListAccount getAdminID(string account)
        {
            string sql = "select * from Admin where Account = '" + account + "'";

            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();


            ListAccount la = new ListAccount();
            la.CustomerID = Convert.ToInt32(dt.Rows[0]["AdminID"].ToString());
            la.FirstName = dt.Rows[0]["AdminName"].ToString();
            la.Account = dt.Rows[0]["Account"].ToString();
            la.Password = dt.Rows[0]["Password"].ToString();


            return la;
        }
        public bool CheckAccountAdmin(string account, string password)
        {
            string sql = "select * from Admin where Account = '" + account + "' AND Password = '" + password + "'";
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            con.Open();
            cmd.Fill(dt);
            con.Close();

            if (dt.Rows.Count <= 0)
            {
                return false;
            }

            return true;
        }
        public bool DeleteAccount(string id)
        {
            string sql = "Delete from Customer Where CustomerID = " + id;
            SqlConnection con = db.GetConnection();
            //tạo mới biến toàn cục, reset lại command
            SqlCommand cmd = new SqlCommand(sql, con);

            con.Open();
            //Số dòng thực thi 0 được trả về 0
            var kq = cmd.ExecuteNonQuery();
            con.Close();
            return kq > 0;
        }
    }
}