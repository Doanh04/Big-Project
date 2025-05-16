<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddSp.ascx.cs" Inherits="cms_admin_SanPham_AddSp_AddSp" %>
<style>
    .adDM-title{
        text-align:center;
        background-color:white;
        padding:10px 0;
        border-radius:30px;
    }
    .adDM-title p{
        font-size:20px;
        font-weight:700;
    }
    .adDM-title {
        text-align: center;
    }
</style>
<div class="adDM-title">
    <p>Thêm mới và chỉnh sửa sản phẩm</p>
</div>
<div class="form-add container:fluid">
    <asp:Literal ID="ltrthongbao" runat="server"></asp:Literal>
    <div class="thongtin row">
        <div class="tenTruong col-xl-6">
            Tên sản phẩm
        </div>
        <div class="oNhap col-xl-6">
            <asp:TextBox ID="txtTensp" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="thongtin row">
        <div class="tenTruong col-xl-6">
            <asp:HiddenField ID="hdTenAvtCu" runat="server" />
            Ảnh đại diện
        </div>
        <div class="oNhap col-xl-6">
            <div>
                <asp:Literal ID="ltrAvt" runat="server"></asp:Literal>
            </div>
            <asp:FileUpload ID="flAvt" runat="server" />
        </div>
     </div>
    <div class="thongtin row">
        <div class="tenTruong col-xl-6">
            Số lượng sản phẩm
        </div>
        <div class="oNhap col-xl-6">
            <asp:TextBox ID="txtSoluong" runat="server"></asp:TextBox> 
        </div>
     </div>
        <div class="thongtin row">
        <div class="tenTruong col-xl-6">
            Giá sản phẩm
        </div>
        <div class="oNhap col-xl-6">
            <asp:TextBox ID="txtGiasp" runat="server"></asp:TextBox> 
        </div>
     </div>
<div class="thongtin row">
        <div class="tenTruong col-xl-6">
            Mô tả sản phẩm
        </div>
        <div class="oNhap col-xl-6">
            <asp:TextBox ID="txtMota" runat="server" TextMode="MultiLine" Height="150px"></asp:TextBox> 
        </div>
     </div>
<div class="thongtin row">
        <div class="tenTruong col-xl-6">
           Ngày tạo sản phẩm
        </div>
        <div class="oNhap col-xl-6">
            <asp:TextBox ID="txtNgaytao" runat="server"></asp:TextBox> 
        </div>
     </div>
    <div class="thongtin row">
        <div class="tenTruong col-xl-6">
           Ngày Hủy sản phẩm
        </div>
        <div class="oNhap col-xl-6">
            <asp:TextBox ID="txtNgayhuy" runat="server"></asp:TextBox> 
        </div>
     </div>
        <div class="thongtin row">
        <div class="tenTruong col-xl-6">
             Danh mục sản phẩm
        </div>
        <div class="oNhap col-xl-6">
            <asp:DropDownList ID="drDanhmuccha" runat="server" OnSelectedIndexChanged="drDanhmuccha_SelectedIndexChanged"></asp:DropDownList>
        </div>
    </div>
    <div class="check">
        <asp:CheckBox ID="CheckBox1" runat="server" />
        Tiếp tục tạo thêm danh mục mới
    </div>
    <div class="butonADD">
        <asp:Button ID="tbnadd" runat="server" Text="Thêm mới" OnClick="tbnadd_Click" />
        <asp:Button ID="btnhuy" runat="server" Text="Hủy" OnClick="btnhuy_Click" />
    </div>
</div>