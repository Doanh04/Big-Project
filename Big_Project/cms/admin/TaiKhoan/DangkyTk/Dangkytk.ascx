<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Dangkytk.ascx.cs" Inherits="cms_admin_TaiKhoan_DangkyTk_Dangkytk" %>
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
    <p>Thêm mới và chỉnh sửa tài khoản</p>
</div>
<div class="form-add container:fluid">
    <asp:Literal ID="ltrthongbao" runat="server"></asp:Literal>
    <div class="thongtin row">
        <div class="tenTruong col-xl-6">
             Chọn quyền
        </div>
        <div class="oNhap col-xl-6">
            <asp:DropDownList ID="drDanhmucquyen" runat="server" OnSelectedIndexChanged="drDanhmuccha_SelectedIndexChanged"></asp:DropDownList>
        </div>
    </div>
    <div class="thongtin row">
        <div class="tenTruong col-xl-6">
            Tên tài khoản
        </div>
        <div class="oNhap col-xl-6">
            <asp:TextBox ID="txtTentaikhoan" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="thongtin row">
        <div class="tenTruong col-xl-6">
            Mật khẩu
        </div>
        <div class="oNhap col-xl-6">
            <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox> 
        </div>
     </div>
    <div class="thongtin row">
        <div class="tenTruong col-xl-6">
            Email đăng ký
        </div>
        <div class="oNhap col-xl-6">
            <asp:TextBox ID="txtemail" runat="server"></asp:TextBox> 
        </div>
    </div>
    <div class="thongtin row">
        <div class="tenTruong col-xl-6">
            Họ tên
        </div>
        <div class="oNhap col-xl-6">
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox> 
        </div>
    </div>
    <div class="thongtin row">
        <div class="tenTruong col-xl-6">
            Ngày sinh
        </div>
        <div class="oNhap col-xl-6">
            <asp:TextBox ID="txtNgaysinh" runat="server"></asp:TextBox> 
        </div>
    </div>
    <div class="thongtin row">
        <div class="tenTruong col-xl-6">
            Giới tính
        </div>
        <div class="oNhap col-xl-6">
            <asp:DropDownList ID="ddlGioitinh" runat="server">
                <asp:ListItem Text="Nam" Value="Nam"></asp:ListItem>
                <asp:ListItem Text="Nữ" Value="Nữ"></asp:ListItem>
            </asp:DropDownList>
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