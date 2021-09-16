using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebBanMacBook.Models
{
    public class ThuocTinhQuery
    {
        private DBConnection db;
        public ThuocTinhQuery()
        {
            db = new DBConnection();
        }
        //Lấy CPU
        public List<ListThuocTinh> getCPU(string id)
        {
            string sql;

            if (string.IsNullOrEmpty((id)))
            {
                sql = "Select * from Cpu";

            }
            else
            {
                sql = "Select * from Cpu where CpuID = '" + id + "'";

            }

            List<ListThuocTinh> strList = new List<ListThuocTinh>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListThuocTinh str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListThuocTinh();
                str.CpuID = dt.Rows[i]["CpuID"].ToString();
                str.CpuName = dt.Rows[i]["CpuName"].ToString();
                strList.Add(str);
            }
            return strList;
        }

        public List<CpuList> getListCPU()
        {
            string sql;

                sql = "Select * from Cpu";

                List<CpuList> strList = new List<CpuList>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            CpuList str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new CpuList();
                str.CpuId = dt.Rows[i]["CpuID"].ToString();
                str.CpuName = dt.Rows[i]["CpuName"].ToString();
                strList.Add(str);
            }
            return strList;
        }

        //Tạo CPU
        public bool CreateCPU(ListThuocTinh model)
        {
            string sql = "If not Exists (Select * from CPU where CpuID = '" + model.CpuID + "' ) begin insert into Cpu(CpuID,CPUName) values ('" + model.CpuID + "',N'" + model.CpuName + "') end";
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
        //Update CPU
        public bool UpdateCPU(ListThuocTinh model)
        {
            string sql = "Update CPU set CPUName = N'" + model.CpuName + "' where CpuID = '" + model.CpuID +"'";
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
        // Xóa CPU
        public bool DeleteCPU(string cpuid)
        {
            string sql = "delete from CPU where CPUid = '" + cpuid +"'";
            SqlConnection con = db.GetConnection();
            //tạo mới biến toàn cục, reset lại command
            SqlCommand cmd = new SqlCommand(sql, con);

            //Số dòng thực thi 0 được trả về 0
            con.Open();
            var kq = cmd.ExecuteNonQuery();
            con.Close();
            //Lớn hơn 0 = false
            return kq > 0;
        }
        //Lấy Color
        public List<ListThuocTinh> getColor(string id)
        {
            string sql;

            if (string.IsNullOrEmpty((id)))
            {
                sql = "Select * from Color";

            }
            else
            {
                sql = "Select * from Color where ColorID = '" + id + "'";

            }

            List<ListThuocTinh> strList = new List<ListThuocTinh>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListThuocTinh str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListThuocTinh();
                str.ColorID = dt.Rows[i]["ColorID"].ToString();
                str.ColorName = dt.Rows[i]["ColorName"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        public List<ColorList> getListColor()
        {
            string sql = "Select * from Color";

            List<ColorList> strList = new List<ColorList>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ColorList str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ColorList();
                str.ColorId = dt.Rows[i]["ColorID"].ToString();
                str.ColorName = dt.Rows[i]["ColorName"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Tạo Color
        public bool CreateColor(ListThuocTinh model)
        {
            string sql = "If not Exists (Select * from Color where ColorID = '" + model.ColorID + "' ) begin insert into Color(ColorID,ColorName) values ('" + model.ColorID + "',N'" + model.ColorName + "') end";
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
        //Update Color
        public bool UpdateColor(ListThuocTinh model)
        {
            string sql = "Update Color set ColorName = N'" + model.ColorName + "' where ColorID = '" + model.ColorID + "'";
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
        // Xóa Color
        public bool DeleteColor(string colorid)
        {
            string sql = "delete from Color where ColorId = '" + colorid + "'";
            SqlConnection con = db.GetConnection();
            //tạo mới biến toàn cục, reset lại command
            SqlCommand cmd = new SqlCommand(sql, con);

            //Số dòng thực thi 0 được trả về 0
            con.Open();
            var kq = cmd.ExecuteNonQuery();
            con.Close();
            //Lớn hơn 0 = false
            return kq > 0;
        }
        //Lấy Kích cỡ màn hình
        public List<ListThuocTinh> getDisplay(string displayid)
        {
            string sql;

            if (string.IsNullOrEmpty((displayid)))
            {
                sql = "Select * from Display";

            }
            else
            {
                sql = "Select * from Display where DisplayID = '" + displayid + "'";

            }

            List<ListThuocTinh> strList = new List<ListThuocTinh>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListThuocTinh str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListThuocTinh();
                str.DisplayID = dt.Rows[i]["DisplayID"].ToString();
                str.DisplayName = dt.Rows[i]["DisplayName"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        public List<DisplayList> getListDisplay()
        {
            string sql = "Select * from Display";

            List<DisplayList> strList = new List<DisplayList>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            DisplayList str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new DisplayList();
                str.DisplayId = dt.Rows[i]["DisplayID"].ToString();
                str.DisplayName = dt.Rows[i]["DisplayName"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Tạo Display
        public bool CreateDisplay(ListThuocTinh model)
        {
            string sql = "If not Exists (Select * from Display where DisplayID = '" + model.DisplayID + "' ) begin insert into Display(DisplayID,DisplayName) values ('" + model.DisplayID + "',N'" + model.DisplayName + "') end";
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
        //Update Màn hình
        public bool UpdateDisplay(ListThuocTinh model)
        {
            string sql = "Update Display set DisplayName = N'" + model.DisplayName + "' where DisplayID = '" + model.DisplayID + "'";
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
        // Xóa Display 
        public bool DeleteDisplay(string displayid)
        {
            string sql = "delete from Display where DisplayId = '" + displayid + "'";
            SqlConnection con = db.GetConnection();
            //tạo mới biến toàn cục, reset lại command
            SqlCommand cmd = new SqlCommand(sql, con);

            //Số dòng thực thi 0 được trả về 0
            con.Open();
            var kq = cmd.ExecuteNonQuery();
            con.Close();
            //Lớn hơn 0 = false
            return kq > 0;
        }
        //Lấy Card Màn hình
        public List<ListThuocTinh> getDisplayCard(string displaycardid)
        {
            string sql;

            if (string.IsNullOrEmpty((displaycardid)))
            {
                sql = "Select * from DisplayCard";

            }
            else
            {
                sql = "Select * from DisplayCard where DisplayCardID = '" + displaycardid + "'";

            }

            List<ListThuocTinh> strList = new List<ListThuocTinh>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListThuocTinh str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListThuocTinh();
                str.DisplayCardID = dt.Rows[i]["DisplayCardID"].ToString();
                str.DisplayCardName = dt.Rows[i]["DisplayCardName"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        public List<DisplayCardList> getListDisplayCard()
        {
            string sql = "Select * from DisplayCard";

            List<DisplayCardList> strList = new List<DisplayCardList>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            DisplayCardList str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new DisplayCardList();
                str.DisplayCardId = dt.Rows[i]["DisplayCardID"].ToString();
                str.DisplayCardName = dt.Rows[i]["DisplayCardName"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        //Tạo DisplayCard
        public bool CreateDisplayCard(ListThuocTinh model)
        {
            string sql = "If not Exists (Select * from DisplayCard where DisplayCardID = '" + model.DisplayCardID + "' ) begin insert into DisplayCard(DisplayCardID,DisplayCardName) values ('" + model.DisplayCardID + "',N'" + model.DisplayCardName + "') end";
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
        //Update Màn hình
        public bool UpdateDisplayCard(ListThuocTinh model)
        {
            string sql = "Update DisplayCard set DisplayCardName = N'" + model.DisplayCardName + "' where DisplayCardID = '" + model.DisplayCardID + "'";
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
        // Xóa Color
        public bool DeleteDisplayCard(string displaycardid)
        {
            string sql = "delete from DisplayCard where DisplayCardId = '" + displaycardid + "'";
            SqlConnection con = db.GetConnection();
            //tạo mới biến toàn cục, reset lại command
            SqlCommand cmd = new SqlCommand(sql, con);

            //Số dòng thực thi 0 được trả về 0
            con.Open();
            var kq = cmd.ExecuteNonQuery();
            con.Close();
            //Lớn hơn 0 = false
            return kq > 0;
        }
        public List<ListThuocTinh> getHardDrive(string harddriveid)
        {
            string sql;

            if (string.IsNullOrEmpty((harddriveid)))
            {
                sql = "Select * from HardDrive";

            }
            else
            {
                sql = "Select * from HardDrive where HardDriveID = '" + harddriveid + "'";

            }

            List<ListThuocTinh> strList = new List<ListThuocTinh>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListThuocTinh str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListThuocTinh();
                str.HardDriveID = dt.Rows[i]["HardDriveID"].ToString();
                str.HardDriveName = dt.Rows[i]["HardDriveName"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        public List<HardDriveList> getListHardDrive()
        {
            string sql = "Select * from HardDrive";

            List<HardDriveList> strList = new List<HardDriveList>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            HardDriveList str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new HardDriveList();
                str.HardDriveId = dt.Rows[i]["HardDriveID"].ToString();
                str.HardDriveName = dt.Rows[i]["HardDriveName"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        public bool CreateHardDrive(ListThuocTinh model)
        {
            string sql = "If not Exists (Select * from HardDrive where HardDriveID = '" + model.HardDriveID + "' ) begin insert into HardDrive(HardDriveID,HardDriveName) values ('" + model.HardDriveID + "',N'" + model.HardDriveName + "') end";
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
        public bool UpdateHardDrive(ListThuocTinh model)
        {
            string sql = "Update HardDrive set HardDriveName = N'" + model.HardDriveName + "' where HardDriveID = '" + model.HardDriveID + "'";
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
        public bool DeleteHardDrive(string harddriveid)
        {
            string sql = "delete from HardDrive where HardDriveId = '" + harddriveid + "'";
            SqlConnection con = db.GetConnection();
            //tạo mới biến toàn cục, reset lại command
            SqlCommand cmd = new SqlCommand(sql, con);

            //Số dòng thực thi 0 được trả về 0
            con.Open();
            var kq = cmd.ExecuteNonQuery();
            con.Close();
            //Lớn hơn 0 = false
            return kq > 0;
        }
        public List<ListThuocTinh> getYear(string yearid)
        {
            string sql;

            if (string.IsNullOrEmpty((yearid)))
            {
                sql = "Select * from Year";

            }
            else
            {
                sql = "Select * from Year where YearID = '" + yearid + "'";

            }

            List<ListThuocTinh> strList = new List<ListThuocTinh>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListThuocTinh str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListThuocTinh();
                str.YearID = dt.Rows[i]["YearID"].ToString();
                str.YearName = dt.Rows[i]["YearName"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        public List<YearList> getListYear()
        {
            string sql = "Select * from Year";

            List<YearList> strList = new List<YearList>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            YearList str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new YearList();
                str.YearId = dt.Rows[i]["YearID"].ToString();
                str.YearName = dt.Rows[i]["YearName"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        public bool CreateYear(ListThuocTinh model)
        {
            string sql = "If not Exists (Select * from Year where YearID = '" + model.YearID + "' ) begin insert into Year(YearID,YearName) values ('" + model.YearID + "',N'" + model.YearName + "') end";
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
        public bool UpdateYear(ListThuocTinh model)
        {
            string sql = "Update Year set YearName = N'" + model.YearName + "' where YearID = '" + model.YearID + "'";
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
        public bool DeleteYear(string yearid)
        {
            string sql = "delete from Year where YearId = '" + yearid + "'";
            SqlConnection con = db.GetConnection();
            //tạo mới biến toàn cục, reset lại command
            SqlCommand cmd = new SqlCommand(sql, con);

            //Số dòng thực thi 0 được trả về 0
            con.Open();
            var kq = cmd.ExecuteNonQuery();
            con.Close();
            //Lớn hơn 0 = false
            return kq > 0;
        }
        public List<ListThuocTinh> getGroup(string groupid)
        {
            string sql;

            if (string.IsNullOrEmpty((groupid)))
            {
                sql = "Select * from [Group]";

            }
            else
            {
                sql = "Select * from [Group] where GroupID = '" + groupid + "'";

            }

            List<ListThuocTinh> strList = new List<ListThuocTinh>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListThuocTinh str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListThuocTinh();
                str.GroupID = dt.Rows[i]["GroupID"].ToString();
                str.GroupName = dt.Rows[i]["GroupName"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        public List<GroupList> getListGroupMac()
        {
            string sql = "Select * from [Group] Where GroupId IN ('MA','MP')";

            List<GroupList> strList = new List<GroupList>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            GroupList str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new GroupList();
                str.GroupId = dt.Rows[i]["GroupID"].ToString();
                str.GroupName = dt.Rows[i]["GroupName"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        public List<GroupList> getListGroupPK()
        {
            string sql = "Select * from [Group] Where GroupId IN ('MK','MM','TP','TUI','CAP')";

            List<GroupList> strList = new List<GroupList>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            GroupList str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new GroupList();
                str.GroupId = dt.Rows[i]["GroupID"].ToString();
                str.GroupName = dt.Rows[i]["GroupName"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        public bool CreateGroup(ListThuocTinh model)
        {
            string sql = "If not Exists (Select * from [Group] where GroupID = '" + model.GroupID + "' ) begin insert into [Group](GroupID,GroupName) values ('" + model.GroupID + "',N'" + model.GroupName + "') end";
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
        public bool UpdateGroup(ListThuocTinh model)
        {
            string sql = "Update [Group] set GroupName = N'" + model.GroupName + "' where GroupID = '" + model.GroupID + "'";
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
        public bool DeleteGroup(string groupid)
        {
            string sql = "delete from [Group] where GroupId = '" + groupid + "'";
            SqlConnection con = db.GetConnection();
            //tạo mới biến toàn cục, reset lại command
            SqlCommand cmd = new SqlCommand(sql, con);

            //Số dòng thực thi 0 được trả về 0
            con.Open();
            var kq = cmd.ExecuteNonQuery();
            con.Close();
            //Lớn hơn 0 = false
            return kq > 0;
        }
        public List<ListThuocTinh> getRam(string ramid)
        {
            string sql;

            if (string.IsNullOrEmpty((ramid)))
            {
                sql = "Select * from Ram";

            }
            else
            {
                sql = "Select * from Ram where RamID = '" + ramid + "'";

            }

            List<ListThuocTinh> strList = new List<ListThuocTinh>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            ListThuocTinh str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new ListThuocTinh();
                str.RamID = dt.Rows[i][ "RamID"].ToString();
                str.RamName = dt.Rows[i]["RamName"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        public List<RamList> getListRam()
        {
            string sql = "Select * from Ram";

            List<RamList> strList = new List<RamList>();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            //Op Connect
            con.Open();
            cmd.Fill(dt);
            //close 
            cmd.Dispose();
            con.Close();

            RamList str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = new RamList();
                str.RamId = dt.Rows[i]["RamID"].ToString();
                str.RamName = dt.Rows[i]["RamName"].ToString();
                strList.Add(str);
            }
            return strList;
        }
        public bool CreateRam(ListThuocTinh model)
        {
            string sql = "If not Exists (Select * from Ram where RamID = '" + model.RamID + "' ) begin insert into Ram(RamID,RamName) values ('" + model.RamID + "',N'" + model.RamName + "') end";
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
        public bool UpdateRam(ListThuocTinh model)
        {
            string sql = "Update Ram set RamName = N'" + model.RamName + "' where RamID = '" + model.RamID + "'";
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
        public bool DeleteRam(string ramid)
        {
            string sql = "delete from Ram where RamId = '" + ramid + "'";
            SqlConnection con = db.GetConnection();
            //tạo mới biến toàn cục, reset lại command
            SqlCommand cmd = new SqlCommand(sql, con);

            //Số dòng thực thi 0 được trả về 0
            con.Open();
            var kq = cmd.ExecuteNonQuery();
            con.Close();
            //Lớn hơn 0 = false
            return kq > 0;
        }
    }
}