using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Big_ProJect {
    public class ThongTinDonDatHangByID
    {
        public static void Thongtin_dondathang_by_id(string MaDonDatHang)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dondathang_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDonDatHang", MaDonDatHang);
            SQLDatabase.GetData(cmd);
        }
    }
}