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
    public class NhanVien
    {
        //HÀM XÓA NHÂN VIÊN THEO MÃ NHÂN VIÊN
        public static void Nhanvien_delete(string manv)
        {
            OleDbCommand cmd = new OleDbCommand("nhanvien_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", manv);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //HÀM THÊM MỚI DỮ LIỆU VÀO BẢNG NHÂN VIÊN
        public static void Nhanvien_inser(
                                          string tennv,
                                          string gioitinhnv,
                                          string diachinv,
                                          string sdtnv,
                                          string ngayvaolam,
                                          string ret

            )
        {
            OleDbCommand cmd = new OleDbCommand("nhanvien_inser");
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tennv", tennv);
            cmd.Parameters.AddWithValue("@gioitinhnv", gioitinhnv);
            cmd.Parameters.AddWithValue("@diachinv", diachinv);
            cmd.Parameters.AddWithValue("@sdtnv", sdtnv);
            cmd.Parameters.AddWithValue("@ngayvaolam", ngayvaolam);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //HÀM UPDATE DỮ LIỆU VÀO BẢNG NHÂN VIÊN
        public static void Nhanvien_update(
                                           string manv,
                                           string tennv,
                                           string gioitinhnv,
                                           string diachinv,
                                           string sdtnv,
                                           string ngayvaolam
            )
        {
            OleDbCommand cmd = new OleDbCommand("nhanvien_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", manv);
            cmd.Parameters.AddWithValue("@tennv", tennv);
            cmd.Parameters.AddWithValue("@gioitinhnv", gioitinhnv);
            cmd.Parameters.AddWithValue("@diachinv", diachinv);
            cmd.Parameters.AddWithValue("@sdtnv", sdtnv);
            cmd.Parameters.AddWithValue("@ngayvaolam", ngayvaolam);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //HÀM LẤY TẤT CẢ THÔNG TIN TRONG BẢNG NHÂN VIÊN
        public DataTable Thongtin_nhanvien()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_nhanvien");
            cmd.CommandType= CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
    }
}