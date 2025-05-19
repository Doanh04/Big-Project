using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_TaiKhoan_Thongtintk_ThongTinTK : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            laytaikhoan();
    }

    //    private void laytaikhoan()
    //    {
    //        DataTable dt = new DataTable();
    //        dt = Big_ProJect.Dangky.Thongtin_dangky();

    //        for (int i = 0; i < dt.Rows.Count; i++)
    //        {
    //            string ngaysinh = Convert.ToDateTime(dt.Rows[i]["NgaySinh"]).ToString("dd/MM/yyyy");

    //            ltrTaikhoan.Text += @"

    //            <tr id='maDong_" + dt.Rows[i]["TenDangNhap"] + @"'>
    //                    <td><i class='fas fa-user'></i> " + dt.Rows[i]["TenDangNhap"] + @"</td>
    //                    <td><i class='fas fa-envelope'></i> " + dt.Rows[i]["EmailDK"] + @"</td>
    //                    <td><i class='fas fa-id-card'></i> " + dt.Rows[i]["TenDayDu"] + @"</td>
    //                    <td><i class='fas fa-dollar-sign'></i> " + ngaysinh + @"</td>
    //                    <td><i class='fas fa-venus-mars'></i> " + dt.Rows[i]["GioiTinhDK"] + @"</td>
    //                    <td><span class='badge badge-success'>Hiển thị</span></td>
    //                    <td>
    //                           <a href='/Admin.aspx?module=tk&tk=tttk&thaotactk=chinhsuatk&id=" + dt.Rows[i]["TenDangNhap"] + @"' class='text-warning mx-1' title='Tài khoản'>
    //                                <i class='fas fa-pen-to-square'></i>
    //                            </a>
    //                            <a href='javascript:void(0)' onclick='XoaTaiKhoan(" + dt.Rows[i]["TenTaiKhoan"] + @")' class='text-danger mx-1' title='Xóa tài khoản'>
    //                                    <i class='fas fa-trash-alt'></i>
    //                               </a>
    //                    </td>
    //            </tr>
    //";
    //        }
    //    }
    private void laytaikhoan()
    {
        DataTable dt = new DataTable();
        dt = Big_ProJect.Dangky.Thongtin_dangky();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            string tenDangNhap = dt.Rows[i]["TenDangNhap"].ToString().Replace("'", "\\'");
            string email = dt.Rows[i]["EmailDK"].ToString();
            string tenDayDu = dt.Rows[i]["TenDayDu"].ToString();
            string gioiTinh = dt.Rows[i]["GioiTinhDK"].ToString();
            string ngaysinh = Convert.ToDateTime(dt.Rows[i]["NgaySinh"]).ToString("dd/MM/yyyy");

            ltrTaikhoan.Text +=
                "<tr id='maDong_" + tenDangNhap + "'>" +
                    "<td><i class='fas fa-user'></i> " + tenDangNhap + "</td>" +
                    "<td><i class='fas fa-envelope'></i> " + email + "</td>" +
                    "<td><i class='fas fa-id-card'></i> " + tenDayDu + "</td>" +
                    "<td><i class='fas fa-dollar-sign'></i> " + ngaysinh + "</td>" +
                    "<td><i class='fas fa-venus-mars'></i> " + gioiTinh + "</td>" +
                    "<td><span class='badge badge-success'>Hiển thị</span></td>" +
                    "<td>" +
                        "<a href='/Admin.aspx?module=tk&tk=tttk&thaotactk=chinhsuatk&id=" + tenDangNhap + "' class='text-warning mx-1' title='Chỉnh sửa tài khoản'>" +
                            "<i class='fas fa-pen-to-square'></i>" +
                        "</a>" +
                        "<a href=\"javascript:XoaTaiKhoan('" + tenDangNhap + "')\" class='text-danger mx-1' title='Xóa tài khoản'>" +
                            "<i class='fas fa-trash-alt'></i>" +
                        "</a>" +
                    "</td>" +
                "</tr>";
        }
    }

}