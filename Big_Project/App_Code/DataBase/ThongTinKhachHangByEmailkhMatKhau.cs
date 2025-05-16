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
    public class ThongTinKhachHangByEmailkhMatKhau
    {
        //HÀM TÌM KIẾN THÔNG TIN KHÁCH HÀNG BẰNG EMAIL KHÁCH HÀNG VÀ MẬT KHẨU
        public static void Thongtin_khachhang_by_emailkh_matkhau(string emailkh, string matkhau)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_khachhang_by_emailkh_matkhau");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emailkh", emailkh);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);
            SQLDatabase.GetData(cmd);
        }
    }
}