using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopBanDienThoai
{
    public partial class ChiTietSanPham : System.Web.UI.Page
    {
        LopKetNoi kn = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string sql;
            string maSanPham = Request.QueryString["msp"];
            if (string.IsNullOrEmpty(maSanPham))
            {
                sql = "select * from SanPham";
            }
            else
            {
                sql = "select * from SanPham where masanpham = '" + maSanPham + "'";
            }
            this.DataList1.DataSource = kn.layData(sql);
            this.DataList1.DataBind();
        }
    }
}