<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TrangChu.ascx.cs" Inherits="cms_default_TrangChu_TrangChu" %>
<style>
    .carousel-inner {
  height: 500px; 
    background-color: transparent; 
    margin-top:40px;
}

.carousel-item img {
  width: 100%;
  height: 100%;
  object-fit: cover;
  display: block;
}

.inner-title{
    text-align:center;
    margin:30px;
    width:60%;
    position:relative;
    left:20%;
}
.inner-title h3{
    background-color:#F7DFDF;
    padding:15px 0;
    color:#D799BF;
    border-radius:50px;
}
.item {
    background-color: white;
    transition: transform 0.3s ease, box-shadow 0.3s ease;
    border-radius: 10px;
}

.item:hover {
    transform: translateY(-5px);
    box-shadow: 0 4px 12px rgba(0, 0, 0, 0.1);
}

.inner-titleSP {
    color: #DC4B86;
    text-decoration: none;
    font-size: 1.1rem;
}

.inner-titleSP:hover {
    color: #D799BF;
}

.desc,
.soluong {
    display: inline-block;
    width: 48%;
    font-weight: 500;
    margin-top: 5px;
}

.desc {
    text-align: left;
    font-weight:600;
    text-align:center;
}

.item a:last-child {
    display: block;
    margin: 10px auto 0;
    text-align: center;
    background-color: #DC4B86;
    color: white;
    padding: 6px 12px;
    border-radius: 5px;
    text-decoration: none;
    width: fit-content;
    transition: background-color 0.3s ease;
}

.item a:last-child:hover {
    background-color: #D799BF;
}
.img-fluid{
    width:205px;
    height:168px;
}
.item{
    height:300px;
    object-fit:cover;
}
.inner-titleSP {
    color: #DC4B86;
    text-decoration: none;
    font-size: 1.1rem;
    white-space: nowrap;         
    overflow: hidden;            
    text-overflow: ellipsis;    
    display: block;
}
.giohang a{
    position:relative;
    bottom:0px;
}
</style>
<div class="container">
    <div class="row">
        <div class="col-xl-12">
            <!-- Carousel tự động chuyển động sau mỗi 3 giây -->
            <div id="carouselBanner" class="carousel slide carousel-fade" data-bs-ride="carousel" data-bs-interval="3000">
              <div class="carousel-inner">
                <div class="carousel-item active">
                  <img src="../../../pic/default/banner1.png"" class="d-block w-100" alt="Banner 1">
                </div>
                <div class="carousel-item">
                  <img src="../../../pic/default/banner2.png" class="d-block w-100" alt="Banner 2">
                </div>
                <div class="carousel-item">
                  <img src="../../../pic/default/banner3.png" class="d-block w-100" alt="Banner 3">
                </div>
              </div>

              <!-- Nút điều hướng -->
              <button class="carousel-control-prev" type="button" data-bs-target="#carouselBanner" data-bs-slide="prev">
                <span class="carousel-control-prev-icon"></span>
              </button>
              <button class="carousel-control-next" type="button" data-bs-target="#carouselBanner" data-bs-slide="next">
                <span class="carousel-control-next-icon"></span>
              </button>
            </div>


        </div>
    </div>
</div>

<div class="container">
    <div class="row">
        <div class="sanpham">
            <asp:Literal ID="ltrNhomSP" runat="server"></asp:Literal>
        </div>
    </div>
</div>


