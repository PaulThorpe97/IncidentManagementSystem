<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorEditEquipmentScreen.aspx.cs" Inherits="FrontEnd.AdministratorEditEquipmentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-size: x-large; text-decoration: underline">
        <strong><em>Edit Equipment Screen</em></strong></p>
    <hr />
    <br /><span style="color: #CC0000">*</span><span style="color: #000000">Equipment Name</span>:
    <asp:TextBox ID="txtEditEquipmentName" runat="server"></asp:TextBox>
    <br />
    <br />Hardware:
    <asp:TextBox ID="txtEditHardware" runat="server"></asp:TextBox>
    <br />
    <br /><span style="color: #000000">Software:</span><span style="color: #CC0000"> </span>&nbsp;<asp:TextBox ID="txtEditSoftware" runat="server"></asp:TextBox>
    <br />
    <br /><span style="color: #CC0000">*</span>Equipment Description:<br />
    <br />
    <asp:TextBox ID="txtEditEquipmentDescription" runat="server" Height="92px" Width="365px"></asp:TextBox>
    <br />
    <br /><strong>
    <asp:Button ID="btnEditEquipment" runat="server" style="font-weight: bold" Text="Edit Equipment" />
    <asp:Button ID="btnEditEquipmentCancel" runat="server" style="font-weight: bold" Text="Cancel" />
    </strong>
</asp:Content>
