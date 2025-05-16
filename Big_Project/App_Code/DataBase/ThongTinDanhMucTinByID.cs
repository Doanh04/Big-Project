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
    public class ThongTinDanhMucTinByID
    {
        public static void Thongtin_danhmuctin_by_id(string MaDM)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmuctin_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDM", MaDM);
            SQLDatabase.GetData(cmd);
        }
    }
}