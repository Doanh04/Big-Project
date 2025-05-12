using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Big_ProJect
{
    /// Class Quản lý chuỗi kết nối DB
    public class SQLDatabase
    {
        private static string _connectionString = string.Empty; //tạo biến dạng chuỗi tĩnh với giá trị rỗng

        public static string ConnectionString //class để get, set giá trị của _connectionString
        {
            get
            {
                if (_connectionString.Equals("")) 
                {
                    _connectionString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]; //nếu rỗng lấy giá trị từ file cấu hình ConnectionString
                }
                return _connectionString;
            }
            set
            {
                _connectionString = value;
            }
        }

        // mở chuỗi kết nối bằng ole db, tạo đối tượng conn rồi trả về đối tượng kết nối đã được mở
        public static OleDbConnection GetConnection()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            return conn;
        }

        //thực hiện truy vấn ko cần trả về kết quả (delete,update,insert) 
        public static void ExecuteNoneQuery(OleDbCommand cmd)
        {
            if (cmd.Connection != null)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {
                OleDbConnection conn = GetConnection();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
        }

        //phương thức lấy dữ liệu trả về dataTable
        public static DataTable GetData(OleDbCommand cmd)
        {
            if (cmd.Connection != null)
            {
                using (DataSet ds = new DataSet())
                {
                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        da.Fill(ds);
                        return ds.Tables[0];
                    }
                }
            }
            else
            {
                using (OleDbConnection conn = GetConnection())
                {
                    cmd.Connection = conn;
                    using (DataSet ds = new DataSet())
                    {
                        using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                        {
                            da.Fill(ds);
                            return ds.Tables[0];
                        }
                    }
                }
            }
        }

        //phương thức lấy dữ liệu trả về tất cả các dataTable
        public static DataSet GetData_OverDataset(OleDbCommand cmd)
        {
            if (cmd.Connection != null)
            {
                using (DataSet ds = new DataSet())
                {
                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        da.Fill(ds);
                        return ds;
                    }
                }
            }
            else
            {
                using (OleDbConnection conn = GetConnection())
                {
                    cmd.Connection = conn;
                    using (DataSet ds = new DataSet())
                    {
                        using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                        {
                            da.Fill(ds);
                            return ds;
                        }
                    }
                }
            }
        }
    }
}