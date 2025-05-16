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
    public class ThongTinTinTucByMaDanhMucTatCar
    {
        //HÀM TÌM KIẾM TẤT CẢ THÔNG TIN TIN TỨC BẰNG MÃ DANH MỤC
        public static void Thongtin_tintuc_by_madm_tatca(string MaMD)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_tintuc_by_madm_tatca");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMD", MaMD);
            SQLDatabase.GetData(cmd);
        }
    }
}