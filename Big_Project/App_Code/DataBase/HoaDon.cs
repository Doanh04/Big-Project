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
    public class HoaDon
    {
        //PHƯƠNG THỨC XÓA DỮ LIỆU HÓA ĐƠN THEO MÃ HÓA ĐƠN ĐƯỢC TRUYỀN VÀO
        public static void Hoadon_delete(
                                         string mahoadon
            )
        {
            OleDbCommand cmd = new OleDbCommand("hoadon_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahoadon", mahoadon);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC THÊM MỚI DỮ LIỆU VÀO BẢNG HÓA ĐƠN
        public static void Hoadon_inser(
                                        string ngaylap,
                                        string thanhtien,
                                        string manv,
                                        string tennv,
                                        string makh,
                                        string tenkh,
                                        string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("hoadon_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ngaylap", ngaylap);
            cmd.Parameters.AddWithValue("@thanhtien", thanhtien);
            cmd.Parameters.AddWithValue("@manv", manv);
            cmd.Parameters.AddWithValue("@tennv", tennv);
            cmd.Parameters.AddWithValue("@makh", makh);
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC UPDATE DỮ LIỆU VÀO BẢNG HÓA ĐƠN
        public static void hoadon_update(
                                         string mahoadon,        
                                         string ngaylap,        
                                         string thanhtien,        
                                         string manv,        
                                         string tennv,        
                                         string makh,        
                                         string tenkh
            )
        {
            OleDbCommand cmd = new OleDbCommand("hoadon_update");
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahoadon", mahoadon);
            cmd.Parameters.AddWithValue("@ngaylap", ngaylap);
            cmd.Parameters.AddWithValue("@thanhtien", thanhtien);
            cmd.Parameters.AddWithValue("@manv", manv);
            cmd.Parameters.AddWithValue("@tennv", tennv);
            cmd.Parameters.AddWithValue("@makh", makh);
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC TRUY XUẤT TOÀN BỘ DỮ LIỆU TRONG BẢNG
        public DataTable Thongtin_hoadon()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_hoadon");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
    }
}