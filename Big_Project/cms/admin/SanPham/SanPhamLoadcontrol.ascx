<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SanPhamLoadcontrol.ascx.cs" Inherits="cms_admin_SanPham_SanPhamLoadcontrol" %>
<link href="../../display/CSSSanPham/SanPham.css" rel="stylesheet" />
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
/* Vùng chứa control */
.section-qlsp, .section-add {
    background-color: #ffe3ec; /* Light pink */
    padding: 20px;
    margin: 10px 0;
    border-radius: 16px;
    width: 250px;
}
.col-md-4{
    max-width:300px;
}
/* Tiêu đề */
.section-qlsp h3,
.section-add h3 {
    font-size: 20px;
    color: #d6336c; /* Hồng đậm hơn để tạo nhấn */
    margin-bottom: 15px;
}

/* Danh sách ul */
.qlsp, .add {
    list-style: none;
    padding-left: 0;
    margin: 0;
}

/* Các link trong danh sách */
.qlsp li a,
.add li a {
    display: block;
    padding: 10px 15px;
    margin-bottom: 10px;
    background-color: #ffccd5;
    color: white;
    border-radius: 8px;
    text-decoration: none;
    transition: all 0.3s ease;
    font-weight: 500;
}

/* Hover + Focus */
.qlsp li a:hover,
.add li a:hover,
.qlsp li a:focus,
.add li a:focus {
    background-color: #fa8ea0; /* Màu hồng sáng hơn khi hover/focus */
    color: #fff;
    transform: translateX(5px); /* Di chuyển nhẹ khi hover */
    box-shadow: 0 4px 10px rgba(250, 140, 160, 0.3);
}

.section-qlsp, .section-add {
    background-color: #ffc0cb; /* light pink */
    border-radius: 20px;
    padding: 20px;
    margin-bottom: 20px;
    color: white;
}

.section-qlsp ul li a,
.section-add ul li a {
    display: block;
    padding: 12px;
    margin-bottom: 10px;
    background-color: #f8a1b1;
    border-radius: 10px;
    color: white;
    text-decoration: none;
    transition: all 0.3s ease;
}

.section-qlsp ul li a:hover,
.section-add ul li a:hover {
    transform: translateY(-5px);
    background-color: #f06292;
}

.subcontrol-wrapper {
    margin-top:20px;
    background-color: #fff0f5;
    padding: 20px;
    border-radius: 30px;
    min-height: 80vh;
    width:160vh;
    box-shadow: 0 0 10px rgba(0,0,0,0.1);
}

</style>
<div class="container-fluid">
    <div class="row">
        <!-- Cột bên trái -->
        <div class="col-md-4">
            <div class="section-qlsp">
                <h3>Quản lý sản phẩm</h3>
                <ul class="qlsp">
                    <li><a href="/Admin.aspx?module=sp&md2=qlnsp">Nhóm sản phẩm</a></li>
                    <li><a href="/Admin.aspx?module=sp&md2=qlsp">Danh Sách sản phẩm</a></li>
                    <li><a href="/Admin.aspx?module=sp&md2=qldmsp">Danh mục sản phẩm</a></li>
                </ul>
            </div>
            <div class="section-add">
                <h3>Thêm mới</h3>
                <ul class="add">
                    <li><a href="/Admin.aspx?module=sp&md2=addNsp">Nhóm sản phẩm</a></li>
                    <li><a href="/Admin.aspx?module=sp&md2=addSp">Danh sách sản phẩm</a></li>
                    <li><a href="/Admin.aspx?module=sp&md2=addDmsp">Danh mục sản phẩm</a></li>
                </ul>
            </div>
        </div>

        <!-- Cột bên phải: chứa nội dung động -->
        <div class="col-md-8">
            <div class="subcontrol-wrapper">
                <asp:PlaceHolder ID="pldSp" runat="server"></asp:PlaceHolder>
            </div>
        </div>
    </div>
</div>
