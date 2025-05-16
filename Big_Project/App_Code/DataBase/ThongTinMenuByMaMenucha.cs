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
    public class ThongTinMenuByMaMenucha
    {
        //HÀM TÌM KIẾN THÔNG TIN MENU BẰNG MENU CHA
        public static void Thongtin_menu_by_mamenucha(string MaMenuCha)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_menu_by_mamenucha");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaMenuCha", MaMenuCha);
            SQLDatabase.GetData(cmd);
        }
    }
}