<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorAddNewEquipmentScreen.aspx.cs" Inherits="FrontEnd.AdministratorAddNewEquipmentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-size: x-large; text-decoration: underline">
        <strong><em>Add New Equipment Screen</em></strong></p>
    <hr />
    <br /><span style="color: #CC0000">*</span><span style="color: #000000">Equipment Name</span>:
    <asp:TextBox ID="txtAddEquipmentName" runat="server"></asp:TextBox>
    <br />
    <br />Hardware:
    <asp:TextBox ID="txtAddHardware" runat="server"></asp:TextBox>
    <br />
    <br /><span style="color: #000000">Software:</span><span style="color: #CC0000"> </span>&nbsp;<asp:TextBox ID="txtAddSoftware" runat="server"></asp:TextBox>
    <br />
    <br /><span style="color: #CC0000">*</span>Equipment Description:<br />
    <br />
    <asp:TextBox ID="txtAddEquipmentDescription" runat="server" Height="92px" Width="365px"></asp:TextBox>
    <br />
    <br /><strong>
    <asp:Button ID="btnAddEquipment" runat="server" style="font-weight: bold" Text="Add Equipment" />
    <asp:Button ID="btnAddEquipmentCancel" runat="server" style="font-weight: bold" Text="Cancel" />
    </strong>
</asp:Content>
