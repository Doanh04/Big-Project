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
    public class DonDatHang
    {
        //PHƯƠNG THỨC XÓA ĐƠN ĐẶT HÀNG THEO MÃ ĐƠN HÀNG
        public static void Dondathang_delete(
                                             string madondathang
            )
        {
            OleDbCommand cmd = new OleDbCommand("dondathang_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madondathang", madondathang);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC THÊM MỚI DỮ LIỆU VÀO BẢNG ĐƠN ĐẶT HÀNG
        public static void Dondathang_inser(
                                            string ngaytao,                        
                                            string thanhtienhd,                        
                                            string tinhtrangdonhang,                        
                                            string makh,                        
                                            string tenkh,                        
                                            string sdtkh,                        
                                            string emailkh,                        
                                            string ret                        
            )
        {
            OleDbCommand cmd = new OleDbCommand("dondathang_inser");
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@thanhtienhd", thanhtienhd);
            cmd.Parameters.AddWithValue("@tinhtrangdonhang", tinhtrangdonhang);
            cmd.Parameters.AddWithValue("@makh", makh);
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@sdtkh", sdtkh);
            cmd.Parameters.AddWithValue("@emailkh", emailkh);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC UPDATE DỮ LIỆU VÀO BẢNG ĐƠN ĐẶT HÀNG
        public static void Dondathang_update(
                                             string madondathang,
                                             string ngaytao,
                                             string thanhtienhd,
                                             string tinhtrangdonhang,
                                             string makh,
                                             string tenkh,
                                             string sdtkh,
                                             string emailkh
            )
        {
            OleDbCommand cmd = new OleDbCommand("dondathang_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@madondathang", madondathang);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@thanhtienhd", thanhtienhd);
            cmd.Parameters.AddWithValue("@tinhtrangdonhang", tinhtrangdonhang);
            cmd.Parameters.AddWithValue("@makh", makh);
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@sdtkh", sdtkh);
            cmd.Parameters.AddWithValue("@emailkh", emailkh);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC LẤY DỮ LIỆU TỪ BẢNG ĐƠN ĐẶT HÀNG
        public DataTable Thongtin_dondathang()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dondathang");
            cmd.CommandType= CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
    }
}