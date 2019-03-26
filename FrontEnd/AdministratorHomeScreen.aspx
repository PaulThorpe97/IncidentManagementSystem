<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorHomeScreen.aspx.cs" Inherits="FrontEnd.AdministratorHomeScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="text-decoration: underline; font-size: x-large">
        <strong><em>Adminstrator Home Screen</em></strong></p>
    <hr />
    <br />
    <strong>
    <asp:Button ID="btnIncidents" runat="server" style="text-align: center; font-weight: bold" Text="Incidents" />
    <br />
    <br />
    <asp:Button ID="btnStaff" runat="server" style="font-weight: bold" Text="Staff" />
    <br />
    <br />
    <asp:Button ID="btnEquipment" runat="server" style="font-weight: bold" Text="Equipment" />
    <br />
    <br />
    <asp:Button ID="btnRoles" runat="server" style="font-weight: bold; height: 26px" Text="Roles" />
    </strong>
</asp:Content>
