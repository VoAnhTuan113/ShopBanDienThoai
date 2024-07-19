using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ShopBanDienThoai
{
    public class LopKetNoi
    {
        SqlConnection conn;

        private void layKetNoi()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QLDienThoai.mdf;Integrated Security=True");
            conn.Open();
        }

        private void dongKetNoi()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public DataTable layData (string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                layKetNoi();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            catch
            {
                dt = null;
            }
            finally
            {
                dongKetNoi();
            }
            return dt;
        }

        public int xuLy(string sql)
        {
            int kq = 0;
            try
            {
                layKetNoi();
                SqlCommand cmd = new SqlCommand();
                kq = cmd.ExecuteNonQuery();
            }
            catch
            {
                kq = 0;
            }
            finally
            {
                dongKetNoi();
            }
            return kq;
        }

        public string layTenHang(string maHang)
        {
            string tenHang = "";
            try
            {
                layKetNoi();
                SqlCommand cmd = new SqlCommand("SELECT tenhang FROM Hang WHERE mahang = @mahang", conn);
                cmd.Parameters.AddWithValue("@mahang", maHang);
                tenHang = cmd.ExecuteScalar()?.ToString() ?? "";
            }
            catch
            {
                tenHang = "";
            }
            finally
            {
                dongKetNoi();
            }
            return tenHang;
        }

        public string layTenLoai(string maLoai)
        {
            string tenLoai = "";
            try
            {
                layKetNoi();
                SqlCommand cmd = new SqlCommand("SELECT tenloai FROM Loai WHERE maloai = @maloai", conn);
                cmd.Parameters.AddWithValue("@maloai", maLoai);
                tenLoai = cmd.ExecuteScalar()?.ToString() ?? "";
            }
            catch
            {
                tenLoai = "";
            }
            finally
            {
                dongKetNoi();
            }
            return tenLoai;
        }
    }
}