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
    public class ThongTinSanPhamByID
    {
        public static DataTable Thongtin_sanpham_by_id (string MaSP)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_sanpham_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@@MaSP", MaSP);
            return SQLDatabase.GetData(cmd);
        }
    }
}