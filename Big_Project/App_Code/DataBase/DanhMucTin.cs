using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Web;


namespace Big_ProJect { 
    public class DanhMucTin
    {
        //PHƯƠNG THỨC XÓA IN TỨC VÀ DANH MỤC TIN THEO MÃ DANH MỤC
        public static void Danhmuctin_delete(
                                             string madm
            )
        {
            OleDbCommand cmd = new OleDbCommand("danhmuctin_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madm", madm);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC THÊM MỚI DỮ LIỆU VÀO BẢNG DANH MỤC TIN
        public static void Danhmuctin_inser(
                                            string tendm,
                                            string anhdaidien,
                                            string thutu,
                                            string maDMcha,
                                            string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("danhmuctin_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tendm", tendm);
            cmd.Parameters.AddWithValue("@anhdaidien", anhdaidien);
            cmd.Parameters.AddWithValue("@thutu", thutu);
            cmd.Parameters.AddWithValue("@maDMcha", maDMcha);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THÍCH UPDATE DỮ LIỆU VÀO DANH MỤC TIN
        public static void Danhmuctin_update(
                                            string madm,
                                            string tendm,
                                            string anhdaidien,
                                            string thutu,
                                            string maDMcha
            )
        {
            OleDbCommand cmd = new OleDbCommand("danhmuctin_update");
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madm", madm);
            cmd.Parameters.AddWithValue("@tendm", tendm);
            cmd.Parameters.AddWithValue("@anhdaidien", anhdaidien);
            cmd.Parameters.AddWithValue("@thutu", thutu);
            cmd.Parameters.AddWithValue("@maDMcha", maDMcha);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC LẤY VÀ XEM TOÀN BỘ DỮ LIỆU TRONG BẢNG
        public DataTable Thongtin_danhmuctin()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmuctin");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
    }
}