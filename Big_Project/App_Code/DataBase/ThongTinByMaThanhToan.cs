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
    public class ThongTinByMaThanhToan
    {
        //HÀM TÌM KIẾM THÔNG TIN ĐƠN ĐẶT HÀNG BẰNG MÃ THANH TOÁN
        public static void Thongtin_dondathang_by_mathanhtoan(string mathanhtoan)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dondathang_by_mathanhtoan");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mathanhtoan", mathanhtoan);
            SQLDatabase.GetData(cmd);
        }
    }
}