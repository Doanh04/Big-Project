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
    //HÀM TÌM KIẾM THÔNG TIN DANH MỤC TIN BẰNG MÃ DANH MỤC CHA
    public class ThongTinDanhMucTinByIDCha
    {
        public static void Thongtin_danhmuctin_by_MaDMCha(string MaDMCha)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmuctin_by_MaDMCha");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDMCha", MaDMCha);
            SQLDatabase.GetData(cmd);
        }
    }
}