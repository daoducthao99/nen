using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebBanVaLi.Models
{
    [MetadataTypeAttribute(typeof(tDanhMucSPMetadata))] 
    public partial class tDanhMucSP
    {
        internal sealed class tDanhMucSPMetadata
        {
            [Display(Name = "Mã Sản Phẩm")]
            [Required(ErrorMessage = "Vui Lòng Nhâp dữ cho trường này")]
            public string MaSP { get; set; }
            [Display(Name = "Tên Sản Phẩm")]
            [Required(ErrorMessage = "Vui Lòng Nhâp dữ cho trường này")]
            public string TenSP { get; set; }
            [Display(Name = "Mã chất liệu")]
            public string MaChatLieu { get; set; }
            [Display(Name = "Ngăn LapTop")]
            public string NganLapTop { get; set; }
            [Display(Name = "Model")]
            public string Model { get; set; }
            [Display(Name = "Màu sắc")]
            public string MauSac { get; set; }
            [Display(Name = "Kích thước")]
            public string MaKichThuoc { get; set; }
            public Nullable<double> CanNang { get; set; }
            [Display(Name = "Độ nói")]
            public Nullable<double> DoNoi { get; set; }
            [Display(Name = "Mã hãng sản xuất")]
            public string MaHangSX { get; set; }
            [Display(Name = "Mã nước sx")]
            public string MaNuocSX { get; set; }
            [Display(Name = "Mã đặc tính")]
            public string MaDacTinh { get; set; }
            public string Website { get; set; }
            [Display(Name = "Thời Gian bảo hành")]
            public Nullable<double> ThoiGianBaoHanh { get; set; }
            [Display(Name = "Giới Thiệu SP")]
            public string GioiThieuSP { get; set; }
            [Display(Name = "Giá SP")]
            public Nullable<double> Gia { get; set; }
            [Display(Name = "Chiếu Khấu")]
            public Nullable<double> ChietKhau { get; set; }
            [Display(Name = "Mã Loại")]
            public string MaLoai { get; set; }
            [Display(Name = "Mã đối Tượng")]
            public string MaDT { get; set; }
            [Display(Name = "Ảnh Sản Phẩm")]
            public string Anh { get; set; }

        }
    }
}