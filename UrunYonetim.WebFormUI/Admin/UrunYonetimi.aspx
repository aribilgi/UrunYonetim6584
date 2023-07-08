<%@ Page Title="Ürün Yönetimi" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="UrunYonetimi.aspx.cs" Inherits="UrunYonetim.WebFormUI.Admin.UrunYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Ürün Yönetimi</h1>
    <asp:GridView ID="dgvUrunler" runat="server" CssClass="table table-striped table-hover" OnSelectedIndexChanged="dgvUrunler_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>

    <table>
        <tr>
            <td>Ürün Adı</td>
            <td>
                <asp:TextBox ID="txtName" required CssClass="form-control" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Marka</td>
            <td>
                <asp:TextBox ID="txtBrand" CssClass="form-control" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Stok</td>
            <td>
                <asp:TextBox ID="txtStock" TextMode="Number" required CssClass="form-control" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Fiyat</td>
            <td>
                <asp:TextBox ID="txtPrice" required CssClass="form-control" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Kategori</td>
            <td>
                <asp:DropDownList ID="cmbKategoriler" CssClass="form-select" runat="server" DataTextField="Name" DataValueField="Id"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Ürün Açıklaması</td>
            <td>
                <asp:TextBox ID="txtDescription" CssClass="form-control" TextMode="MultiLine" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Durum</td>
            <td>
                <asp:CheckBox ID="cbIsActive" runat="server" CssClass="form-control" Text="Aktif" />
            </td>
        </tr>
        <tr>
            <td>Anasayfa</td>
            <td>
                <asp:CheckBox ID="cbIsHome" runat="server" CssClass="form-control" Text="Göster" />
            </td>
        </tr>
        <tr>
            <td>Ürün Resmi</td>
            <td>
                <asp:FileUpload ID="fuImage" runat="server" CssClass="form-control" />
                <asp:Image ID="Image1" runat="server" />
                <asp:CheckBox ID="cbResmiSil" runat="server" Text="Resmi Sil" />
                <asp:HiddenField ID="hfResim" runat="server" />
            </td>
        </tr>
        <tr class="mt-3">
            <td></td>
            <td class="mt-3">
                <asp:Button ID="btnEkle" runat="server" Text="Ekle" CssClass="btn btn-primary" OnClick="btnEkle_Click" />
                <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" CssClass="btn btn-success" Enabled="False" OnClick="btnGuncelle_Click" />
                <asp:Button ID="btnSil" runat="server" Text="Sil" CssClass="btn btn-danger" Enabled="False" OnClick="btnSil_Click" />
            </td>
        </tr>
    </table>

</asp:Content>
