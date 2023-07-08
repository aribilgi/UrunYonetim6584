<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="KategoriYonetimi.aspx.cs" Inherits="UrunYonetim.WebFormUI.Admin.KategoriYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Kategori Yönetimi</h1>
    <asp:GridView ID="dgvKategoriler" runat="server" CssClass="table table-striped table-hover" OnSelectedIndexChanged="dgvKategoriler_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <table>
        <tr>
            <td>Kategori Adı</td>
            <td>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" required></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Açıklama</td>
            <td>
                <asp:TextBox ID="txtDescription" CssClass="form-control" TextMode="MultiLine" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Durum</td>
            <td>
                <asp:CheckBox ID="cbIsActive" runat="server" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnEkle" runat="server" Text="Ekle" CssClass="btn btn-primary" OnClick="btnEkle_Click" />
                <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" CssClass="btn btn-success" Enabled="False" OnClick="btnGuncelle_Click" />
                <asp:Button ID="btnSil" runat="server" Text="Sil" CssClass="btn btn-danger" Enabled="False" OnClick="btnSil_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
