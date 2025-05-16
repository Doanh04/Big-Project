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
    public class ThongTinKhachHangByEmail
    {
        //HÀM TÌM KIẾM THÔNG TIN KHÁCH HÀNG BĂNG EMAIL
        public static void Thongtin_khachhang_by_email(string emailkh)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_khachhang_by_email");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emailkh", emailkh);
            SQLDatabase.GetData(cmd);
        }
    }
}