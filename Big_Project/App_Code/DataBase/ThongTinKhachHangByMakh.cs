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
    public class ThongTinKhachHangByMakh
    {
        //HÀM TÌM KIẾM THÔNG TIN KHÁCH HÀNG BẰNG MÃ KHÁCH HÀNG
        public static void Thongtin_khachhang_by_makh(string makh)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_khachhang_by_makh");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makh", makh);
            SQLDatabase.GetData(cmd);
        }
    }
}