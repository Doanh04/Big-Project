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
    public class DanhMuc
    {
        //PHƯƠNG THỨC XÓA XỨ LIỆU BẢNG DANH MỤC THEO MÃ DANH MỤC KÉO THÉO XÓA CẢ SẢN PHẨM THEO MÃ DANH MỤC
        public static void Danhmuc_delete(string madm)
        {
            OleDbCommand cmd = new OleDbCommand("danhmuc_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madm", madm);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC THÊM DỮ LIỆU MỚI VÀO BẢNG DANH MỤC
        public static void Danhmuc_inser(
                                         string tendm,
                                         string anhdaidien,
                                         string thutu,
                                         string maDMcha,
                                         string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("danhmuc_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tendm", tendm);
            cmd.Parameters.AddWithValue("@anhdaidien", anhdaidien);
            cmd.Parameters.AddWithValue("@thutu", thutu);
            cmd.Parameters.AddWithValue("@maDMcha", maDMcha);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery (cmd);
        }
        //PHƯƠNG THỨC UPDATE DỮ LIỆU VÀO BẢNG SẢN PHẨM
        public static void Danhmuc_update(
                                         string madm,
                                         string tendm,
                                         string anhdaidien,
                                         string thutu,
                                         string maDMcha
            )
        {
            OleDbCommand cmd = new OleDbCommand("danhmuc_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madm", madm);
            cmd.Parameters.AddWithValue("@tendm", tendm);
            cmd.Parameters.AddWithValue("@anhdaidien", anhdaidien);
            cmd.Parameters.AddWithValue("@thutu", thutu);
            cmd.Parameters.AddWithValue("@maDMcha", maDMcha);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC XEM TOÀN BỘ DỮ LIỆU TRONG BẢNG
        public static DataTable Thongtin_danhmuc()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmuc");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
    }
}