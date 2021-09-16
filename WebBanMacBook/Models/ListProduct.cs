using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WebBanMacBook.Models
{
    public class ListProduct
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Nhập Name đi bạn hiền")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Nhập Stock đi bạn hiền")]
        [Display(Name = "Stock")]
        public int Stock { get; set; }
        [Required(ErrorMessage = "Nhập Sold đi bạn hiền")]
        [Display(Name = "Sold")]
        public int Sold { get; set; }
        [Required(ErrorMessage = "Nhập Description đi bạn hiền")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Nhập Price đi bạn hiền")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Nhập Source đi bạn hiền")]
        [Display(Name = "Source")]
        public string ImageSource { get; set; }
        [Required(ErrorMessage = "Nhập Source đi bạn hiền")]
        [Display(Name = "Source1")]
        public string ImageSource1 { get; set; }
        [Required(ErrorMessage = "Nhập Source đi bạn hiền")]
        [Display(Name = "Source2")]
        public string ImageSource2 { get; set; }
        [Required(ErrorMessage = "Nhập Source đi bạn hiền")]
        [Display(Name = "Source3")]
        public string ImageSource3 { get; set; }

        [Required(ErrorMessage = "Nhập CpuId đi bạn hiền")]
        [Display(Name = "CpuID")]
        public string CpuId { get; set; }

        public IEnumerable<CpuList> listcpu { get; set; }
        [Required(ErrorMessage = "Nhập DisplayCardId  đi bạn hiền")]
        [Display(Name = "DisplayCardId ")]
        public IEnumerable<DisplayCardList> listdisplaycard { get; set; }
        public string DisplayCardId { get; set; }
        [Required(ErrorMessage = "Nhập DisplayId  đi bạn hiền")]
        [Display(Name = "DisplayId ")]
        public IEnumerable<DisplayList> listdisplay { get; set; }
        public string DisplayId { get; set; }
        [Required(ErrorMessage = "Nhập ColorId đi bạn hiền")]
        [Display(Name = "ColorId ")]
        public IEnumerable<ColorList> listcolor{ get; set; }
        public string ColorId { get; set; }
        [Required(ErrorMessage = "Nhập YearId đi bạn hiền")]
        [Display(Name = "YearId ")]
        public IEnumerable<YearList> listyear { get; set; }
        public string YearId { get; set; }
        [Required(ErrorMessage = "Nhập HardDriveId đi bạn hiền")]
        [Display(Name = "HardDriveId ")]
        public IEnumerable<HardDriveList> listharddrive { get; set; }
        public string HardDriveId { get; set; }
        [Required(ErrorMessage = "Nhập RamId đi bạn hiền")]
        [Display(Name = "RamId ")]
        public IEnumerable<RamList> listram { get; set; }
        public string RamId { get; set; }
        [Required(ErrorMessage = "Nhập GroupId đi bạn hiền")]
        [Display(Name = "GroupId ")]
        public IEnumerable<GroupList> listgroup { get; set; }
        public string GroupId { get; set; }
        [Required(ErrorMessage = "Nhập Status đi bạn hiền")]
        [Display(Name = "Status ")]
        public string Status { get; set; }


        public ListProduct()
        {

        }

    }

    public class CpuList
    {
        public string CpuId { get; set; }
        public string CpuName { get; set; }
    }

    public class DisplayCardList
    {
        public string DisplayCardId { get; set; }
        public string DisplayCardName { get; set; }

    }
    public class DisplayList
    {
        public string DisplayId { get; set; }
        public string DisplayName { get; set; }

    }
    public class ColorList
    {
        public string ColorId { get; set; }
        public string ColorName { get; set; }

    }
    public class YearList
    {
        public string YearId { get; set; }
        public string YearName { get; set; }

    }
    public class HardDriveList
    {
        public string HardDriveId { get; set; }
        public string HardDriveName { get; set; }

    }
    public class RamList
    {
        public string RamId { get; set; }
        public string RamName { get; set; }

    }
    public class GroupList
    {
        public string GroupId { get; set; }
        public string GroupName { get; set; }

    }
}