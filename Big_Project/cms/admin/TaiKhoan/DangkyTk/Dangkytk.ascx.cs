using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class cms_admin_TaiKhoan_DangkyTk_Dangkytk : System.Web.UI.UserControl
{
    public string thaotactk = "";
    public string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        //lấy querystring của thaotac và id
        if (Request.QueryString["thaotactk"] != null)
        {
            thaotactk = Request.QueryString["thaotactk"];
        }
        if (Request.QueryString["id"] != null)
        {
            id = Request.QueryString["id"];
        }
        if (!IsPostBack)
        {
            if (thaotactk == "chinhsuatk")
            {
                tbnadd.Text = "Chỉnh sửa";
            }
            else
            {
                tbnadd.Text = "Thêm mới";
            }
            if (thaotactk == "chinhsuatk")
            {
                txtTentaikhoan.Enabled = false; // không cho sửa
            }
            LayDanhQuyen();
            HienThiThongTin(id);
        }
    }

    private void HienThiThongTin(string id)
    {
        if (thaotactk == "chinhsuatk")
        {
            DataTable dt = new DataTable();

            dt = Big_ProJect.ThongTinDangKyByID.Thongtin_dangky_by_id(id);

            if (dt.Rows.Count > 0)
            {
                drDanhmucquyen.SelectedValue = dt.Rows[0]["MaQuyen"].ToString();
                txtTentaikhoan.Text = dt.Rows[0]["TenDangNhap"].ToString();
                txtPass.Text = dt.Rows[0]["MatKhau"].ToString();
                txtemail.Text = dt.Rows[0]["EmailDK"].ToString();
                txtName.Text = dt.Rows[0]["TenDayDu"].ToString();
                txtNgaysinh.Text = dt.Rows[0]["NgaySinh"].ToString();
                ddlGioitinh.Text = dt.Rows[0]["GioiTinhDK"].ToString();

            }

        }
    }

    protected void tbnadd_Click(object sender, EventArgs e)
    {

        //Phần update danh mục
        if (thaotactk == "chinhsuatk")
        {
            DateTime ngaySinhDateEdit;
            if (!DateTime.TryParse(txtNgaysinh.Text.Trim(), out ngaySinhDateEdit))
            {
                ltrthongbao.Text = "<span style='color:red'>Ngày sinh phải nhập đúng định dạng (YYYY-MM-DD).</span>";
                return;
            }

            string matKhauMoi = txtPass.Text.Trim();
            string matKhauUpdate = matKhauMoi;

            // Nếu không nhập mật khẩu mới, thì giữ lại mật khẩu cũ từ DB
            if (string.IsNullOrEmpty(matKhauMoi))
            {
                // Lấy lại mật khẩu cũ từ DB theo tên tài khoản
                DataTable dt = Big_ProJect.ThongTinDangKyByID.Thongtin_dangky_by_id(txtTentaikhoan.Text); // Viết thêm hàm này nếu chưa có

                if (dt.Rows.Count > 0)
                {
                    matKhauUpdate = dt.Rows[0]["MatKhau"].ToString();
                }
                else
                {
                    ltrthongbao.Text = "<span style='color:red'>Không tìm thấy tài khoản để cập nhật.</span>";
                    return;
                }
            }

            // Cập nhật tài khoản với mật khẩu đã xử lý
            Big_ProJect.Dangky.Dangky_update(
                txtTentaikhoan.Text,
                matKhauUpdate,
                txtemail.Text,
                txtName.Text,
                ngaySinhDateEdit,
                ddlGioitinh.Text,
                drDanhmucquyen.SelectedValue
            );

            ltrthongbao.Text = "Đã cập nhật tài khoản: " + txtTentaikhoan.Text;
        }

        else
        {
            //PHẦN THÊM MỚI DANH MỚI
            // Kiểm tra dữ liệu đầu vào
            string danhmucquyen = drDanhmucquyen.SelectedValue;
            string tenTaikhoan = txtTentaikhoan.Text.Trim();
            string pass = txtPass.Text.Trim();
            string email = txtemail.Text.Trim();
            string ngaysinh = txtNgaysinh.Text.Trim();
            string ten = txtName.Text.Trim();

                DateTime ngaySinhDate;
                if (!DateTime.TryParse(txtNgaysinh.Text.Trim(), out ngaySinhDate))
                {
                    ltrthongbao.Text = "<span style='color:red'>Ngày sinh phải nhập đúng định dạng (YYYY-MM-DD).</span>";
                    return;
                }
        // Biến lưu thông báo lỗi
        string thongBao = "";

            // Kiểm tra tên tài khoản
            if (string.IsNullOrEmpty(tenTaikhoan))
            {
                thongBao += "Vui lòng nhập tên tài khoản.<br/>";
            }
            //kiểm trai mật khẩu
            if (string.IsNullOrEmpty(pass))
            {
                thongBao += "Vui lòng nhập mật khẩu.<br/>";
            }
            //kiểm tra ngày sinh
            if (string.IsNullOrEmpty(ngaysinh)) 
            {
                thongBao += "Vui lòng nhập ngày sinh.<br/>";
            }
            // Kiểm tra thứ tự (hoặc danh mục cha)
            if (string.IsNullOrEmpty(danhmucquyen))
            {
                thongBao += "Vui lòng chọn quyền.<br/>";
            }
            //kiểm tra tên
            if (string.IsNullOrEmpty(ten))
            {
                thongBao += "Vui lòng chọn quyền.<br/>";
            }
            // Nếu có lỗi thì hiển thị, không thực hiện thêm danh mục
            if (!string.IsNullOrEmpty(thongBao))
            {
                ltrthongbao.Text = "<span style='color:red'>" + thongBao + "</span>";
                return;
            }

            // Gọi hàm thêm dữ liệu
            Big_ProJect.Dangky.Dangky_inser(txtTentaikhoan.Text, txtPass.Text, txtemail.Text, txtName.Text, ngaySinhDate, ddlGioitinh.Text, drDanhmucquyen.SelectedValue, "");
            ltrthongbao.Text = "Đã tạo tài khoản: " + txtTentaikhoan.Text;
        }
    }
    private void LayDanhQuyen()
    {

        //Hàm lấy ra thông tin danh mục cấp cao nhất theo mã quyền
        DataTable dt = new DataTable();
        dt = Big_ProJect.ThongTinQuyenDangNhao.Thongtin_quyendangnhap();
        drDanhmucquyen.Items.Clear();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ListItem item = new ListItem();
            item.Text = dt.Rows[i]["TenQuyen"].ToString();
            item.Value = dt.Rows[i]["TenQuyen"].ToString();
            drDanhmucquyen.Items.Add(new ListItem(dt.Rows[i]["TenQuyen"].ToString(), dt.Rows[i]["MaQuyen"].ToString()));
        }

    }

    protected void drDanhmuccha_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    private void ResetControl()
    {
        //txtMota.Text = " ";
        //txtTendanhmuc.Text = " ";
    }
    protected void btnhuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }

    //HÀM UPDATE

}
