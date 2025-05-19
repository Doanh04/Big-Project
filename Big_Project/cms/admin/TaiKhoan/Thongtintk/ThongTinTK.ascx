<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThongTinTK.ascx.cs" Inherits="cms_admin_TaiKhoan_Thongtintk_ThongTinTK" %>
<h2>Quản lý tài khoản</h2>

<link href="../../../display/TaiKhoan/QuanLyTK.css" rel="stylesheet" />
<div class="category-control shadow-sm p-3 bg-white rounded">
    <div class="d-flex justify-content-between align-items-center mb-3">
        <h4 class="mb-0"><i class="fas fa-list"></i> Danh sách tài khoản</h4>
        <div>
            <a href="/Admin.aspx?module=tk&tk=dktk" class="btn btn-success btn-sm">
                <i class="fas fa-plus"></i> Thêm tài khoản
            </a>
            <button class="btn btn-danger btn-sm" onclick="confirmDeleteAll()">
                <i class="fas fa-trash"></i> Xóa tất cả
            </button>
        </div>
    </div>
   <div class="ovfl">
    <table class="table table-bordered table-hover table-sm text-center">
        <thead class="thead-light">
            <tr>
                      <td><i class="fas fa-user"></i> Tên đăng nhập</td>
                      <td><i class="fas fa-envelope"></i> Email</td>
                      <td><i class="fas fa-id-card"></i> Họ tên</td>
                      <td><i class="fas fa-calendar-alt"></i> Ngày sinh</td>
                      <td><i class="fas fa-venus-mars"></i> Giới tính</td>
                      <td><i class="fas fa-clock"></i> Trạng thái tài khoản</td>
                      <td><i class="fas fa-tools"></i> Công cụ</td>
            </tr>
        </thead>
        <tbody>
            <asp:Literal ID="ltrTaikhoan" runat="server"></asp:Literal>
        </tbody>
    </table>
       </div>
</div>