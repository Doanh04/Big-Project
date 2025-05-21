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
    public class KhachHang
    {
        //PHƯƠNG THỨC XÓA DỮ LIỆU KHÁCH HÀNG THEO MÃ KH
        public static void Khachang_delete(
                                           string makh
            )
        {
            OleDbCommand cmd = new OleDbCommand("khachang_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makh", makh);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC THÊM MỚI DỮ LIỆU VÀO BẢNG KHÁCH HÀNG
        public static void Khachang_inser(
                                          string tenkh,
                                          string diachikh,
                                          string sdtkh,
                                          string emailkh,
                                          string matkhau,
                                          string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("khachang_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@diachikh", diachikh);
            cmd.Parameters.AddWithValue("@sdtkh", sdtkh);
            cmd.Parameters.AddWithValue("@emailkh", emailkh);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC UPDATE DỮ LIỆU VÀO BẢNG KHÁCH HÀNG
        public static void Khachang_update(
                                           string @makh,
                                           string @tenkh,
                                           string @diachikh,
                                           string @sdtkh,
                                           string @emailkh,
                                           string @matkhau
            )
        {
            OleDbCommand cmd = new OleDbCommand("khachang_update");
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@makh", makh);
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@diachikh", diachikh);
            cmd.Parameters.AddWithValue("@sdtkh", sdtkh);
            cmd.Parameters.AddWithValue("@emailkh", emailkh);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            SQLDatabase.ExecuteNoneQuery (cmd);
        }
        //PHƯƠNG THỨC LẤY TOÀN BỘ DỮ LIỆU TRONG BẢNG KHÁCH HÀNG
        public static DataTable Thongtin_khachhang()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_khachhang");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }

    }
}