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
    public class ThongTinQuyenfDangNhapByID
    {
        //HÀM TÌM KIẾM QUYỀN ĐĂNG NHẬP BẰNG MÃ QUYỀN
        public static void Thongtin_quyendangnhap_by_id(string MaQuyen)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_quyendangnhap_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaQuyen", MaQuyen);
            SQLDatabase.GetData(cmd);
        }
    }
}