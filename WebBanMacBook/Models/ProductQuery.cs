using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebBanMacBook.Models
{
    public class ProductQuery
    {
        private DBConnection db;
        public ProductQuery()
        {                                                                           
            db = new DBConnection();
        }
        public List<ListProduct> getProductTop(string Productid)
        {
            string sql;

            if (string.IsNullOrEmpty((Productid)))
            {
                sql = "Select Top 8 A.Sold,A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID Order by A.Sold Desc";

            }
            else
            {
                sql = "Select Top 8 A.Sold,A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND A.ProductID =" + Productid +"Order by A.sold Desc";

            }

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Hết Macbook
        public List<ListProduct> getProduct(string Productid)
        {
            string sql;

            if (string.IsNullOrEmpty((Productid)))
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID ";

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND A.ProductID =" + Productid;

            }

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Hết Phụ kiện
        public List<ListProduct> getProductPhuKien(string Productid)
        {
            string sql;

            if (string.IsNullOrEmpty((Productid)))
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,E.ColorName,F.YearName,I.GroupName,A.[Status] from Product A, Color E,[Year] F,[Group] I where A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.GroupID = I.GroupID AND I.GroupID IN ('CAP','MK','MM','TP','TUI')";

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,E.ColorName,F.YearName,I.GroupName,A.[Status] from Product A, Color E,[Year] F,[Group] I where A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.GroupID = I.GroupID AND I.GroupID IN ('CAP','MK','MM','TP','TUI') AND A.ProductID =" + Productid;

            }

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
               
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
               
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook pro cũ
        public List<ListProduct> getproductMPOld(string tang,string giam)
        {
            string sql;

            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND A.Status = 'Old'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND A.Status = 'Old' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND A.Status = 'Old' Order by price " + tang;

            }
           

            //string sql= "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND A.Status = 'Old'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook pro 2020 cũ
        public List<ListProduct> getproductMP2020Old(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '20' AND A.Status = 'Old'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '20' AND A.Status = 'Old' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '20' AND A.Status = 'Old' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '20' AND A.Status = 'Old'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook pro 2019 cũ
        public List<ListProduct> getproductMP2019Old(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '19' AND A.Status = 'Old'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '19' AND A.Status = 'Old' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '19' AND A.Status = 'Old' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '19' AND A.Status = 'Old'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook pro 2018 cũ
        public List<ListProduct> getproductMP2018Old(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '18' AND A.Status = 'Old'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '18' AND A.Status = 'Old' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '18' AND A.Status = 'Old' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '18' AND A.Status = 'Old'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook pro 2017 cũ
        public List<ListProduct> getproductMP2017Old(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '17' AND A.Status = 'Old'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '17' AND A.Status = 'Old' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '17' AND A.Status = 'Old' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '17' AND A.Status = 'Old'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook pro 2016 cũ
        public List<ListProduct> getproductMP2016Old(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '16' AND A.Status = 'Old'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '16' AND A.Status = 'Old' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '16' AND A.Status = 'Old' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '16' AND A.Status = 'Old'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook pro 2015 cũ
        public List<ListProduct> getproductMP2015Old(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '15' AND A.Status = 'Old'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '15' AND A.Status = 'Old' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '15' AND A.Status = 'Old' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND F.YearID = '15' AND A.Status = 'Old'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook Air cũ
        public List<ListProduct> getproductMAOld(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND A.Status = 'Old'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND A.Status = 'Old' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND A.Status = 'Old' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND A.Status = 'Old'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook Air 2020 cũ
        public List<ListProduct> getproductMA2020Old(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '20' AND A.Status = 'Old'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '20' AND A.Status = 'Old' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '20' AND A.Status = 'Old' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '20'AND A.Status = 'Old'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook Air 2019 cũ
        public List<ListProduct> getproductMA2019Old(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '19' AND A.Status = 'Old'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '19' AND A.Status = 'Old' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '19' AND A.Status = 'Old' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '19'AND A.Status = 'Old'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook Air 2018 cũ
        public List<ListProduct> getproductMA2018Old(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '18' AND A.Status = 'Old'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '18' AND A.Status = 'Old' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '18' AND A.Status = 'Old' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '18'AND A.Status = 'Old'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook Air 2017 cũ
        public List<ListProduct> getproductMA2017Old(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '17' AND A.Status = 'Old'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '17' AND A.Status = 'Old' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '17' AND A.Status = 'Old' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '17'AND A.Status = 'Old'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook Air 2016 cũ
        public List<ListProduct> getproductMA2016Old(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '16' AND A.Status = 'Old'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '16' AND A.Status = 'Old' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '16' AND A.Status = 'Old' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '16'AND A.Status = 'Old'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook Air 2015 cũ
        public List<ListProduct> getproductMA2015Old(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '15' AND A.Status = 'Old'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '15' AND A.Status = 'Old' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '15' AND A.Status = 'Old' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '15'AND A.Status = 'Old'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook Pro Mới 
        public List<ListProduct> getproductMPNew(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND A.Status = 'New'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND A.Status = 'New' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND A.Status = 'New' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' AND A.Status = 'New'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook Pro 2020 Mới 
        public List<ListProduct> getproductMP2020New(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' And F.YearId = '20' AND A.Status = 'New'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' And F.YearId = '20' AND A.Status = 'New' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' And F.YearId = '20' AND A.Status = 'New' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' And F.YearId = '20' AND A.Status = 'New'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook Pro 2019 Mới 
        public List<ListProduct> getproductMP2019New(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' And F.YearId = '19' AND A.Status = 'New'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' And F.YearId = '19' AND A.Status = 'New' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' And F.YearId = '19' AND A.Status = 'New' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MP' And F.YearId = '19' AND A.Status = 'New'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook Air Mới 
        public List<ListProduct> getproductMANew(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND A.Status = 'New'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND A.Status = 'New' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND A.Status = 'New' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND A.Status = 'New'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook Air 2020  Mới 
        public List<ListProduct> getproductMA2020New(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '20' AND A.Status = 'New'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '20' AND A.Status = 'New' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '20' AND A.Status = 'New' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '20' AND A.Status = 'New'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Macbook Air 2019  Mới 
        public List<ListProduct> getproductMA2019New(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '19' AND A.Status = 'New'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '19' AND A.Status = 'New' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '19' AND A.Status = 'New' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,B.CpuName,C.DisplayCardName,D.DisplayName,E.ColorName,F.YearName,G.HardDriveName,H.RamName,I.GroupName,A.[Status] from Product A, CPU B,DisplayCard C,Display D,Color E,[Year] F,HardDrive G,Ram H,[Group] I where A.CpuID = B.CpuID AND A.DisplayCardID=C.DisplayCardID AND A.DisplayID = D.DisplayID AND A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.HardDriveID = G.HardDriveID AND A.RamID = H.RamID AND A.GroupID = I.GroupID AND I.GroupID = 'MA' AND F.YearID = '19' AND A.Status = 'New'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                str.CpuId = dt.Rows[i]["CpuName"].ToString();
                str.DisplayCardId = dt.Rows[i]["DisplayCardName"].ToString();
                str.DisplayId = dt.Rows[i]["DisplayName"].ToString();
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();
                str.HardDriveId = dt.Rows[i]["HardDriveName"].ToString();
                str.RamId = dt.Rows[i]["RamName"].ToString();
                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Chuột và bàn phím 
        public List<ListProduct> getproductChuotPhim(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,E.ColorName,F.YearName,I.GroupName,A.[Status] from Product A, Color E,[Year] F,[Group] I where A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.GroupID = I.GroupID AND I.GroupID In ('MM','MK','TP')";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price, 'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,E.ColorName,F.YearName,I.GroupName,A.[Status] from Product A, Color E,[Year] F,[Group] I where A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.GroupID = I.GroupID AND I.GroupID In('MM','MK','TP') Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price, 'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,E.ColorName,F.YearName,I.GroupName,A.[Status] from Product A, Color E,[Year] F,[Group] I where A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.GroupID = I.GroupID AND I.GroupID In('MM','MK','TP') Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,E.ColorName,F.YearName,I.GroupName,A.[Status] from Product A, Color E,[Year] F,[Group] I where A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.GroupID = I.GroupID AND I.GroupID In ('MM','MK','TP')";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();
                
                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();

                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Cáp chuyển đổi
        public List<ListProduct> getproductCap(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,E.ColorName,F.YearName,I.GroupName,A.[Status] from Product A, Color E,[Year] F,[Group] I where A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.GroupID = I.GroupID AND I.GroupID = 'CAP'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price, 'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,E.ColorName,F.YearName,I.GroupName,A.[Status] from Product A, Color E,[Year] F,[Group] I where A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.GroupID = I.GroupID AND I.GroupID = 'CAP' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price, 'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,E.ColorName,F.YearName,I.GroupName,A.[Status] from Product A, Color E,[Year] F,[Group] I where A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.GroupID = I.GroupID AND I.GroupID = 'CAP' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,E.ColorName,F.YearName,I.GroupName,A.[Status] from Product A, Color E,[Year] F,[Group] I where A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.GroupID = I.GroupID AND I.GroupID = 'CAP'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();

                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();

                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Lấy Túi chống sốc
        public List<ListProduct> getproductTui(string tang,string giam)
        {
            string sql;
            if (string.IsNullOrEmpty((tang)))
            {
                if (string.IsNullOrEmpty(giam))
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,E.ColorName,F.YearName,I.GroupName,A.[Status] from Product A, Color E,[Year] F,[Group] I where A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.GroupID = I.GroupID AND I.GroupID = 'TUI'";
                }
                else
                {
                    sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price, 'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,E.ColorName,F.YearName,I.GroupName,A.[Status] from Product A, Color E,[Year] F,[Group] I where A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.GroupID = I.GroupID AND I.GroupID = 'TUI' Order by price " + giam;
                }

            }
            else
            {
                sql = "Select A.ProductID,A.ProductName,A.[Description],A.Stock,A.Sold,format(A.Price, 'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,E.ColorName,F.YearName,I.GroupName,A.[Status] from Product A, Color E,[Year] F,[Group] I where A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.GroupID = I.GroupID AND I.GroupID = 'TUI' Order by price " + tang;

            }
            //string sql = "Select A.ProductID,A.ProductName,A.[Description],format(A.Price,'N0') as Price,A.ImageSourceMain,A.ImageSource1,A.ImageSource2,A.ImageSource3,E.ColorName,F.YearName,I.GroupName,A.[Status] from Product A, Color E,[Year] F,[Group] I where A.ColorID = E.ColorID AND A.YearID = F.YearID AND A.GroupID = I.GroupID AND I.GroupID = 'TUI'";

            List<ListProduct> strList = new List<ListProduct>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListProduct str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListProduct();
                str.ProductId = Convert.ToInt32(dt.Rows[i]["ProductID"].ToString());
                str.Name = dt.Rows[i]["ProductName"].ToString();
                str.Description = dt.Rows[i]["Description"].ToString();
                str.Stock = Convert.ToInt32(dt.Rows[i]["Stock"].ToString());
                str.Sold = Convert.ToInt32(dt.Rows[i]["Sold"].ToString());
                str.Price = Convert.ToDecimal(dt.Rows[i]["Price"].ToString());
                str.ImageSource = dt.Rows[i]["ImageSourceMain"].ToString();
                str.ImageSource1 = dt.Rows[i]["ImageSource1"].ToString();
                str.ImageSource2 = dt.Rows[i]["ImageSource2"].ToString();
                str.ImageSource3 = dt.Rows[i]["ImageSource3"].ToString();

                str.ColorId = dt.Rows[i]["ColorName"].ToString();
                str.YearId = dt.Rows[i]["YearName"].ToString();

                str.GroupId = dt.Rows[i]["GroupName"].ToString();
                str.Status = dt.Rows[i]["Status"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        public bool CreateProduct(ListProduct model)
        {
            string sql = "Insert into Product(ProductName,[Description],Stock,Sold,Price,ImageSourceMain,ImageSource1,ImageSource2,ImageSource3,CpuID,DisplayCardID,DisplayID,ColorID,YearID,HardDriveID,RamID,GroupID,[Status]) values (N'" + model.Name +"',N'"+model.Description+"','" + model.Stock + "','" + model.Sold + "','" + model.Price + "','" + model.ImageSource + "','" + model.ImageSource1 + "','" + model.ImageSource2 + "','" + model.ImageSource3 + "','" + model.CpuId + "','" + model.DisplayCardId + "','" + model.DisplayId + "','" + model.ColorId + "','" + model.YearId + "','" + model.HardDriveId + "','" + model.RamId + "','" + model.GroupId + "','" + model.Status + "')";
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
        public bool UpdateProduct(ListProduct model)
        {
            string sql = "Update Product set ProductName = '"+model.Name+"',Stock ="+model.Stock+",Sold = "+model.Sold+ ",[Description]= '"+model.Description+"',Price = "+model.Price+ ",ImageSourceMain = '"+model.ImageSource+ "',ImageSource1 = '"+model.ImageSource1+"',ImageSource2 ='"+model.ImageSource2+ "',ImageSource3 = '"+model.ImageSource3+"',CpuID = '"+model.CpuId+"',DisplayCardID = '"+model.DisplayCardId+"',DisplayID = '"+model.DisplayId+"',ColorID = '"+model.ColorId+"',YearID = '"+model.YearId+"',HardDriveID = '"+model.HardDriveId+"',RamID = '"+model.RamId+"',GroupID = '"+model.GroupId+"',Status = '"+model.Status+"' where ProductID = "+model.ProductId+"";
            SqlConnection con = db.GetConnection();
            //tạo mới biến toàn cục, reset lại command
            SqlCommand cmd = new SqlCommand(sql, con);

            con.Open();
            //Số dòng thực thi 0 được trả về 0
            var kq = cmd.ExecuteNonQuery();
            con.Close();
            return kq>0;
        }
        public bool DeleteProduct(string productid)
        {
            string sql = "Delete From Product Where ProductID = " +productid;
            SqlConnection con = db.GetConnection();
            //tạo mới biến toàn cục, reset lại command
            SqlCommand cmd = new SqlCommand(sql, con);

            con.Open();
            //Số dòng thực thi 0 được trả về 0
            var kq = cmd.ExecuteNonQuery();
            con.Close();
            return kq > 0;
        }
        public bool CreatePhukien(ListProduct model)
        {
            string sql = "Insert into Product(ProductName,[Description],Stock,Sold,Price,ImageSourceMain,ImageSource1,ImageSource2,ImageSource3,ColorID,YearID,GroupID,[Status]) values (N'" + model.Name + "',N'" + model.Description + "','" + model.Stock + "','" + model.Sold + "','" + model.Price + "','" + model.ImageSource + "','" + model.ImageSource1 + "','" + model.ImageSource2 + "','" + model.ImageSource3 + "','" + model.ColorId + "','" + model.YearId + "','" + model.GroupId + "','" + model.Status + "')";
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
        public bool UpdatePhukien(ListProduct model)
        {
            string sql = "Update Product set ProductName = '" + model.Name + "',Stock =" + model.Stock + ",Sold = " + model.Sold + ",[Description]= '" + model.Description + "',Price = " + model.Price + ",ImageSourceMain = '" + model.ImageSource + "',ImageSource1 = '" + model.ImageSource1 + "',ImageSource2 ='" + model.ImageSource2 + "',ImageSource3 = '" + model.ImageSource3 + "',ColorID = '" + model.ColorId + "',YearID = '" + model.YearId + "',GroupID = '" + model.GroupId + "',Status = '" + model.Status + "' where ProductID = " + model.ProductId + "";
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