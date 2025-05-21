using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class dkuser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDangKy_Click(object sender, EventArgs e)
    {
        string hoten = txtHoTen.Text.Trim();
        string diachi = txtDiaChi.Text.Trim();
        string sdt = txtDienThoai.Text.Trim();
        string email = txtEmail.Text.Trim();
        string matkhau = txtMatKhau.Text.Trim();

        string thongBao = "";

        if (string.IsNullOrEmpty(hoten))
        {
            thongBao += "vui lòng nhập tên";
        }
        if (string.IsNullOrEmpty(diachi))
        {
            thongBao += "vui lòng nhập địa chỉ";
        }
        if (string.IsNullOrEmpty(sdt))
        {
            thongBao += "vui lòng nhập số điện thoại";
        }
        if (string.IsNullOrEmpty(email))
        {
            thongBao += "vui lòng nhập địa chỉ email";
        }
        if (string.IsNullOrEmpty(matkhau))
        {
            thongBao += "vui lòng nhập mật khẩu";
        }
        if (!email.Contains("@") || !email.Contains("."))
        {
            thongBao += "• Email không hợp lệ<br/>";
        }
        if (matkhau.Length < 6)
        {
            thongBao += "• Mật khẩu phải từ 6 ký tự trở lên<br/>";
        }
        // Nếu có lỗi thì hiển thị, không thực hiện đăng ký tài khoản
        if (!string.IsNullOrEmpty(thongBao))
        {
            ltrthongbao.Text = "<span style='color:red'>" + thongBao + "</span>";
            return;
        }

        //hàm thêm dữ liêuj
        Big_ProJect.KhachHang.Khachang_inser(txtHoTen.Text, txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text, txtMatKhau.Text, " ");
        ltrthongbao.Text = "Đã tạo tài khoản: " + txtEmail.Text;
        // Tạo session đăng nhập
        Session["KhachHang_Email"] = email;
        Session["KhachHang_HoTen"] = hoten;

        // Chuyển về trang chính
        Response.Redirect("~/Default.aspx");
    }
}