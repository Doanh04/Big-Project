<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="~/cms/default/DefaultLoad.ascx" TagPrefix="uc1" TagName="DefaultLoad" %>

<style>
footer {
    background-color: #f7dfdf;
    color: #333;
    padding: 40px 0;
    font-family: 'Segoe UI', sans-serif;
    font-size: 14px;
}

footer .title h4 {
    font-size: 18px;
    color: #dc4b86;
    margin-bottom: 15px;
}

footer .title p {
    margin: 0 0 8px;
    line-height: 1.6;
}

footer .title a {
    display: block;
    line-height: 5px;
/*    margin-bottom: 8px;*/
    color: #dc4b86;
    text-decoration: none;
    transition: color 0.3s ease;
}

footer .title a:hover {
    color: #d799bf;
}

footer .imgfooter {
    display: flex;
    gap: 10px;
    flex-wrap: wrap;
    margin-top: 10px;
}

footer .imgfooter a img {
    width: 32px;
    height: 32px;
    object-fit: contain;
    transition: transform 0.3s ease;
}

footer .imgfooter a:hover img {
    transform: scale(1.1);
}

@media (max-width: 768px) {
    footer .title {
        margin-bottom: 30px;
    }
}
.titleft{
    text-align:center;
    line-height:10px;
}
</style>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cake & Candy</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css"/>
    <link href="cms/default/CSS/default.css" rel="stylesheet" />
    <link rel="preload" as="image" href="../../../pic/default/banner1.png"/>
    <link rel="preload" as="image" href="../../../pic/default/banner2.png"/>
    <link rel="preload" as="image" href="../../../pic/default/banner3.png"/>

</head>
<body>
    <form id="form1" runat="server">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div class="giantrang">.</div>
                    <div class="top">
    Miễn phí vận chuyển cho đơn hàng từ <strong> 500k</strong>
    </div>
        <header>
            <div class="container:fluid">
                <div class="row">
                    <div class="col-xl-12 list-control">
                        <img class="logo" src="cms/admin/img/Logo.png" />
                        <div>.</div>
                        <ul class="list">
                            <li><a href="/Default.aspx?module=home">Trang chủ</a></li>
                            <li><a href="/Default.aspx?module=Quaybanhkeo">Quầy bánh kẹo</a></li>
                            <li><a href="/Default.aspx?module=Tudoanvat">Tủ đồ ăn vặt</a></li>
                            <li><a href="/Default.aspx?module=km">Khuyến mãi</a></li>
                            <li><a href="/Default.aspx?module=event">Tin tức và sự kiện</a></li>
                        </ul>
           <div class="right-group">
                        <!-- Button trigger modal -->
                        <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#staticBackdrop">
                           <i class="fa-solid fa-user"></i>
                        </button>

                                                <div class="Giohang">
                            <a href="#">
                              <i class="fas fa-shopping-cart"></i>
                            </a>
                        </div>
                            </div>
                    </div>
                </div>
                    
            </div>
        </header>
        <!-- modal -->
        <div class="contact1">
            <a href="https://www.facebook.com/">
              <img src="pic/default/facebook.png" />
            </a>
            </div>
        <div class="contact2">
            <a href="https://www.messenger.com/">
              <img src="pic/default/mess.png" />
            </a>
        </div>
        <div class="modal fade" id="staticBackdrop" data-backdrop="static" data-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
    
      <div class="modal-header">
        <h5 class="modal-title" id="staticBackdropLabel">Đăng nhập</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>

      <div class="modal-body">
        <div id="loginForm"">
          <div class="form-group">
            <label for="loginEmail">Email</label>
            <input ID="loginEmail" type="email" runat="server" class="form-control"   placeholder="Nhập email" required />
          </div>

          <div class="form-group">
            <label for="loginPassword">Mật khẩu</label>
            <input ID="loginPassword" type="password" class="form-control" runat="server" placeholder="Nhập mật khẩu" required />
          </div>
            
          <div class="form-group form-check">
            <input type="checkbox" class="form-check-input" id="rememberMe">
            <label class="form-check-label" for="rememberMe">Ghi nhớ đăng nhập</label>
          </div>
            <div class="dangky">
                Chưa có tài khoản ? <a href="dkuser.aspx">Đăng ký</a>
            </div>
        </div>
      </div>

      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Đóng</button>
        <asp:Button ID="btnDangNhap" runat="server" Text="Đăng nhập" CssClass="btn btn-primary" OnClick="btnDangNhap_Click"  />
          <asp:Literal ID="ltrthongbao" runat="server"></asp:Literal>
      </div>

    </div>
  </div>
</div>
        <uc1:DefaultLoad runat="server" ID="DefaultLoad" />
        <footer>
            <div class="container">
                <div class="row">
                    <div class="col-xl-3 title">
                        <h4>Bánh kẹo Ăn vặt ImNuts</h4>
                        <p>Chúng mình chuyên cung cấp, phân phối sỉ lẻ các sản phẩm:</p>
                        <p>🌿 Đồ ăn vặt</p>
                        <p>🌿 Bánh kẹo nhập khẩu</p>
                        <p>❤️ Thương mời mọi người ủng hộ Cake & Candy nha 🥰</p>
                    </div>
                    <div class="col-xl-3 title">
                        <h4>Thông tin liên hệ</h4>
                         <p>Địa chỉ: 27 Lê Văn Lương, Q. Thanh Xuân, TP. Hà Nội.</p>
                         <p>Điện thoại: 0865 393 278</p>
                         <p>Email: dgrunt04@gmail.com</p>
                    </div>
                    <div class="col-xl-3 title">
                         <h4>Hỗ trợ khách hàng</h4>
                        <a href="#">Tìm kiếm</a> <br />
                        <a href="#">Giới thiệu</a><br />
                        <a href="#">Chính sách đổi trả</a><br />
                        <a href="#">Chính sách bảo mật</a><br />
                        <a href="#">Điều khoản dịch vụ</a><br />
                        <a href="#">Liên hệ</a>
                    </div>
                    <div class="col-xl-3 title">
                        <h4>Chăm sóc khách hàng</h4>
                        <div class="imgfooter">
                             <a href="#"><img src="pic/default/fb.png" /></a>
                            <a href="#"><img src="pic/default/ig.png" /></a>
                            <a href="#"><img src="pic/default/shoppe.png" /></a>
                            <a href="#"><img src="pic/default/tiktok.png" /></a>
                        </div>
                    </div>
                </div>
            </div>
            <hr />
            <div class="titleft">
                <p>Website đang trong giai đoạn chạy thử nghiệm.</p>
                <p>Copyright © 2025 Hộ kinh doanh Bánh kẹo Ăn vặt Cake & Candy</p>
                <p>Mã số HKD: 8383347865-001 do Phòng Kinh tế - Kế hoạch và Đầu tư UBND TP.Hà Nội cấp lần đầu ngày 22/05/2025.</p>
            </div>
        </footer>
    </form>
    

    <script src="https://code.jquery.com/jquery-3.5.1.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
    <script src="cms/admin/js/modal.js"></script>
</body>
</html>
