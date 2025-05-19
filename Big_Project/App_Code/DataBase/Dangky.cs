using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Big_ProJect { 
public class Dangky
    {
        //PHƯƠNG THỨC XÓA TÀI KHOẢN ĐĂNG KÝ THEO MÃ TÊN ĐĂNG NHẬP ĐƯỢC TRUYỀN VÀO
        public static void Dangky_delete(string tendangnhap) {
            OleDbCommand cmd = new OleDbCommand("dangky_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC THÊM MỚI DỮ LIỆU VÀO BẢNG ĐĂNG KÝ
        public static void Dangky_inser(
                                        string tendangnhap,
                                        string matkhau,
                                        string emaildk,
                                        string tendaydu,
                                        DateTime ngaysinh,
                                        string gioitinhdk,
                                        string maquyen,
                                        string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("dangky_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            cmd.Parameters.AddWithValue("@emaildk", emaildk);
            cmd.Parameters.AddWithValue("@tendaydu", tendaydu);
            cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            cmd.Parameters.AddWithValue("@gioitinhdk", gioitinhdk);
            cmd.Parameters.AddWithValue("@maquyen", maquyen);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC UPDATE DỮ LIỆU VÀO BẢNG ĐĂNG KÝ
        public static void Dangky_update(
                                         string tendangnhap,
                                         string matkhau,
                                         string emaildk,
                                         string tendaydu,
                                         DateTime ngaysinh,
                                         string gioitinhdk,
                                         string maquyen)
        {
            OleDbCommand cmd = new OleDbCommand("dangky_update");
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tendangnhap", tendangnhap);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            cmd.Parameters.AddWithValue("@emaildk", emaildk);
            cmd.Parameters.AddWithValue("@tendaydu", tendaydu);
            cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
            cmd.Parameters.AddWithValue("@gioitinhdk", gioitinhdk);
            cmd.Parameters.AddWithValue("@maquyen", maquyen);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC XEM TOÀN BỘ DỮ LIỆU TRONG BẢNG ĐĂNG KÝ
        public static DataTable Thongtin_dangky()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dangky");
            cmd.CommandType= CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
    }
}
