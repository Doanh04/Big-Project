using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_TaiKhoan_Thongtintk_ajax_TaiKhoan : System.Web.UI.Page
{
    private string thaotactk = "";
    protected void Page_Load(object sender, EventArgs e)
    {


        //Cần kiểm tra đăng nhập ở đây sau đó mới thực hiện các thao tác ở dưới
        //kiểm tra đã đăng nhập mới cho vào admin
        if (Session["DangNhap"] != null && Session["DangNhap"].ToString() == "1")
        {
            //đã đăng nhập
        }
        else
        {
            return; //dừng khoonng cho thực hiện các câu lệnh ở dưới khi chưa đăng nhập
        }
        //////////////////////////////////////////////////////////////////////////////
        if (Request.Params["thaotactk"] != null)
        {
            thaotactk = Request.Params["thaotactk"];
        }
        switch (thaotactk)
        {
            case "XoaTaiKhoan":
                XoaTaiKhoan();
                break;
        }
    }
    private void XoaTaiKhoan()
    {
        string TenDangNhap = "";
        if (Request.Params["TenDangNhap"] != null)
            TenDangNhap = Request.Params["TenDangNhap"];
        //Thực hiện code xóa

        Big_ProJect.Dangky.Dangky_delete(TenDangNhap);
        //Trả về thông  báo 1-Thực hiện thành công 2-Không thành công
        Response.Write("1");
    }
}
