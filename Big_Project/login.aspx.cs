using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //check database để login
        DataTable dt = Big_ProJect.ThongTinDangKyByIDMK.Thongtin_dangky_by_id_matkhau(txtUsername.Text, txtPassword.Text);
        if(dt.Rows.Count > 0)//nếu có kết quả trả về(đăng nhập thành công lưu gtri vào session đánh dấu đăng nhập thành công)
        {
            Session["DangNhap"] = "1"; //gán = 1 để thể hiện thành công
            //gán thông tin tài khoarnn đã dăng nnhaapj
            Session["TenDangNhap"] = dt.Rows[0]["TenDangNhap"];
            Response.Redirect("/Admin.aspx");
        }
        else
        {
            ltrMessage.Text = "Tên đăng nhập hoặc mật khẩu không chính xác";
        }
    }
}