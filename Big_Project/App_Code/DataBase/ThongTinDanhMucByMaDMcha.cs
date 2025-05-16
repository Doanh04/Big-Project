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
    public class ThongTinDanhMucByMaDMcha
    {

        public static DataTable Thongtin_danhmuc_by_MaDMCha(string MaDMCha)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmuc_by_MaDMCha");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDMCha", MaDMCha);
            return SQLDatabase.GetData(cmd);
        }
    }
}