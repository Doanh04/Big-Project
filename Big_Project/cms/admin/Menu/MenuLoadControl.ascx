<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MenuLoadControl.ascx.cs" Inherits="cms_admin_Menu_MenuLoadControl" %>
    <style>
        body {
            background-color: #f8f9fa;
            height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
        }

        .error-container {
            text-align: center;
            max-width: 500px;
            padding: 40px;
            background-color: white;
            border-radius: 15px;
            box-shadow: 0 5px 15px rgba(0,0,0,0.1);
        }

        .error-code {
            font-size: 72px;
            font-weight: bold;
            color: #dc3545;
        }

        .error-icon {
            font-size: 48px;
            color: #ffc107;
        }

        .btn-home {
            margin-top: 20px;
        }
        .backtop{
            display:none;
        }
    </style>
<div class="error-container">
        <div class="error-icon">
            <i class="fas fa-exclamation-triangle"></i>
        </div>
        <div class="error-code">404</div>
        <h4>Trang này chưa có gì cả!</h4>
        <p>Trang bạn đang tìm kiếm hiện không tồn tại hoặc chưa được xây dựng.</p>
        <a href="/Admin.aspx?module=trangchu" class="btn btn-primary btn-home">
            <i class="fas fa-home"></i> Quay về trang chủ
        </a>
</div>