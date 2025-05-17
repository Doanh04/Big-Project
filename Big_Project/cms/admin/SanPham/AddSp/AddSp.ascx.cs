using Big_ProJect;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cms_admin_SanPham_AddSp_AddSp : System.Web.UI.UserControl
{
    public string thaotac = "";
    public string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        txtNgaytao.Text = DateTime.Now.ToString("MM/dd/yyyy");
        txtNgayhuy.Text = DateTime.Now.ToString("MM/dd/yyyy");
        #region Code đổi tên nút chỉnh sửa, thêm mới theo querystring
        //lấy querystring của thaotac và id
        if (Request.QueryString["thaotac"] != null)
        {
            thaotac = Request.QueryString["thaotac"];
        }
        if (Request.QueryString["id"] != null)
        {
            id = Request.QueryString["id"];
        }
        if (!IsPostBack)
        {
            if (thaotac == "chinhsuasp")
            {
                tbnadd.Text = "Chỉnh sửa";
            }
            else
            {
                tbnadd.Text = "Thêm mới";
            }
            #endregion
            LayDanhMucCha();
            HienThiThongTin(id);
        }
    }

    private void HienThiThongTin(string id)
    {
        if (thaotac == "chinhsuasp")
        {
            DataTable dt = new DataTable();

            dt = Big_ProJect.ThongTinSanPhamByID.Thongtin_sanpham_by_id(id);

            if (dt.Rows.Count > 0)
            {
                drDanhmuccha.SelectedValue = dt.Rows[0]["MaDM"].ToString();
                txtTensp.Text = dt.Rows[0]["TenSP"].ToString();
                ltrAvt.Text = "<img class='img' src='/pic/SanPham/" + dt.Rows[0]["AnhSP"] + @"'/>";
                hdTenAvtCu.Value = dt.Rows[0]["AnhSP"].ToString();
                txtSoluong.Text = dt.Rows[0]["SoLuongSP"].ToString();
                txtGiasp.Text = dt.Rows[0]["GiaSP"].ToString();
                txtMota.Text = dt.Rows[0]["MotaSP"].ToString();
                txtNgaytao.Text = dt.Rows[0]["NgayTao"].ToString();
                txtNgayhuy.Text = dt.Rows[0]["NgayHuy"].ToString();


            }

        }
    }

    protected void tbnadd_Click(object sender, EventArgs e)
    {
        if (thaotac == "chinhsuasp")
        {
            string TenAVT = "";

            if (flAvt.FileContent.Length > 0)
            {
                if (flAvt.FileName.EndsWith(".jpg") || flAvt.FileName.EndsWith(".jpeg") || flAvt.FileName.EndsWith(".png") || flAvt.FileName.EndsWith(".gif"))
                {
                    flAvt.SaveAs(Server.MapPath("~/pic/SanPham/") + flAvt.FileName);
                    TenAVT = flAvt.FileName;
                }
            }
            if (TenAVT == "")
            {
                TenAVT = hdTenAvtCu.Value;
            }
            //Big_ProJect.SanPham.Sanpham_update(id, txtTensp.Text, TenAVT, txtSoluong.Text, txtGiasp.Text, txtMota.Text, txtNgaytao.Text, txtNgayhuy.Text, drDanhmuccha.SelectedValue, ");
            ////Big_ProJect.DanhMuc.Danhmuc_update(txtTendanhmuc.Text, flAvt.FileName, txtMota.Text, drDanhmuccha.SelectedValue, " ");
            //ltrthongbao.Text = "Đã cập nhật danh mục: " + txtTensp.Text;
            int soluong, gia, madm;
            string thongBao = "";

            // Kiểm tra số lượng
            if (!int.TryParse(txtSoluong.Text.Trim(), out soluong))
                thongBao += "Số lượng không hợp lệ.<br/>";

            // Kiểm tra giá
            if (!int.TryParse(txtGiasp.Text.Trim(), out gia))
                thongBao += "Giá không hợp lệ.<br/>";

            // Kiểm tra mã danh mục
            if (!int.TryParse(drDanhmuccha.SelectedValue, out madm))
                thongBao += "Danh mục không hợp lệ.<br/>";

            if (thongBao != "")
            {
                ltrthongbao.Text = "<span style='color:red'>" + thongBao + "</span>";
                return;
            }

            // Gọi hàm khi đã chắc chắn dữ liệu hợp lệ
            Big_ProJect.SanPham.Sanpham_update(
                id,
                txtTensp.Text.Trim(),
                TenAVT,
                soluong.ToString(), // ép về string
                gia.ToString(),
                txtMota.Text.Trim(),
                txtNgaytao.Text.Trim(),
                txtNgayhuy.Text.Trim(),
                madm.ToString());
        }
        else
        {
            string tenSP = txtTensp.Text.Trim();
            string moTa = txtMota.Text.Trim();
            string soLuongStr = txtSoluong.Text.Trim();
            string giaStr = txtGiasp.Text.Trim();
            string ngayTao = txtNgaytao.Text.Trim();
            string ngayHuy = txtNgayhuy.Text.Trim();
            string danhMuc = drDanhmuccha.SelectedValue;
            string fileName = flAvt.FileName;

            string thongBao = "";

            if (string.IsNullOrEmpty(tenSP))
                thongBao += "Vui lòng nhập tên sản phẩm.<br/>";
            if (string.IsNullOrEmpty(soLuongStr))
                thongBao += "Số lượng phải là số nguyên.<br/>";
            if (string.IsNullOrEmpty(giaStr))
                thongBao += "Giá sản phẩm phải là số.<br/>";
            if (string.IsNullOrEmpty(danhMuc))
                thongBao += "Vui lòng chọn danh mục sản phẩm.<br/>";

            if (flAvt.FileContent.Length == 0)
            {
                ltrthongbao.Text += "Vui lòng chọn ảnh đại diện.<br/>";
            }
            else if (!(fileName.EndsWith(".jpg") || fileName.EndsWith(".jpeg") || fileName.EndsWith(".png") || fileName.EndsWith(".gif")))
                thongBao += "Chỉ chấp nhận ảnh .jpg, .jpeg, .png, .gif<br/>";

            if (!string.IsNullOrEmpty(thongBao))
            {
                ltrthongbao.Text = "<span style='color:red'>" + thongBao + "</span>";
                return;
            }
            string tenFile = Path.GetFileName(fileName);
            string path = Server.MapPath("~/pic/SanPham/");

            string TenAVT = "";
            if (flAvt.FileContent.Length > 0)
            {
                flAvt.SaveAs(path + tenFile);
                TenAVT = tenFile;
            }
            else
            {
                TenAVT = hdTenAvtCu.Value;
            }
            int soLuong = 0;
            int gia = 0;
            int maDM = 0;

            if (!int.TryParse(txtSoluong.Text, out soLuong))
                thongBao += "Số lượng không hợp lệ.<br/>";

            if (!int.TryParse(txtGiasp.Text, out gia))
                thongBao += "Giá không hợp lệ.<br/>";

            if (!int.TryParse(drDanhmuccha.SelectedValue, out maDM))
                thongBao += "Danh mục không hợp lệ.<br/>";



            // Nếu có lỗi thì báo
            if (!string.IsNullOrEmpty(thongBao))
            {
                thongBao = "<span style='color:red'>" + thongBao + "</span>";
                return;
            }

            // Nếu không có lỗi thì thêm sản phẩm
            Big_ProJect.SanPham.Sanpham_Inser(txtTensp.Text, flAvt.FileName, txtSoluong.Text, txtGiasp.Text, txtMota.Text, txtNgaytao.Text, txtNgayhuy.Text, drDanhmuccha.SelectedValue, " ");

            ltrthongbao.Text = "Đã thêm sản phẩm: " + tenSP;
        }
    }

    private void LayDanhMucCha()
    {

        //Hàm lấy ra thông tin danh mục cấp cao nhất theo mã danh mục cha
        DataTable dt = new DataTable();
        dt = Big_ProJect.ThongTinDanhMucByMaDMcha.Thongtin_danhmuc_by_MaDMCha("0");
        drDanhmuccha.Items.Clear();
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ListItem item = new ListItem();
            item.Text = dt.Rows[i]["tendm"].ToString();
            item.Value = dt.Rows[i]["madm"].ToString();
            drDanhmuccha.Items.Add(new ListItem(dt.Rows[i]["tendm"].ToString(), dt.Rows[i]["madm"].ToString()));

            //Hàm lấy danh mục con
            LayDanhMucCon(dt.Rows[i]["MaDM"].ToString(), "____");
        }

    }

    private void LayDanhMucCon(string MaDMCha, string khoangCach)
    {
        DataTable dt = new DataTable();
        dt = Big_ProJect.ThongTinDanhMucByMaDMcha.Thongtin_danhmuc_by_MaDMCha(MaDMCha);

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ListItem item = new ListItem();
            item.Text = dt.Rows[i]["tendm"].ToString();
            item.Value = dt.Rows[i]["madm"].ToString();
            drDanhmuccha.Items.Add(new ListItem(khoangCach + dt.Rows[i]["tendm"].ToString(), dt.Rows[i]["madm"].ToString()));

            //Hàm lấy danh mục con
            LayDanhMucCon(dt.Rows[i]["MaDM"].ToString(), khoangCach + "____");
        }
    }

    protected void drDanhmuccha_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    private void ResetControl()
    {
        txtMota.Text = " ";
        txtTensp.Text = " ";
        txtSoluong.Text = " ";
        txtNgaytao.Text = DateTime.Now.ToString("MM/dd/yyyy");
        txtNgayhuy.Text = DateTime.Now.ToString("MM/dd/yyyy");
    }
    protected void btnhuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }
}