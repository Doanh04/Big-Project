using Big_ProJect;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Web;

namespace Big_ProJect
{
    public class ThongTinQuyenDangNhao
    {
        public static DataTable Thongtin_quyendangnhap()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_quyendangnhap");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
    }
}
