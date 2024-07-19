<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBanDienThoai.Master" AutoEventWireup="true" CodeBehind="DanhSachSanPham.aspx.cs" Inherits="ShopBanDienThoai.DanhSachSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .image-sp {
            height: 180px;
            width: 180px;
            object-fit: contain;
            background-color: #fff6ed;
            padding: 10px;
            border-radius: 20px;
            transition: transform 0.3s ease-in-out;

        }
        .image-sp:hover{
            transform: scale(1.15);
        }
        .card {
            width: 200px;
            background-color: #ffead4;
            padding: 5px;
            border-radius: 25px;
            /*overflow: hidden;*/
        }
        .thongtin-sp {
            padding-left: 15px;
            padding-right: 15px;
            padding-top: 10px;
        }
        .text {
            display: block;
            overflow: hidden;
            white-space: nowrap;
            text-overflow: ellipsis;
        }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center">
        <h1 style="font-family:Dosis">
            <b>
                Danh sách sản phẩm: 
                <asp:Label ID="LabelDSSP" runat="server" ></asp:Label>
            </b>
        </h1>
    </div>
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="5" CellSpacing="10">
        <ItemTemplate> 
            <div class="card">
                <asp:ImageButton ID="ImageButtonSanPham" runat="server" CommandArgument='<%# Eval("masanpham") %>' ImageUrl='<%# "~/HinhAnhSanPham/"+Eval("hinhanh") %>' OnClick="ImageButtonSanPham_Click" CssClass="image-sp"/>
                <br />
                    <div class="thongtin-sp">
                        <asp:LinkButton ID="LinkButtonSanPham" runat="server" Font-Underline="False" Font-Bold="true" ForeColor="Black" CommandArgument='<%# Eval("masanpham") %>' Text='<%# Eval("tensanpham") %>' OnClick="LinkButtonSanPham_Click" CssClass="text"></asp:LinkButton>
                        <br />
                        <asp:Label ID="LabelMoTa" runat="server" Text='<%# Eval("mota") %>' CssClass="text"></asp:Label>
                        <br />
                        <br />
                        <%--<asp:Label ID="Label2" runat="server" Text="Đơn giá: "></asp:Label>--%>
                        <asp:Label ID="LabelDonGia" runat="server" Text='<%# Eval("dongia","{0:N0}") %>' ForeColor="#c4544a" Font-Bold="true"></asp:Label>
                        <asp:Label ID="LabelDonVi" runat="server" Text='<%# Eval("donvitinh") %>' ForeColor="#c4544a" Font-Bold="true"></asp:Label>
                    </div>
                <br />
            </div>
        </ItemTemplate>

    </asp:DataList>
</asp:Content>
