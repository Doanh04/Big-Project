using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["DangNhap"] != null && Session["DangNhap"].ToString() == "1")
            {
                string email = Session["emailkh"] != null ? Session["emailkh"].ToString() : "bạn";

                string script = string.Format(@"
                <script type='text/javascript'>
                    window.onload = function() {{
                        showWelcomeMessage('{0}');
                    }};
                </script>", email);

                ClientScript.RegisterStartupScript(this.GetType(), "WelcomeScript", script);
            }
        }
        //Session.Clear();
        //Session.Abandon();
        //Response.Redirect("Default.aspx");
    }

    protected void btnDangNhap_Click(object sender, EventArgs e)
    {
 
        DataTable dt = Big_ProJect.ThongTinKhachHangByEmailkhMatKhau.Thongtin_khachhang_by_emailkh_matkhau(loginEmail.Value, loginPassword.Value);
        string email = loginEmail.Value.Trim();
        string matkhau = loginPassword.Value.Trim();
        if (dt.Rows.Count > 0)//nếu có kết quả trả về(đăng nhập thành công lưu gtri vào session đánh dấu đăng nhập thành công)
        {
            Session["DangNhap"] = "1"; //gán = 1 để thể hiện thành công
            //gán thông tin tài khoarnn đã dăng nnhaapj
            Session["emailkh"] = dt.Rows[0]["emailkh"];
            Session["tenkh"] = dt.Rows[0]["tenkh"];
            Response.Redirect("/Default.aspx");
        }
        else
        {
            ltrthongbao.Text = "Tên đăng nhập hoặc mật khẩu không chính xác";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowModal", "$('#staticBackdrop').modal('show');", true);
        }
    }
}