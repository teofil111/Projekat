<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Upravljanje.aspx.cs" Inherits="TeofilTravel.Admin.Upravljanje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Gradovi</h1>
    <asp:GridView ID="GridView2" runat="server" CssClass="table" EmptyDataText="NO DATA"></asp:GridView>
    <asp:Label ID="Label1" runat="server" Text="" Font-Bold="true" ForeColor="Red"></asp:Label>

    <h1>Hoteli</h1>
    <asp:GridView ID="GridView1" runat="server" CssClass="table" EmptyDataText="NO DATA"></asp:GridView>
    <asp:Label ID="Label2" runat="server" Text="" Font-Bold="true" ForeColor="Red"></asp:Label>

    <div class="jumbotron">
        <asp:Label ID="Label5" runat="server" Text="Naziv"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Grad"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Zvezdice"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Opis"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Dodaj Hotel!"  CssClass="btn btn-success" OnClick="Button1_Click"/>
        <asp:Label ID="Label10" runat="server" Text="" Font-Bold="true" ForeColor="Red"></asp:Label>
    </div>
</asp:Content>
