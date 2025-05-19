using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_AdminLoad : System.Web.UI.UserControl
{
    string module = " ";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["module"] != null)
        {
            module = Request.QueryString["module"];
        }
        else
        {
            module = "default";
        }
        switch (module)
        {
            case "mn":
                plAdminloadcontrol.Controls.Add(LoadControl("Menu/MenuLoadControl.ascx"));
                break;
            case "nd":
                plAdminloadcontrol.Controls.Add(LoadControl("NoiDung/NoidungLoadControl.ascx"));
                break;
            case "sp":
                plAdminloadcontrol.Controls.Add(LoadControl("SanPham/SanPhamLoadControl.ascx"));
                break;
            case "tk":
                plAdminloadcontrol.Controls.Add(LoadControl("TaiKhoan/TaiKhoanLoadControl.ascx"));
                break;
            case "trangchu":
                plAdminloadcontrol.Controls.Add(LoadControl("TrangChu/TrangChuLoadControl.ascx"));
                break;
            case "httt":
                plAdminloadcontrol.Controls.Add(LoadControl("HTTT/HTTTLoadControl.ascx"));
                break;
            case "lh":
                plAdminloadcontrol.Controls.Add(LoadControl("LienHe/LienHeLoadControl.ascx"));
                break;
            default:
                plAdminloadcontrol.Controls.Add(LoadControl("TrangChu/TrangChuLoadControl.ascx"));
                break;
        }
    }
}