<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<%@ Register Src="~/cms/admin/AdminLoad.ascx" TagPrefix="uc1" TagName="AdminLoad" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hệ Thống Quản Lý WebSite CAKE & CANDY</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css"/>
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <link href="cms/admin/CSS/base.css" rel="stylesheet" />
    <link href="cms/admin/CSS/admin.css" rel="stylesheet" />
    <link href="cms/display/CSSSanPham/SanPham.css" rel="stylesheet" />
    <link href="cms/display/CSSTrangChu/Trangchu.css" rel="stylesheet" />
    <link href="cms/display/HTTT/HTTT.css" rel="stylesheet" />
    <link href="cms/display/TaiKhoan/TaiKhoanCSS.css" rel="stylesheet" />
    <link href="cms/display/LienHe/LienHeCSS.css" rel="stylesheet" />
    <link href="cms/admin/SanPham/AddDmsp/addDMSP.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div class="contaier:fluid header">
                <div class="logo-img">
                    <img src="cms/admin/img/Logo.png" />
                </div>
                <div class="menu">
                    <ul class="menu-list">
                        <li><a href="/Admin.aspx?module=trangchu">Trang chủ</a></li>
                        <li><a href="/Admin.aspx?module=sp">Sản Phẩm</a></li>
                        <li><a href="/Admin.aspx?module=mn">Menu</a></li>
                        <li><a href="/Admin.aspx?module=httt">Hỗ trợ trực tuyến</a></li>
                        <li><a href="/Admin.aspx?module=lh">Liên Hệ</a></li>
                        <li><a href="/Admin.aspx?module=tk">Tài Khoản</a></li>
                        <li><a href="/Admin.aspx?module=nd">Nội dung</a></li>
                    </ul>
                </div>
                <div class="accout">
                    <p>Xin Chào: </p>
                </div>
            </div>
        </header>
        <div class="backtop">

        </div>
        <uc1:AdminLoad runat="server" ID="AdminLoad" />
    </form>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>

</body>
</html>
