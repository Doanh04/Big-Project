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
    public class ThongTInMenuByID
    {
        //HÀM TÌM KIẾM THÔNG TIN MENU BẰNG MÃ MENU
       public static void Thongtin_menu_by_id(string MaMenu)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_menu_by_id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMenu", MaMenu);
            SQLDatabase.GetData(cmd);
        }
    }
}