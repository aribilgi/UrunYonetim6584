<%@ Page Title="İletişim" Language="C#" MasterPageFile="~/Onyuz.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="UrunYonetim.WebFormUI.Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>İletişim</h1>
    <div class="row">
        <div class="col">
            <h3>Bize Ulaşın</h3>
            <hr />
            <table>
                <tr>
                    <td>Adınız</td>
                    <td>
                        <asp:TextBox ID="txtAd" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Soyadınız</td>
                    <td>
                        <asp:TextBox ID="txtSoyad" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Telefon</td>
                    <td>
                        <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Mesajınız</td>
                    <td>
                        <asp:TextBox ID="txtMesaj" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button Id="btnGonder" runat="server" Text="Gönder" />
                    </td>
                </tr>
            </table>
        </div>
        <div class="col"></div>
        <div class="col"></div>
    </div>
</asp:Content>
