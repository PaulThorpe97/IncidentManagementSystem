<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorHomeScreen.aspx.cs" Inherits="FrontEnd.AdministratorHomeScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="text-decoration: underline; font-size: x-large">
        <strong><em>Adminstrator Home Screen</em></strong></p>
    <hr />
    <div align="center">
    <br />
    <strong>
    <asp:Button ID="btnIncidents" runat="server" style="text-align: center; font-weight: bold; font-size: xx-large;" Text="Incidents" OnClick="btnIncidents_Click" Height="100px" Width="300px" />
    <br />
    <br />
    <asp:Button ID="btnStaff" runat="server" style="font-weight: bold; font-size: xx-large;" Text="Staff" OnClick="btnStaff_Click" Height="100px" Width="300px" />
    <br />
    <br />
    <asp:Button ID="btnEquipment" runat="server" style="font-weight: bold; font-size: xx-large;" Text="Equipment" OnClick="btnEquipment_Click" Height="100px" Width="300px" />
    <br />
    <br />
    <asp:Button ID="btnRoles" runat="server" style="font-weight: bold; font-size: xx-large;" Text="Roles" OnClick="btnRoles_Click" Height="100px" Width="300px" />
    </strong>
        </div>
</asp:Content>
