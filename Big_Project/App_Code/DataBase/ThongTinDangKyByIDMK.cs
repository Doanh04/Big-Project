using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Big_ProJect
{
    public class ThongTinDangKyByIDMK
    {
        //HÀM TÌM KIẾM THÔNG TIN TÀI KHOẢN BẰNG ID VÀ MẬT KHẨU TRONG BẢNG ĐĂNG KÝ
       public static void Thongtin_dangky_by_id_matkhau(string TenDangNhap, string MatKhau)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dangky_by_id_matkhau");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            SQLDatabase.GetData(cmd);
        }
    }
}