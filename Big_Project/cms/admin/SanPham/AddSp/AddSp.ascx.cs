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
            if (thaotac == "chinhsua")
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
        if (thaotac == "chinhsua")
        {
            DataTable dt = new DataTable();

            dt = Big_ProJect.ThongTInDanhMucByID.Thongtin_danhmuc_by_id(id);

            if (dt.Rows.Count > 0)
            {
                drDanhmuccha.SelectedValue = dt.Rows[0]["MaDMCha"].ToString();
                txtTensp.Text = dt.Rows[0]["TenDM"].ToString();
                txtMota.Text = dt.Rows[0]["ThuTu"].ToString();
                ltrAvt.Text = "<img class='img' src='/pic/SanPham/" + dt.Rows[0]["AnhDaiDien"] + @"'/>";
                hdTenAvtCu.Value = dt.Rows[0]["AnhDaiDien"].ToString();
            }

        }
    }

    protected void tbnadd_Click(object sender, EventArgs e)
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
        if (string.IsNullOrEmpty(soLuongStr) )
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
        Big_ProJect.SanPham.Sanpham_Inser(txtTensp.Text, flAvt.FileName, txtSoluong.Text, txtGiasp.Text, txtMota.Text, txtNgaytao.Text, txtNgayhuy.Text,drDanhmuccha.SelectedValue," " );

        ltrthongbao.Text = "Đã thêm sản phẩm: " + tenSP;
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