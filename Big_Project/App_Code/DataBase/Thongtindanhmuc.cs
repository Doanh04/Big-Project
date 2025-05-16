using Big_ProJect;
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
    public class Thongtindanhmuc
    {
        public static DataTable Thongtin_danhmuc()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmuc");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
    }

}