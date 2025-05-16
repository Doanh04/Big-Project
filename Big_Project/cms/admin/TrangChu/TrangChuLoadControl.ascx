<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TrangChuLoadControl.ascx.cs" Inherits="cms_admin_TrangChu_WebUserControl" %>
<style>
        body {
    background: linear-gradient(-45deg, #ffccd5, #ffe3ec, #ffc1d3, #ffe6f0);
    background-size: 400% 400%;
    animation: gradientBG 10s ease infinite;
}

@keyframes gradientBG {
    0% {background-position: 0% 50%;}
    50% {background-position: 100% 50%;}
    100% {background-position: 0% 50%;}
}
</style>
<div class="container load">
    <div class="row all d-flex flex-wrap justify-content-center">
        <div class="col-xl-3 inner-item">
            <a href="/Admin.aspx?module=sp"><i class="fas fa-box-open"></i><br>Quản lý sản phẩm</a>
        </div>
        <div class="col-xl-3 inner-item">
            <a href="/Admin.aspx?module=mn"><i class="fas fa-bars"></i><br>Quản lý menu</a>
        </div>
        <div class="col-xl-3 inner-item">
            <a href="/Admin.aspx?module=httt"><i class="fas fa-headset"></i><br>Hỗ trợ trực tuyến</a>
        </div>
        <div class="col-xl-3 inner-item">
            <a href="/Admin.aspx?module=lh"><i class="fas fa-phone"></i><br>Liên Hệ trực tuyến</a>
        </div>
        <div class="col-xl-3 inner-item">
            <a href="/Admin.aspx?module=tk"><i class="fas fa-user-cog"></i><br>Quản lý tài khoản</a>
        </div>
        <div class="col-xl-3 inner-item">
            <a href="/Admin.aspx?module=nd"><i class="fas fa-file-alt"></i><br>Nội dung website</a>
        </div>
    </div>
</div>
