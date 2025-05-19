<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
    <link href="style/login.css" rel="stylesheet" />
    <link href="cms/admin/CSS/login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <h2>Đăng nhập hệ thống quản trị
            </h2>
            <div class="form-group">
                <label for="txtUsername">Tên đăng nhập</label>
                <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" />
            </div>
            <div class="form-group">
                <label for="txtPassword">Mật khẩu</label>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" />
            </div>
            <asp:Button ID="btnLogin" runat="server" Text="Đăng nhập" OnClick="btnLogin_Click" />
            <div class="thongbao">
                <asp:Literal ID="ltrMessage" runat="server" EnableViewState="false" />
            </div>
        </div>
    </form>
</body>
</html>
