using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyDanhMucSanPham_ajax_DanhMuc : System.Web.UI.Page
{
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {


        //Cần kiểm tra đăng nhập ở đây sau đó mới thực hiện các thao tác ở dưới

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
        if (Request.Params["ThaoTac"] != null)
        {
            thaotac = Request.Params["ThaoTac"];
        }
        switch (thaotac)
        {
            case "XoaDanhMuc":
                XoaDanhMuc();
                break;
        }
    }
    private void XoaDanhMuc()
    {
        string MaDM = "";
        if (Request.Params["MaDM"] != null)
            MaDM = Request.Params["MaDM"];
        //Thực hiện code xóa

        Big_ProJect.DanhMuc.Danhmuc_delete(MaDM);
        //Trả về thông  báo 1-Thực hiện thành công 2-Không thành công
        Response.Write("1");
    }
}