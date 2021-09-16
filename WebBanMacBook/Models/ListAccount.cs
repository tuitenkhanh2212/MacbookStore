using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBanMacBook.Models
{
    public class ListAccount
    {
        MyDataDataContext data = new MyDataDataContext();
        public int CustomerID { get; set; }
        [Required(ErrorMessage = " Nhập họ và tên lót đi bạn")]
        [Display(Name = "Họ và tên lót")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = " Nhập tên đi bạn")]
        [Display(Name = "Tên")]
        public string LastName { get; set; }
        [Required(ErrorMessage = " Nhập Tài khoản đi bạn")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Tài khoản chỉ được nhập số và chữ")]
        [MinLength(6, ErrorMessage = "Tài khoản tối thiểu 6 ký tự")]
        [MaxLength(30, ErrorMessage = "Tài khoản tối đa 30 ký tự")]
        [Display(Name = "Tài khoản ")]
        public string Account { get; set; }
        [Required(ErrorMessage = " Nhập Mật khẩu đi bạn")]
        [Display(Name = "Mật Khẩu")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Mật khẩu chỉ được nhập số và chữ")]
        [MinLength(6, ErrorMessage = "Mật khẩu tối thiểu 6 ký tự")]
        [MaxLength(16, ErrorMessage = "Mật khẩu tối đa 16 ký tự")]
        public string Password { get; set; }
        [Required(ErrorMessage = " Nhập Email đi bạn")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Vui lòng nhập đúng địa chỉ Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = " Nhập ngày đi bạn hiền")]
        //[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Ngày sinh")]
        public DateTime Birth { get; set; }
        [Required(ErrorMessage = " Nhập Địa chỉ đi bạn")]
        [Display(Name = "Địa Chỉ")]
        public string  Address{ get; set; }
        [Required(ErrorMessage = " Nhập SDT đi bạn")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Số điện thoại phải là số ")]
        [Display(Name = "Số Điện Thoại")]
        
        public string PhoneNumber { get; set; }

        public ListAccount()
        {

        }
    }
}