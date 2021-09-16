using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBanMacBook.Models
{
    public class ListThuocTinh
    {
        MyDataDataContext data = new MyDataDataContext();

        [Required(ErrorMessage = " Nhập CPU ID đi bạn")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "CPU ID chỉ được nhập số và chữ")]
        [Display(Name = "Mã CPU")]
        public string CpuID { get; set; }
        [Required(ErrorMessage = " Nhập Tên CPU đi bạn")]
        [Display(Name = "Tên CPU")]
        public string CpuName { get; set; }
        [Required(ErrorMessage = " Nhập DisplayCard ID đi bạn")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "DisplayCard ID chỉ được nhập số và chữ")]
        [Display(Name = "Mã DisplayCard")]
        public string DisplayCardID { get; set; }
        [Required(ErrorMessage = " Nhập DisplayCard Name đi bạn")]
        [Display(Name = "DisplayCard Name")]
        public string DisplayCardName { get; set; }
        [Required(ErrorMessage = " Nhập DisplayCard ID đi bạn")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Display ID chỉ được nhập số và chữ")]
        [Display(Name = "DisplayCard ID")]
        public string DisplayID { get; set; }
        [Required(ErrorMessage = " Nhập Display Name đi bạn")]
        [Display(Name = "Display Name")]
        public string DisplayName { get; set; }
        [Required(ErrorMessage = " Nhập Color ID đi bạn")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Color ID chỉ được nhập số và chữ")]
        [Display(Name = "Color ID")]
        public string ColorID { get; set; }
        [Required(ErrorMessage = " Nhập Color Name đi bạn")]
        [Display(Name = "Color Name")]
        public string ColorName { get; set; }
        [Required(ErrorMessage = " Nhập Year ID đi bạn")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Year ID chỉ được nhập số và chữ")]
        [Display(Name = "Year ID")]
        public string YearID { get; set; }
        [Required(ErrorMessage = " Nhập Year Name đi bạn")]
        [Display(Name = "Year Name")]
        public string YearName { get; set; }
        [Required(ErrorMessage = " Nhập HarDrive ID đi bạn")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "HardDrive ID chỉ được nhập số và chữ")]
        [Display(Name = "HardDrive ID")]
        public string HardDriveID { get; set; }
        [Required(ErrorMessage = " Nhập HardDrive Name đi bạn")]
        [Display(Name = "HardDrive Name")]
        public string HardDriveName { get; set; }
        [Required(ErrorMessage = " Nhập Ram ID đi bạn")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Ram ID chỉ được nhập số và chữ")]
        [Display(Name = "Ram ID")]
        public string RamID { get; set; }
        [Required(ErrorMessage = " Nhập Ram Name đi bạn")]
        [Display(Name = "Ram Name")]
        public string RamName { get; set; }
        [Required(ErrorMessage = " Nhập Group ID đi bạn")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Group ID chỉ được nhập số và chữ")]
        [Display(Name = "Group ID")]
        public string GroupID { get; set; }
        [Required(ErrorMessage = " Nhập Group Name đi bạn")]
        [Display(Name = "Group Name")]
        public string GroupName { get; set; }

        public ListThuocTinh()
        {

        }
    }
}