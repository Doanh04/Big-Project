using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLyDanhMucSanPham_QLDanhMucSanPham : System.Web.UI.UserControl
{
    string madmcha = "0";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["madmcha "] != null)
        {
            madmcha = Request.QueryString["madmcha"];
        }
        if (!IsPostBack)
            laydanhmuc();
    }
    private void laydanhmuc()
    {
        DataTable dt = new DataTable();
        dt = Big_ProJect.ThongTinDanhMucByMaDMcha.Thongtin_danhmuc_by_MaDMCha(madmcha);
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ltrDanhmuc.Text += @"
             <tr id='maDong_" + dt.Rows[i]["MaDM"] + @"'>
                <td><i class='fas fa-barcode'></i> " + dt.Rows[i]["MaDM"] + @"</td>
                <td><i class='fas fa-tag'></i> " + dt.Rows[i]["TenDM"] + @"</td>
                <td><i class=''></i><img class='img' src='/pic/SanPham/" + dt.Rows[i]["AnhDaiDien"] + @"'</td>
                <td><i class='fas fa-layer-group'></i>  " + dt.Rows[i]["ThuTu"] + @"</td>
                <td><i class='fas fa-sort-numeric-down'></i>  " + dt.Rows[i]["MaDMCha"] + @"</td>
                <td><span class='badge badge-success'>Hiển thị</span></td>
                <td><a href='/Admin.aspx?module=sp&md2=qldmsp&madmcha=" + dt.Rows[i]["MaDM"] + @"' class='text-primary mx-1' title='Thêm danh mục con'>
                        <i class='fas fa-plus-circle'></i>
                    </a>
                    <a href = '/Admin.aspx?module=sp&md2=qldmsp&thaotac=chinhsua&id=" + dt.Rows[i]["MaDM"] + @"' class='text-warning mx-1' title='Sửa danh mục'>
                        <i class='fas fa-pen-to-square'></i>
                    </a>
                    <a href='javascript:void(0)' onclick='XoaDanhMuc(" + dt.Rows[i]["MaDM"] + @")' class='text-danger mx-1' title='Xóa danh mục'>
                        <i class='fas fa-trash-alt'></i>
                    </a>

                </td>
            </tr>
";
        }
    }
}


