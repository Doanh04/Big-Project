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
    public class ThongTInDanhMucByID
    {
        //HÀM TÌM KIẾM THÔNG TIN DANH MỤC BẰNG MÃ DANH MỤC
        public static DataTable Thongtin_danhmuc_by_id(string MaDM)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmuc_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDM", MaDM);
            return SQLDatabase.GetData(cmd);
        }
    }
}