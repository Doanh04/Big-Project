using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Big_ProJect{
    public class ChiTietDonHang
    {   //PHƯƠNG THỨC XÓA DỮ LIỆU THEO MÃ SẢN PHẨM VÀ MÃ HÓA ĐƠN ĐƯỢC TRUYỀN VÀO
        public static void Chitietdonhang_delete(string masp,
                                                 string mahoadon)
        {
            OleDbCommand cmd = new OleDbCommand("chitietdonhang_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@mahoadon", mahoadon);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC THÊM MỚI DỮ LIỆU VÀO BẢNG CHI TIẾT ĐƠN HÀNG
        public static void Chitietdonhang_inser(string masp,
                                                string mahoadon,
                                                string soluong,
                                                string dongia,
                                                string ret)
        {
            OleDbCommand cmd = new OleDbCommand("Chitietdonhang_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@mahoadon", mahoadon);
            cmd.Parameters.AddWithValue("@soluong", soluong);
            cmd.Parameters.AddWithValue("@dongia", dongia);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC UPDATE DỮ LIỆU VÀO BẢNG CHI TIẾT ĐƠN HÀNG
        public static void Chitietdonhang_update(
                                                 string masp,
                                                 string mahoadon,
                                                 string soluong,
                                                 string dongia
            
            )
        {
            OleDbCommand cmd = new OleDbCommand("chitietdonhang_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@mahoadon", mahoadon);
            cmd.Parameters.AddWithValue("@soluong", soluong);
            cmd.Parameters.AddWithValue("@dongia", dongia);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC XEM TOÀN BỘ DỮ LIỆU TRONG BẢNG
        public DataTable Thongtin_chitietdonhang()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_chitietdonhang");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
    }
}