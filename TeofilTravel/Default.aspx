<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TeofilTravel._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Teofil Travel</h1>
        <p class="lead">Turisticka agencija koja vas vodi do vaseg mira.</p>
        <p><a href="Ponuda.aspx" class="btn btn-primary btn-lg">Pogledajte nasu ponudu &raquo;</a></p>
    </div>

    
    <div class="jumbotron">
        <h2>Pretplatite se da vidite najpovoljnija mesta za vase putovanje</h2>
        <asp:Label ID="Label1" runat="server" Text="Ime:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Prijavite se" CssClass="btn btn-success" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="" ForeColor="Red" Font-Bold="true"></asp:Label>
    </div>

</asp:Content>
