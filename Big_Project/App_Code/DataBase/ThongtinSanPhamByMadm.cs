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
    public class ThongtinSanPhamByMadm
    {
        //HÀM TÌM KIẾM THÔNG TIN SẢN PHẨM BẰNG MÃ DANH MỤC
        public static void Thongtin_sanpham_by_madm(string Madm)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_by_madm");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMD", Madm);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
    }
}