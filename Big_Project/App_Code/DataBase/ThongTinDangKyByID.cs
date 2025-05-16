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

    public class ThongTinDangKyByID
    {
        //LẤY THÔNG TIN ĐĂNG KÝ BẰNG TÊN ĐĂNG NHẬP
        public static void Thongtin_dangky_by_id(string TenDangNhap)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dangky_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            SQLDatabase.GetData(cmd);
        }
    }
}