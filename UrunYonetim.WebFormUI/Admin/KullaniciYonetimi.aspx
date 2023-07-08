<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="KullaniciYonetimi.aspx.cs" Inherits="UrunYonetim.WebFormUI.Admin.KullaniciYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Kullanıcı Yönetimi</h1>
    <asp:GridView ID="dgvKullanicilar" runat="server" CssClass="table table-striped table-hover" OnSelectedIndexChanged="dgvKullanicilar_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <hr />
    <table>
        <tr>
            <td>Adı</td>
            <td>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" required></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Soyadı</td>
            <td><asp:TextBox ID="txtSurname" runat="server" CssClass="form-control"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Email</td>
            <td><asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" required></asp:TextBox></td>
        </tr>
        <tr>
            <td>Kullanıcı Adı</td>
            <td><asp:TextBox ID="txtUsername" runat="server" CssClass="form-control"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Şifre</td>
            <td><asp:TextBox ID="txtPassword" runat="server" CssClass="form-control"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Telefon</td>
            <td><asp:TextBox ID="txtPhone" runat="server" CssClass="form-control"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Durum</td>
            <td>
                <asp:CheckBox ID="cbIsActive" runat="server"></asp:CheckBox>
            </td>
        </tr>
        <tr>
            <td>Admin</td>
            <td><asp:CheckBox ID="cbIsAdmin" runat="server"></asp:CheckBox></td>
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
