<%@ Page Title="Slider Yönetimi" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="SliderYonetimi.aspx.cs" Inherits="UrunYonetim.WebFormUI.Admin.SliderYonetimi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Slider Yönetimi</h1>
    <asp:GridView ID="dgvSlider" runat="server" CssClass="table table-striped table-hover" OnSelectedIndexChanged="dgvSlider_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>

    <table>
        <tr>
            <td>Başlık</td>
            <td>
                <asp:TextBox Id="txtTitle" CssClass="form-control" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Açıklama</td>
            <td>
                <asp:TextBox ID="txtDescription" CssClass="form-control" TextMode="MultiLine" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Resim</td>
            <td>
                <asp:FileUpload Id="fuImage" runat="server"></asp:FileUpload>
                <asp:Image ID="Image1" runat="server" />
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
