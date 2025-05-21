<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dkuser.aspx.cs" Inherits="dkuser" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng ký tài khoản</title>
    <meta charset="utf-8" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
    <style>
        body {
            background-color: #F7DFDF;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }

        .register-container {
            max-width: 500px;
            margin: 80px auto;
            background: white;
            padding: 30px;
            border-radius: 15px;
            box-shadow: 0 0 15px rgba(0,0,0,0.1);
        }

        h2 {
            text-align: center;
            color: #D94B86;
            margin-bottom: 30px;
        }

        .form-group label {
            font-weight: 600;
            color: #D799BF;
        }

        .form-control {
            border-radius: 10px;
        }

        .btn-register {
            background-color: #D94B86;
            color: white;
            border: none;
            transition: background-color 0.3s ease;
        }

        .btn-register:hover {
            background-color: #bf3b72;
        }

        .form-control:focus {
            outline: none;
            box-shadow: none;
            border-color: #d94b86;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="register-container">
            <h2>Đăng ký tài khoản</h2>
            <asp:Literal ID="ltrthongbao" runat="server"></asp:Literal>
            <div class="form-group">
                <label for="txtHoTen">Họ tên</label>
                <asp:TextBox ID="txtHoTen" runat="server" CssClass="form-control" Placeholder="Nhập họ tên" />
            </div>

            <div class="form-group">
                <label for="txtDiaChi">Địa chỉ</label>
                <asp:TextBox ID="txtDiaChi" runat="server" CssClass="form-control" Placeholder="Nhập địa chỉ" />
            </div>

            <div class="form-group">
                <label for="txtDienThoai">Số điện thoại</label>
                <asp:TextBox ID="txtDienThoai" runat="server" CssClass="form-control" Placeholder="Nhập số điện thoại" TextMode="Phone" />
            </div>

            <div class="form-group">
                <label for="txtEmail">Email</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Placeholder="Nhập email" TextMode="Email" />
            </div>

            <div class="form-group">
                <label for="txtMatKhau">Mật khẩu</label>
                <asp:TextBox ID="txtMatKhau" runat="server" CssClass="form-control" Placeholder="Nhập mật khẩu" TextMode="Password" />
            </div>

            <asp:Button ID="btnDangKy" runat="server" Text="Đăng ký" CssClass="btn btn-register btn-block" OnClick="btnDangKy_Click"/>
        </div>
    </form>
</body>
</html>
