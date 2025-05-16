using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Big_ProJect { 
    public class QuyenDangNhap
    {
        //PHƯƠNG THỨC XÓA QUYỀN ĐĂNG NHẬP THEO MÃ QUYỀN ĐĂNG NHẬP
        public static void Quyendangnhap_delete(string quyenid)
        {
            OleDbCommand cmd = new OleDbCommand("quyendangnhap_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@quyenid", quyenid);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC TẠO DỮ LIỆU MỚI CHO BẢNG QUYỀN ĐĂNG NHẬP
        public static void Quyendangnhap_inser(string tenquyen, string ret)
        {
            OleDbCommand cmd = new OleDbCommand("quyendangnhap_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenquyen", tenquyen);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC UPDATE DỮ LIỆU VÀO BẢNG QUYỀN ĐĂNG NHẬP
        public static void Quyendangnhap_update(string maquyen, string tenquyen)
        {
            OleDbCommand cmd = new OleDbCommand("quyendangnhap_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maquyen", maquyen);
            cmd.Parameters.AddWithValue("@tenquyen", tenquyen);
        }
        //PHƯƠNG THỨC LẤY TẤT CẢ DỮ LIỆU TRONG BẢNG QUYỀN ĐĂNG NHẬP
        public DataTable Thongtin_quyendangnhap()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_quyendangnhap");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
    }
}