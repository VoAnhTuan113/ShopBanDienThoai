<%@ Page Title="" Language="C#" MasterPageFile="~/SiteBanDienThoai.Master" AutoEventWireup="true" CodeBehind="ChiTietSanPham.aspx.cs" Inherits="ShopBanDienThoai.ChiTietSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .bottom-container{
            display: flex;
        }

        .bottom-left{
            padding: 1px;
        }

        .bottom-right{
           padding: 20px;
        }
        .image-sp {
            margin: 10px;
            object-fit: cover;
            display: flex;
            justify-content: center;
            height: 300px;
            transition: transform 0.3s ease-in-out;
        }

        .image-sp:hover{
            transform: scale(1.25);
        }

        .datalist {
            background-color: #ffead4;
            padding: 5px;
            border-radius: 25px;
            /*overflow: hidden;*/
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center">
        <h1 style="font-family:Dosis"><b>CHI TIẾT SẢN PHẨM</b></h1>
    </div>
    <asp:DataList ID="DataList1" runat="server" CssClass="datalist" RepeatColumns="3">
        <ItemTemplate>
            <div class="bottom-container">
                <div class="bottom-left">
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/HinhAnhSanPham/"+Eval("hinhanh") %>' CssClass="image-sp"/>
                </div>
                <div class="bottom-right">
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("tensanpham") %>' Font-Bold="true"></asp:Label>

                    <br />
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("mota") %>'></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Đơn giá: " Font-Bold="true"></asp:Label>
                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("dongia", "{0:N0}") %>'></asp:Label>
                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("donvitinh") %>'></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="Số lượng: " Font-Bold="true"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Mua" />
                    <asp:Button ID="Button2" runat="server" Text="Xem giỏ hàng" />

                </div>
            </div>
        </ItemTemplate>
    </asp:DataList>

    
</asp:Content>
