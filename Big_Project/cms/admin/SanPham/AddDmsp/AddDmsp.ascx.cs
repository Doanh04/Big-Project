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

public partial class cms_admin_SanPham_AddDmsp_AddDmsp : System.Web.UI.UserControl
{
    public string thaotac = ""; 
    public string id = "";
    protected void Page_Load(object sender, EventArgs e)
    {
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
                txtTendanhmuc.Text = dt.Rows[0]["TenDM"].ToString();
                txtMota.Text = dt.Rows[0]["ThuTu"].ToString();
                ltrAvt.Text = "<img class='img' src='/pic/SanPham/" + dt.Rows[0]["AnhDaiDien"] + @"'/>";
                hdTenAvtCu.Value = dt.Rows[0]["AnhDaiDien"].ToString();
            }

        }
    }

    protected void tbnadd_Click(object sender, EventArgs e)
    {
        //Phần update danh mục
        if (thaotac == "chinhsua")
        {
            string TenAVT = "";
            
            if(flAvt.FileContent.Length > 0)
            {
                if (flAvt.FileName.EndsWith(".jpg") || flAvt.FileName.EndsWith(".jpeg") || flAvt.FileName.EndsWith(".png") || flAvt.FileName.EndsWith(".gif"))
                {
                    flAvt.SaveAs(Server.MapPath("~/pic/SanPham/") + flAvt.FileName);
                    TenAVT = flAvt.FileName;
                }
            }
            if(TenAVT == "")
            {
                TenAVT = hdTenAvtCu.Value;
            }
            Big_ProJect.DanhMuc.Danhmuc_update(id,txtTendanhmuc.Text, TenAVT, txtMota.Text, drDanhmuccha.SelectedValue);
            //Big_ProJect.DanhMuc.Danhmuc_update(txtTendanhmuc.Text, flAvt.FileName, txtMota.Text, drDanhmuccha.SelectedValue, " ");
            ltrthongbao.Text = "Đã cập nhật danh mục: " + txtTendanhmuc.Text;
        }
        else
        {
            //PHẦN THÊM MỚI DANH MỚI
            // Kiểm tra dữ liệu đầu vào
            string tenDanhMuc = txtTendanhmuc.Text.Trim();
            string moTa = txtMota.Text.Trim();
            string thuTu = drDanhmuccha.SelectedValue;
            string fileName = flAvt.FileName;

            // Biến lưu thông báo lỗi
            string thongBao = "";

            // Kiểm tra tên danh mục
            if (string.IsNullOrEmpty(tenDanhMuc))
            {
                thongBao += "Vui lòng nhập tên danh mục.<br/>";
            }

            // Kiểm tra thứ tự (hoặc danh mục cha)
            if (string.IsNullOrEmpty(thuTu))
            {
                thongBao += "Vui lòng chọn danh mục cha.<br/>";
            }

            // Kiểm tra ảnh đại diện
            if (flAvt.FileContent.Length == 0)
            {
                thongBao += "Vui lòng chọn ảnh đại diện.<br/>";
            }
            else if (!(fileName.EndsWith(".jpeg") || fileName.EndsWith(".jpg") || fileName.EndsWith(".png") || fileName.EndsWith(".gif")))
            {
                thongBao += "Chỉ chấp nhận ảnh có định dạng: .jpeg, .jpg, .png, .gif.<br/>";
            }

            // Nếu có lỗi thì hiển thị, không thực hiện thêm danh mục
            if (!string.IsNullOrEmpty(thongBao))
            {
                ltrthongbao.Text = "<span style='color:red'>" + thongBao + "</span>";
                return;
            }

            // Nếu không có lỗi thì lưu file và thêm danh mục
            string tenFile = Path.GetFileName(fileName);
            string path = Server.MapPath("~/pic/SanPham/");
            flAvt.SaveAs(path + tenFile);

            // Gọi hàm thêm dữ liệu
            Big_ProJect.DanhMuc.Danhmuc_inser(txtTendanhmuc.Text, flAvt.FileName, txtMota.Text, drDanhmuccha.SelectedValue, " ");
            ltrthongbao.Text = "Đã tạo danh mục: " + txtTendanhmuc.Text;
        }
    }
    private void LayDanhMucCha()
    {

        //Hàm lấy ra thông tin danh mục cấp cao nhất theo mã danh mục cha
        DataTable dt = new DataTable();
        dt = Big_ProJect.ThongTinDanhMucByMaDMcha.Thongtin_danhmuc_by_MaDMCha("0");
        drDanhmuccha.Items.Clear();
        drDanhmuccha.Items.Add(new ListItem("Danh mục gốc", "0"));
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ListItem item = new ListItem();
            item.Text = dt.Rows[i]["tendm"].ToString();
            item.Value = dt.Rows[i]["madm"].ToString();
            drDanhmuccha.Items.Add(new ListItem(dt.Rows[i]["tendm"].ToString(), dt.Rows[i]["madm"].ToString()));

            //Hàm lấy danh mục con
            LayDanhMucCon(dt.Rows[i]["MaDM"].ToString(),"____");
        }

    }

    private void LayDanhMucCon(string MaDMCha, string khoangCach)
    {
        DataTable dt = new DataTable();
        dt=Big_ProJect.ThongTinDanhMucByMaDMcha.Thongtin_danhmuc_by_MaDMCha(MaDMCha);

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            ListItem item = new ListItem();
            item.Text = dt.Rows[i]["tendm"].ToString();
            item.Value = dt.Rows[i]["madm"].ToString();
            drDanhmuccha.Items.Add(new ListItem(khoangCach+dt.Rows[i]["tendm"].ToString(), dt.Rows[i]["madm"].ToString()));

            //Hàm lấy danh mục con
            LayDanhMucCon(dt.Rows[i]["MaDM"].ToString(), khoangCach+"____");
        }
    }

    protected void drDanhmuccha_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    private void ResetControl()
    {
        txtMota.Text = " ";
        txtTendanhmuc.Text = " ";
    }
    protected void btnhuy_Click(object sender, EventArgs e)
    {
        ResetControl();
    }

    //HÀM UPDATE
   
}
