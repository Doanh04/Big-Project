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
    public class ThongTinSanPhamByTuKhoa
    {
        //HÀM TÌM KIẾM THÔNG TIN SẢN PHẨM BẰNG TỪ KHÓA  
        public static void Thongtin_sanpham_by_tukhoa(string TuKhoa)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_by_tukhoa");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TuKhoa", TuKhoa);
            SQLDatabase.GetData(cmd);
        }
    }
}