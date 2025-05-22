using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class cms_default_DefaultLoad : System.Web.UI.UserControl
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
            case "home":
                pldWeb.Controls.Add(LoadControl("TrangChu/TrangChu.ascx"));
                break;
            case "km":
                pldWeb.Controls.Add(LoadControl("KhuyenMai/KhuyenMaii.ascx"));
                break;
            case "Quaybanhkeo":
                pldWeb.Controls.Add(LoadControl("QuayBanhKeo/QuayBanhKeo.ascx"));
                break;
            case "Tudoanvat":
                pldWeb.Controls.Add(LoadControl("TuDoAnVat/Tudoanvat.ascx"));
                break;
            case "event":
                pldWeb.Controls.Add(LoadControl("TinTuc/TinTuc.ascx"));
                break;
            case "chitietsp":
                pldWeb.Controls.Add(LoadControl("chitietsp/chitietsp.ascx"));
                break;
            default:
                pldWeb.Controls.Add(LoadControl("TrangChu/TrangChu.ascx"));
                break;
        }
    }
}