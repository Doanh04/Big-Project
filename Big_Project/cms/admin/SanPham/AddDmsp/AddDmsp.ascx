<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddDmsp.ascx.cs" Inherits="cms_admin_SanPham_AddDmsp_AddDmsp" %>
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
    <p>Thêm mới và chỉnh sửa danh mục sản phẩm</p>
</div>
<div class="form-add container:fluid">
    <asp:Literal ID="ltrthongbao" runat="server"></asp:Literal>
    <div class="thongtin row">
        <div class="tenTruong col-xl-6">
             Danh mục cha
        </div>
        <div class="oNhap col-xl-6">
            <asp:DropDownList ID="drDanhmuccha" runat="server" OnSelectedIndexChanged="drDanhmuccha_SelectedIndexChanged"></asp:DropDownList>
        </div>
    </div>
    <div class="thongtin row">
        <div class="tenTruong col-xl-6">
            Tên danh mục
        </div>
        <div class="oNhap col-xl-6">
            <asp:TextBox ID="txtTendanhmuc" runat="server"></asp:TextBox>
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
            Thứ tự
        </div>
        <div class="oNhap col-xl-6">
            <asp:TextBox ID="txtMota" runat="server"></asp:TextBox> 
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