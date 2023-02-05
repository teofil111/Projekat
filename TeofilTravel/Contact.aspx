<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="TeofilTravel.Contact" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Kontaktirajte nas za vise detalja o ponudi i aranzmanima</h1>
    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="Ime i prezime:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Mesto"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Hotel"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>

        <br />
        <asp:Button ID="Button1" runat="server" Text="Posalji rezervaciju" CssClass="btn btn-primary" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label5" runat="server" Text="" ForeColor="Red" Font-Bold="true"></asp:Label>
    </div>

    <h3>Teofil Travel</h3>
    <address>
        Prvomajska<br />
        Beograd<br />
        <abbr title="Phone">Telefon:</abbr>
        0653211302
    </address>

    <address>
        <strong>Pomoc:</strong>   <a href="mailto:Support@example.com">pomoc@teofiltravel.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">marketing@teofiltravel.com</a>
    </address>
</asp:Content>
