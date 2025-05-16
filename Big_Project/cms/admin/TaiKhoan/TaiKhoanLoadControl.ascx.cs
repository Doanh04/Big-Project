using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_TaiKhoan_TaiKhoanLoadControl : System.Web.UI.UserControl
{
    string tk= " ";
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Request.QueryString["tk"] != null)
        {
            tk = Request.QueryString["tk"];
        }
        switch (tk)
        {
            case "dktk":
                pldtk.Controls.Add(LoadControl("DangkyTk/Dangkytk.ascx"));
                break;
            case "qmk":
                pldtk.Controls.Add(LoadControl("RSpass/RSPass.ascx"));
                break;
            case "tttk":
                pldtk.Controls.Add(LoadControl("Thongtintk/ThongTinTK.ascx"));
                break;
        }
    }
}