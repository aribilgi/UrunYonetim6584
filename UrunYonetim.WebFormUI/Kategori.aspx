<%@ Page Title="" Language="C#" MasterPageFile="~/Onyuz.Master" AutoEventWireup="true" CodeBehind="Kategori.aspx.cs" Inherits="UrunYonetim.WebFormUI.Kategori" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 id="kategori" runat="server"></h1>
    <div class="row text-center mt-5">
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
