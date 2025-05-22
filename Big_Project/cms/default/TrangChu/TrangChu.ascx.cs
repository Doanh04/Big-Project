using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_default_TrangChu_TrangChu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ltrNhomSP.Text = laynhomsanpham();
    }

    private string laynhomsanpham()
    {
        string s = " ";
        DataTable dt = new DataTable();
        dt = Big_ProJect.DanhMuc.Thongtin_danhmuc();
        for(int i = 0; i < dt.Rows.Count; i++)
        {
            s += @"
        <div class='nhom-sanpham'>
            <div class='inner-title'>
                <h3>" + dt.Rows[i]["TenDM"] + @"</h3>
            </div>";

            s += laydanhsachsanphamtheodanhmuc(dt.Rows[i]["MaDM"].ToString());

            s += "<div style='clear:both'></div>";
            s += "</div>"; // đóng nhom-sanpham
        }

        return s;
    }

    private string laydanhsachsanphamtheodanhmuc(string MaDM)
    {
        string s = "<div class='row'>"; // Mở row ở đây

        DataTable dt = Big_ProJect.ThongtinSanPhamByMadm.Thongtin_sanpham_by_madm(MaDM);

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            string link = "/Default.aspx?module=chitietsp&id=" + dt.Rows[i]["MaSP"];
            s += @"
    <div class='col-md-2'>
            <div class='item card p-2 mb-3'>
                <a href='" + link + @"' title='" + dt.Rows[i]["MaSP"] + @"'>
                    <img src='/pic/SanPham/" + dt.Rows[i]["AnhSP"] + @"' alt='" + dt.Rows[i]["TenSP"] + @"' class='img-fluid' />
                </a>
                <a class='inner-titleSP fw-bold mt-2 d-block' href='" + link + @"' title='" + dt.Rows[i]["TenSP"] + @"'>
                    " + dt.Rows[i]["TenSP"] + @"
                </a>
                <div class='desc'>
                    " + dt.Rows[i]["GiaSP"] + @" đ
                </div>
                <a href='#' class='giohang'>Thêm vào giỏ hàng</a>
            </div>
        </div>";
        }

        s += "</div>"; // Đóng row sau khi thêm tất cả sản phẩm
        return s;
    }

}
