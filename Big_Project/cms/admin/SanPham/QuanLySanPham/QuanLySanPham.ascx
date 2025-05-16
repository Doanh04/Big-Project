<%@ Control Language="C#" AutoEventWireup="true" CodeFile="QuanLySanPham.ascx.cs" Inherits="cms_admin_SanPham_QuanLySanPham_QuanLySanPham" %>
<style>
    .category-control {
        font-size: 14px;
    }

    .category-control table img.img-sm {
        width: 50px;
        height: 50px;
        object-fit: cover;
        border-radius: 8px;
    }

    .category-control .badge {
        font-size: 12px;
        padding: 4px 8px;
    }

    .category-control .table th i {
        margin-right: 5px;
        color: #6c757d;
    }
    .img{
        width:40px;
        height:40px;
        transition: all 0.5s ease;
    }
    .img:hover{
    width:300px;
    height:300px
        }
    .category-control{
        margin-bottom:50px;
    }
    .ovfl{
        height:600px;
        overflow:auto;
        margin-top:20px;
    }
</style>
<div class="category-control shadow-sm p-3 bg-white rounded">
    <div class="d-flex justify-content-between align-items-center mb-3">
        <h4 class="mb-0"><i class="fas fa-list"></i> Danh sách sản phẩm</h4>
        <div>
            <a href="/Admin.aspx?module=sp&md2=addSp" class="btn btn-success btn-sm">
                <i class="fas fa-plus"></i> Thêm Sản Phẩm
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
                    <td><i class="fas fa-barcode"></i> Mã</td>
                    <td><i class="fas fa-tag"></i> Tên sản phẩm</td>
                    <td><i class="fas fa-image"></i> Ảnh</td>
                    <td><i class="fas fa-boxes"></i> Số lượng</td>
                    <td><i class="fas fa-dollar-sign"></i> Giá bán</td>
                    <td><i class="fas fa-calendar-plus"></i> Ngày tạo</td>
                    <td><i class="fas fa-toggle-on"></i> Trạng thái</td>
                    <td><i class="fas fa-tools"></i> Công cụ</td>
            </tr>
        </thead>
        <tbody>
            <asp:Literal ID="ltrSanPham" runat="server"></asp:Literal>
        </tbody>
    </table>
       </div>
</div>
<script type="text/javascript">
    function XoaDanhMuc(MaDM) {
        console.log("XoaDanhMuc được gọi với MaDM:", MaDM); 

        if (confirm("Bạn có muốn xóa danh mục này?")) {
            $.post("cms/admin/SanPham/QuanLyDanhMucSanPham/ajax/DanhMuc.aspx",
                {
                    "ThaoTac": "XoaDanhMuc",
                    "MaDM": MaDM
                },
                function (data, status) {
                    console.log("Kết quả ajax:", data, status); 

                    if (data == 1 || data.trim() == "1") {
                        $("#maDong_" + MaDM).slideUp();
                    } else {
                        alert("Xoá không thành công hoặc không nhận được phản hồi đúng.");
                    }
                });
        }
    }

</script>