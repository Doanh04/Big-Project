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
    public class ChiTietDonDatHang
    {
        //PHƯƠNG THỨC XÓA CỘT CHI TIẾT ĐƠN HÀNG THEO MÃ ĐƠN ĐẶT HÀNG
        public static void Chitietdondathang_delete(string madondathang)
        {
            OleDbCommand cmd = new OleDbCommand("chitietdondathang_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("madondathang", madondathang);
        }

        //PHƯƠNG THỨC THÊM MỚI DỮ LIỆU VÀO BẢNG CHI TIẾT ĐƠN ĐẶT HÀNG
        public static void chitietdondathang_inser(string masp,
                                                   string madondathang,
                                                   string soluongdat,
                                                   string dongiadat,
                                                   string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("chitietdondathang_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue ("@masp", masp);
            cmd.Parameters.AddWithValue ("@madondathang", madondathang);
            cmd.Parameters.AddWithValue ("@soluongdat", soluongdat);
            cmd.Parameters.AddWithValue ("@dongiadat", dongiadat);
            cmd.Parameters.AddWithValue ("@ret", ret);
        }
        //PHƯƠNG THỨC UPDATE DỮ LIỆU VÀO BẢNG CHI TIẾT ĐƠN ĐẶT HÀNG
        public static void Chitietdondathang_update(
                                                   string masp,
                                                   string madondathang,
                                                   string soluongdat,
                                                   string dongiadat
            )
        {
            OleDbCommand cmd = new OleDbCommand("chitietdondathang_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@madondathang", madondathang);
            cmd.Parameters.AddWithValue("@soluongdat", soluongdat);
            cmd.Parameters.AddWithValue("@dongiadat", dongiadat);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        public DataTable Thongtin_chitietdondathang()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_chitietdondathang");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
    }
}