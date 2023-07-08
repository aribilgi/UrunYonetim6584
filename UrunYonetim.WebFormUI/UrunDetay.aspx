<%@ Page Title="Ürün Detay" Language="C#" MasterPageFile="~/Onyuz.Master" AutoEventWireup="true" CodeBehind="UrunDetay.aspx.cs" Inherits="UrunYonetim.WebFormUI.UrunDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-6">
            <asp:Image Id="Resim" runat="server" class="img-fluid"></asp:Image>
        </div>
        <div class="col-6">
            <h1 id="baslik" runat="server"></h1>
            <h3 id="marka" runat="server"></h3>
            <h4 id="fiyat" runat="server"></h4>
            <h4 id="stok" runat="server"></h4>
            <p id="aciklama" runat="server"></p>
        </div>
    </div>
</asp:Content>
