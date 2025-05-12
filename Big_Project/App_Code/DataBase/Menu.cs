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
    public class Menu
    {
        //PHƯƠNG THỨC XÓA DỮ LIỆU BẢNG MENU THEO MÃ MENU
        public static void Menu_delete(
                                            string mamenu
            )
        {
            OleDbCommand cmd = new OleDbCommand("menu_delete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mamenu", mamenu);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC THÊM DỮ LIỆU MỚI VÀO BẢNG MENU
        public static void Menu_inser(
                                      string tenmenu,
                                      string lienket,
                                      string mamenucha,
                                      string thutumenu,
                                      string ret
            )
        {
            OleDbCommand cmd = new OleDbCommand("menu_inser");
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@tenmenu", tenmenu);
            cmd.Parameters.AddWithValue("@lienket", lienket);
            cmd.Parameters.AddWithValue("@mamenucha", mamenucha);
            cmd.Parameters.AddWithValue("@thutumenu", thutumenu);
            cmd.Parameters.AddWithValue("@ret", ret);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC UPDATE DỮ LIỆU VÀO BẢNG MENU
         public static void Menu_update(
                                        string @mamenu,
                                        string @tenmenu,
                                        string @lienket,
                                        string @mamenucha,
                                        string @thutumenu
             )
        {
            OleDbCommand cmd = new OleDbCommand("menu_update");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mamenu", mamenu);
            cmd.Parameters.AddWithValue("@tenmenu", tenmenu);
            cmd.Parameters.AddWithValue("@lienket", lienket);
            cmd.Parameters.AddWithValue("@mamenucha", mamenucha);
            cmd.Parameters.AddWithValue("@thutumenu", thutumenu);
            SQLDatabase.ExecuteNoneQuery(cmd);
        }
        //PHƯƠNG THỨC LẤY TOÀN BỘ DỮ LIỆU TRONG BẢNG MENU
        public DataTable Thongtin_menu()
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_menu");
            cmd.CommandType= CommandType.StoredProcedure;
            return SQLDatabase.GetData(cmd);
        }
    }
}