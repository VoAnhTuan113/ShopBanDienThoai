using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopBanDienThoai
{
    public partial class DanhSachSanPham : System.Web.UI.Page
    {
        LopKetNoi kn = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string sql;
            string maHang = Request.QueryString["mh"];
            string maLoai = Request.QueryString["ml"];
            
            if (string.IsNullOrEmpty(maLoai)&&string.IsNullOrEmpty(maHang))
            {
                sql = "select * from SanPham";
                LabelDSSP.Text = "Tất cả sản phẩm";
            }
            else if ((string.IsNullOrEmpty(maLoai))&&!string.IsNullOrEmpty(maHang))
            {
                sql = "select * from SanPham where mahang = '" + maHang + "'";
                LabelDSSP.Text = kn.layTenHang(maHang);
            }
            else if (string.IsNullOrEmpty(maHang)&&!string.IsNullOrEmpty(maLoai))
            {
                sql = "select * from SanPham where maloai = '" + maLoai + "'";
                LabelDSSP.Text = kn.layTenLoai(maLoai);
            }
            else
            {
                sql = "select * from SanPham where maloai = '" + maLoai + "' and mahang = '"+ maHang + "'";
                LabelDSSP.Text = "Loại: " + kn.layTenLoai(maLoai) + " - Hãng: " + kn.layTenHang(maHang);
            }
            this.DataList1.DataSource = kn.layData(sql);
            this.DataList1.DataBind();

        }

        protected void ImageButtonSanPham_Click(object sender, ImageClickEventArgs e)
        {
            string maSanPham = ((ImageButton)sender).CommandArgument;
            Response.Redirect("ChiTietSanPham.aspx?msp=" + maSanPham);
        }

        protected void LinkButtonSanPham_Click(object sender, EventArgs e)
        {
            string maSanPham = ((LinkButton)sender).CommandArgument;
            Response.Redirect("ChiTietSanPham.aspx?msp=" + maSanPham);
        }
    }
}