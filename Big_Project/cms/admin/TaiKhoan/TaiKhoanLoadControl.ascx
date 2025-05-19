<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TaiKhoanLoadControl.ascx.cs" Inherits="cms_admin_TaiKhoan_TaiKhoanLoadControl" %>
<style>
    .section-TaiKhoan {
    background-color: #ffc0cb;
    border-radius: 20px;
    padding: 20px;
    color: white;
}

.qltk {
    list-style: none;
    padding-left: 0;
    margin-top: 20px;
}

.qltk li a {
    display: block;
    padding: 12px;
    margin-bottom: 10px;
    background-color: #f8a1b1;
    border-radius: 10px;
    color: white;
    text-decoration: none;
    transition: all 0.3s ease;
}

.qltk li a:hover {
    transform: translateY(-5px);
    background-color: #f06292;
}

.subcontrol-wrapper {
    background-color: #fff0f5;
    padding: 20px;
    margin-top:20px;
    border-radius: 30px;
    min-height: 80vh;
    width:160vh;
    box-shadow: 0 0 10px rgba(0,0,0,0.1);
}
.left{
    max-width:300px;
}
</style>
<div class="container-fluid">

    <div class="row">
        <!-- Menu tài khoản bên trái -->
        <div class="col-md-4 left">
            <div class="section-TaiKhoan">
                <h3><i class="fas fa-users-cog"></i> Quản lý Tài Khoản</h3>
                <ul class="qltk">
                    <li><a href="/Admin.aspx?module=tk&tk=dktk"><i class="fas fa-user-plus"></i> Đăng ký tài khoản admin</a></li>
                    <li><a href="/Admin.aspx?module=tk&tk=tttk"><i class="fas fa-id-badge"></i> Thông tin tài khoản</a></li>
                </ul>
            </div>
        </div>

        <!-- Khu vực nội dung động bên phải -->
        <div class="col-md-8">
            <div class="subcontrol-wrapper">
                <asp:PlaceHolder ID="pldtk" runat="server"></asp:PlaceHolder>
            </div>
        </div>
    </div>
</div>

