using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopBanDienThoai
{
    public partial class SiteBanDienThoai : System.Web.UI.MasterPage
    {
        LopKetNoi kn = new LopKetNoi();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string sql1 = " select * from Hang";
            this.DataListHang.DataSource = kn.layData(sql1);
            this.DataListHang.DataBind();

            string sql2 = " select * from Loai";
            this.DataListLoai.DataSource = kn.layData(sql2);
            this.DataListLoai.DataBind();

            lblSoLuotTC.Text = Application["SoLuotTruyCap"].ToString();
            lblOnline.Text = Application["SLOnline"].ToString(); 
        }

        protected void LinkButtonLoai_Click(object sender, EventArgs e)
        {
            string maLoai = ((LinkButton)sender).CommandArgument;
            Response.Redirect("DanhSachSanPham.aspx?ml=" + maLoai);
        }

        protected void ImageButtonHang_Click(object sender, ImageClickEventArgs e)
        {
            string maHang = ((ImageButton)sender).CommandArgument;
            Response.Redirect("DanhSachSanPham.aspx?mh=" + maHang);
        }

        protected void ImageButtonLogo_Click(object sender, ImageClickEventArgs e)
        {
            Server.Transfer("HomePage.aspx");
        }

    }
}