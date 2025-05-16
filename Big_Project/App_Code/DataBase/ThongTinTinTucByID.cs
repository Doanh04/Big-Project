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
    public class ThongTinTinTucByID
    {
        public static void Thongtin_tintuc_by_id(string TinTucID)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_tintuc_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TinTucID", TinTucID);
            SQLDatabase.GetData(cmd);
        }
    }
}