<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorAddNewEquipmentScreen.aspx.cs" Inherits="FrontEnd.AdministratorAddNewEquipmentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-size: x-large; text-decoration: underline">
        <strong><em>Add New Equipment Screen</em></strong></p>
    <hr />
    <div align="center">
    <br /><span style="color: #CC0000">*</span><span style="color: #000000">Equipment Name</span>:
    <asp:TextBox ID="txtAddEquipmentName" runat="server"></asp:TextBox>
    <br />
    <br />Hardware:
    <asp:CheckBox ID="chkAddHardware" runat="server" OnCheckedChanged="chkAddHardware_CheckedChanged"/>
    <br />
    <br /><span style="color: #000000">Software:</span><span style="color: #CC0000"> </span>&nbsp;<asp:CheckBox ID="chkAddSoftware" runat="server" OnCheckedChanged="chkAddSoftware_CheckedChanged"/>
    <br />
    <br /><span style="color: #CC0000">*</span>Equipment Description:<br />
    <br />
    <asp:TextBox ID="txtAddEquipmentDescription" runat="server" Height="92px" Width="365px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
    <br />
    <br /><strong>
    <asp:Button ID="btnAddEquipment" runat="server" style="font-weight: bold" Text="Add Equipment" OnClick="btnAddEquipment_Click" />
    <asp:Button ID="btnAddEquipmentCancel" runat="server" style="font-weight: bold" Text="Cancel" OnClick="btnAddEquipmentCancel_Click" />
    </strong>
        </div>
</asp:Content>
