<%@ Page Title="Ürün Ara" Language="C#" MasterPageFile="~/Onyuz.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="UrunYonetim.WebFormUI.Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row text-center mt-5">
        <h2 class="display-2 pb-3">Ürünlerimiz</h2>
        <!-- /.col-lg-4 -->
        <asp:Repeater ID="rptUrunler" runat="server">
            <ItemTemplate>
                <div class="col-lg-4">
                    <a href="UrunDetay.aspx?id=<%#Eval("Id") %>">
                        <img src="/Images/<%#Eval("Image") %>" alt="Alternate Text" class="img-fluid" />
                        <h2 class="fw-normal"><%#Eval("Name") %></h2>
                    </a>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
