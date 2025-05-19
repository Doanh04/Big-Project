using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_SanPhamLoadcontrol : System.Web.UI.UserControl
{
    private string md2 = " ";
    private string thaotac = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["md2"] != null)
        {
            md2 = Request.QueryString["md2"];
        }
        switch (md2)
        {
            case "qlnsp"://Quản lý nhóm sản phẩm
                pldSp.Controls.Add(LoadControl("QuanLyNhomSanPham/QuanLyNhomSanPham.ascx"));
                break;
            case "qlsp"://quản lý sản phẩm
                pldSp.Controls.Add(LoadControl("QuanLySanPham/QuanLySanPham.ascx"));
                break;//Quản lý danh mục sản phẩm
            case "qldmsp"://Quản lý danh mục sản phẩm
                pldSp.Controls.Add(LoadControl("QuanLyDanhMucSanPham/QLDanhMucSanPham.ascx"));
                break;
            case "addNsp":
                pldSp.Controls.Add(LoadControl("AddNsp/AddNsp.ascx"));
                break;
            case "addSp":
                pldSp.Controls.Add(LoadControl("AddSp/AddSp.ascx"));
                break;
            case "addDmsp":
                pldSp.Controls.Add(LoadControl("AddDmsp/AddDmsp.ascx"));
                break;
            default:
                pldSp.Controls.Add(LoadControl("QuanLySanPham/QuanLySanPham.ascx"));
                break;
        }

         if(Request.QueryString["thaotac"] != null)
        {
            thaotac = Request.QueryString["thaotac"];
        }
        switch (thaotac)
        {
            case "chinhsua":
                pldSp.Controls.Add(LoadControl("AddDmsp/AddDmsp.ascx"));
                break;
            case "chinhsuasp":
                {
                    pldSp.Controls.Add(LoadControl("AddSp/AddSp.ascx"));
                }
                break;
        }

    }
}