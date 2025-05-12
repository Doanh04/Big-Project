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
    public class NhomSanPham
    {
        //PHƯƠNG THỨC XÓA NHÓM SẢN PHẨM THEO NHÓM ID
        public static void Nhomsanpham_delete(string nhomid)
        {
            OleDbCommand cmd = new OleDbCommand("nhomsanpham_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nhomid", nhomid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC TẠO DỮ LIỆU MỚI CHO BẢNG NHÓM SẢN PHẨM
        public static void Nhomsanpham_inser(
                                             string tennhom,
                                             string anhdaidien,
                                             string thutu,
                                             string soSPhienthi,
                                             string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("nhomsanpham_inser");
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tennhom", tennhom);
            cmd.Parameters.AddWithValue("@anhdaidien", anhdaidien);
            cmd.Parameters.AddWithValue("@thutu", thutu);
            cmd.Parameters.AddWithValue("@soSPhienthi", soSPhienthi);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC UPDATE DỮ LIỆU VÀO BẢNG NHOM SẢN PHẨM
        public static void Nhomsanpham_update(
                                              string @nhomid,
                                              string @tennhom,
                                              string @anhdadien,
                                              string @thutu,
                                              string @solanhienthi
            )
        {
            OleDbCommand cmd = new OleDbCommand("nhomsanpham_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nhomid", nhomid);
            cmd.Parameters.AddWithValue("@tennhom", tennhom);
            cmd.Parameters.AddWithValue("@anhdadien", anhdadien);
            cmd.Parameters.AddWithValue("@thutu", thutu);
            cmd.Parameters.AddWithValue("@solanhienthi", solanhienthi);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC LẤT TẤT CẢ DỮ LIỆU TRONG BẢN NHOM SẢN PHẨM
        public DataTable Thongtin_nhomsp()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_nhomsp");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
    }
}