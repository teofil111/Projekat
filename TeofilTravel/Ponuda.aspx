<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ponuda.aspx.cs" Inherits="TeofilTravel.Ponuda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   


    <h1 class="h1">Pogledajte nasu ponudu hotela</h1>

    <asp:GridView ID="GridView1" runat="server" CssClass="table" EmptyDataText="NO DATA"></asp:GridView>

    <h2>Reference za gradove koji grad je koji broj</h2>
    <asp:GridView ID="GridView2" runat="server" CssClass="table" EmptyDataText="NO DATA"></asp:GridView>

    <asp:Label ID="Label1" runat="server" Text="" Font-Bold="true" ForeColor="Red"></asp:Label>


</asp:Content>
