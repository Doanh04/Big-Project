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
    public class ThongTinDonDatHangDESC
    {
        //HÀM TÌM KIẾM THÔNG TIN ĐƠN ĐẶT HÀNG THEO THỨ TỰ GIẢM DẦN
        public DataTable Thongtin_dondathang_desc()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_dondathang_desc");
            cmd.CommandType = CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
    }
}