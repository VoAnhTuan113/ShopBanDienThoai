using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopBanDienThoai
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LopKetNoi kn = new LopKetNoi();
            if (Page.IsPostBack) return;
            string sql;
            string maHang = Request.QueryString["mh"];
            string maLoai = Request.QueryString["ml"];
            sql = "select * from SanPham";
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