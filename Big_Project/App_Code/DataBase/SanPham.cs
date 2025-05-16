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
    public class SanPham
    {
        //PHƯƠNG THỨC XÓA SẢN PHẨM THEO MÃ SẢN PHẨM ĐƯỢC TRUYỀN Vào
        public static void Sanpham_Delete(string masp)
        {
            OleDbCommand cmd = new OleDbCommand("sanpham_delete");
            cmd.CommandType= CommandType.StoredProcedure;//chỉ định thủ tục lữu trữ StoredProcedure không phải hàm bình thường
            cmd.Parameters.AddWithValue("@masp", masp); //truyền tham số vào thủ tục lữu trữ StoredProcedure qua Parameters
            SQLDatabase.ExecuteNoneQuery(cmd);//gọi lại phương thức để thực thi lệnh không trả về dữ liệu
        }
        //PHƯƠNG THỨC THÊM MỚI DỮ LIỆU VÀO BẢNG SẢN PHẨM
        public static void Sanpham_Inser(string tensp,
                                         string anhsanpham,
                                         string soluongsp,
                                         string giasp ,
                                         string motasp,
                                         string ngaytao,
                                         string ngayhuy,
                                         string maDM ,
                                         string ret )
        {
            OleDbCommand cmd = new OleDbCommand("sanpham_inser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tensp", tensp);
            cmd.Parameters.AddWithValue("@anhsanpham", anhsanpham);
            cmd.Parameters.AddWithValue("@soluongsp", soluongsp);
            cmd.Parameters.AddWithValue("@giasp", giasp);
            cmd.Parameters.AddWithValue("@motasp", motasp);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@ngayhuy", ngayhuy);
            cmd.Parameters.AddWithValue("@maDM", maDM);
            cmd.Parameters.Add("@ret", OleDbType.Integer).Direction = ParameterDirection.Output;
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC UPDATE DỮ LIỆU VÀO BẢNG SẢN PHẨM
        public static void Sanpham_update(string tensp,
                                         string anhsanpham,
                                         string soluongsp,
                                         string giasp,
                                         string motasp,
                                         string ngaytao,
                                         string ngayhuy,
                                         string maDM,
                                         string ret)
        {
            OleDbCommand cmd = new OleDbCommand("sanpham_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tensp", tensp);
            cmd.Parameters.AddWithValue("@anhsanpham", anhsanpham);
            cmd.Parameters.AddWithValue("@soluongsp", soluongsp);
            cmd.Parameters.AddWithValue("@giasp", giasp);
            cmd.Parameters.AddWithValue("@motasp", motasp);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@ngayhuy", ngayhuy);
            cmd.Parameters.AddWithValue("@maDM", maDM);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }

        //PHƯƠNG THỨC XEM TOÀN BỘ DỮ LIỆU TRONG BẢNG
        public static DataTable Thongtin_sanpham()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd); //gọi đến phương thức truy vấn trả về kết quả
        }


    }
}