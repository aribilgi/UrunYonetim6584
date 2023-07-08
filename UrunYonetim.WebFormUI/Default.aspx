<%@ Page Title="Anasayfa" Language="C#" MasterPageFile="~/Onyuz.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UrunYonetim.WebFormUI.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="myCarousel" class="carousel slide mb-6" data-bs-ride="carousel" data-bs-theme="light">
        <div class="carousel-indicators">
            <button type="button" data-bs-target="#myCarousel" data-bs-slide-to="0" class="" aria-label="Slide 1"></button>
            <button type="button" data-bs-target="#myCarousel" data-bs-slide-to="1" aria-label="Slide 2" class=""></button>
            <button type="button" data-bs-target="#myCarousel" data-bs-slide-to="2" aria-label="Slide 3" class="active" aria-current="true"></button>
        </div>
        <div class="carousel-inner">
            <asp:Repeater ID="rptSlider" runat="server">
                <ItemTemplate>
                    <div class="carousel-item">
                        <img src="/Images/<%#Eval("Image") %>" alt="Alternate Text" class="img-fluid" />
                        <div class="container">
                            <div class="carousel-caption text-end">
                                <h1><%#Eval("Title") %></h1>
                                <p><%#Eval("Description") %></p>
                                <p><a class="btn btn-lg btn-primary" href="#">İncele</a></p>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>
        <button class="carousel-control-prev" type="button" data-bs-target="#myCarousel" data-bs-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Previous</span>
        </button>
        <button class="carousel-control-next" type="button" data-bs-target="#myCarousel" data-bs-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Next</span>
        </button>
    </div>

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
    <script src="Scripts/jquery-3.7.0.min.js"></script>
    <script>
        $(".carousel-inner div.carousel-item:first").addClass("active");
    </script>
</asp:Content>
