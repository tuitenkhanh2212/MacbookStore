using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebBanMacBook.Models
{
    public class OrderQuery
    {
        private DBConnection db;

        public OrderQuery()
        {
            db = new DBConnection();
        }
        public List<ListOrder> getOrderList(string id)
        {
            string sql;

            if (string.IsNullOrEmpty((id)))
            {
                sql = "select * from [Order]";

            }
            else
            {
                sql = "select * from [Order] where OrderID = '" + id + "'";

            }

            List<ListOrder> strList = new List<ListOrder>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListOrder lo;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lo = new ListOrder();
                lo.OrderID = Convert.ToInt32(dt.Rows[i]["OrderID"].ToString());
                lo.Paid = Convert.ToBoolean(dt.Rows[i]["Paid"].ToString());
                lo.DeliveryStatus = Convert.ToBoolean(dt.Rows[i]["DeliveryStatus"].ToString());
                lo.OrderDate = Convert.ToDateTime(dt.Rows[i]["OrderDate"].ToString());
                lo.DelieveryDate = Convert.ToDateTime(dt.Rows[i]["DelieveryDate"].ToString());
                lo.CustomerID = Convert.ToInt32(dt.Rows[i]["CustomerID"].ToString());
                strList.Add(lo);
            }
            return strList;
        }
        public bool UpdateOrder(ListOrder model)
        {
            string sql = "Update [Order] set Paid = '" + model.Paid + "',DeliveryStatus = '" + model.DeliveryStatus + "',OrderDate = '" + model.OrderDate + "',DelieveryDate = '" + model.DelieveryDate.ToString("") + "',CustomerID = '" + model.CustomerID + "' where OrderID = '" + model.OrderID + "'";
            SqlConnection con = db.GetConnection();
            //tạo mới biến toàn cục, reset lại command
            SqlCommand cmd = new SqlCommand(sql, con);

            con.Open();
            //Số dòng thực thi 0 được trả về 0
            var kq = cmd.ExecuteNonQuery();
            con.Close();
            //Lớn hơn 0 = false
            return kq > 0;
        }
        
        public bool DeleteOrder(string id)
        {
            string sql = "Delete From [Order] Where OrderID = " + id;
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
        public List<ListOrder> getOrderDetailsList(string id)
        {
            string sql;

            if (string.IsNullOrEmpty((id)))
            {
                sql = "select * from OrderDetails";

            }
            else
            {
                sql = "select * from OrderDetails where ID = '" + id + "'";

            }

            List<ListOrder> strList = new List<ListOrder>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListOrder lo;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lo = new ListOrder();
                lo.OrderID = Convert.ToInt32(dt.Rows[i]["OrderID"].ToString());
                lo.ProductID = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                lo.Amount = Convert.ToInt32(dt.Rows[i]["Amount"].ToString());
                lo.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                lo.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                strList.Add(lo);
            }
            return strList;
        }
        public bool UpdateOrderDetails(ListOrder model)
        {
            string sql = "Update OrderDetails set Amount = '"+model.Amount+"' Where ID =" + model.ID;
            SqlConnection con = db.GetConnection();
            //tạo mới biến toàn cục, reset lại command
            SqlCommand cmd = new SqlCommand(sql, con);

            con.Open();
            //Số dòng thực thi 0 được trả về 0
            var kq = cmd.ExecuteNonQuery();
            con.Close();
            //Lớn hơn 0 = false
            return kq > 0;
        }
        public bool DeleteOrderDetails(string id)
        {
            string sql = "Delete From OrderDetails Where ID = " + id;
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
    }
}