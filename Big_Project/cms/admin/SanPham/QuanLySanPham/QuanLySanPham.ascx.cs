using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_QuanLySanPham_QuanLySanPham : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            laysanpham();
    }
    private void laysanpham()
    {
        //ltrSanPham.Text = @"
        //<tr>
        //    <td><i class='fas fa-barcode'></i> 1</td>
        //    <td><i class='fas fa-tag'></i> Sản phẩm test</td>
        //    <td><img class='img' src='/pic/SanPham/test.jpg' /></td>
        //    <td><i class='fas fa-boxes'></i> 100</td>
        //    <td><i class='fas fa-dollar-sign'></i> 500000</td>
        //    <td><i class='fas fa-calendar-plus'></i> 16/05/2025</td>
        //    <td><span class='badge badge-success'>Hiển thị</span></td>
        //    <td><i class='fas fa-tools'></i> Công cụ</td>
        //</tr>";
        DataTable dt = new DataTable();
        dt = Big_ProJect.SanPham.Thongtin_sanpham();
        ltrSanPham.Text = "";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            string ngayTaoStr = Convert.ToDateTime(dt.Rows[i]["NgayTao"]).ToString("dd/MM/yyyy");

            ltrSanPham.Text += @"

            <tr id='maDong_" + dt.Rows[i]["MaSP"] + @"'>
                    <td><i class='fas fa-barcode'></i> " + dt.Rows[i]["MaSP"] + @"</td>
                    <td><i class='fas fa-tag'></i> " + dt.Rows[i]["TenSP"] + @"</td>
                    <td><i class=''></i> <img class='img' src='/pic/SanPham/" + dt.Rows[i]["AnhSP"] + @"' /></td>
                    <td><i class='fas fa-boxes'></i> " + dt.Rows[i]["SoLuongSP"] + @"</td>
                    <td><i class='fas fa-dollar-sign'></i> " + dt.Rows[i]["GiaSP"] + @" VNĐ</td>
                    <td><i class='fas fa-calendar-plus'></i> " + ngayTaoStr + @"</td>
                    <td><span class='badge badge-success'>Hiển thị</span></td>
                    <td>
                           <a href = '/Admin.aspx?module=sp&md2=qlsp&thaotac=chinhsuasp&id=" + dt.Rows[i]["MaSP"] + @"' class='text-warning mx-1' title='Sửa sản phẩm'>
                                                <i class='fas fa-pen-to-square'></i>
                                 </a>
                            <a href='javascript:void(0)' onclick='XoaSanPham(" + dt.Rows[i]["MaSP"] + @")' class='text-danger mx-1' title='Xóa sản phẩm'>
                                    <i class='fas fa-trash-alt'></i>
                               </a>
                    </td>
            </tr>
";
        }
    }
}