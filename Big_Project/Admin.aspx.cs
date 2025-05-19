using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //kiểm tra đã đăng nhập mới cho vào admin
        if (Session["DangNhap"]!=null && Session["DangNhap"].ToString() == "1")
        {
            //đã đăng nhập
        }
        else
        {
            //trả về trang login khi chưa đăng nhập
            Response.Redirect("/login.aspx");
        }

        if (!IsPostBack)
        { 
            ltrTenDangNhap.Text= Session["TenDangNhap"].ToString();
        }

        //đăng xuất

    }

    protected void btndangxuat_Click(object sender, EventArgs e)
    {
        //xóa session đẫ lưu để đăng xuất
        Session["DangNhap"]=null;
        Session["TenDangNhap"]=null ;
        Response.Redirect("/login.aspx");
    }
}