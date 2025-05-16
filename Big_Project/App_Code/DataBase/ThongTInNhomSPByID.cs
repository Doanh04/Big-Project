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
    public class ThongTInNhomSPByID
    {
        //HÀM TÌM KIẾM THÔNG TIN NHÓM SẢN PHẨM BẰNG ID
        public static void Thongtin_nhomsp_by_id(string NhomID)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_nhomsp_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NhomID", NhomID);
            SQLDatabase.GetData(cmd);
        }
    }
}