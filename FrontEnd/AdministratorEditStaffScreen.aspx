<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorEditStaffScreen.aspx.cs" Inherits="FrontEnd.AdministratorEditStaffScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-size: x-large; text-decoration: underline">
        <strong><em>Edit Staff Screen</em></strong></p>
    <hr />
    <br />
    <div align="center">
    &nbsp;Role ID:
    <asp:TextBox ID="txtEditStaffRoleID" runat="server"></asp:TextBox>
    <br />
    <br />
    <span style="color: #CC0000">*</span>Surname:
    <asp:TextBox ID="txtEditStaffSurname" runat="server"></asp:TextBox>
    <br />
    <br />
    <span style="color: #CC0000">*</span>Forname:
    <asp:TextBox ID="txtEditStaffForename" runat="server"></asp:TextBox>
    <br />
    <br />
    <span style="color: #CC0000">*</span>Phone:
    <asp:TextBox ID="txtEditStaffPhone" runat="server"></asp:TextBox>
    <br />
    <br />
        <asp:Label ID="lblError" runat="server" style="font-weight: 700" Text="[lblError]"></asp:Label>
        <br />
    <br />
    <strong>
    <asp:Button ID="btnEditStaff" runat="server" style="font-weight: bold" Text="Edit Staff Member" OnClick="btnEditStaff_Click" />
    <asp:Button ID="btnEditStaffCancel" runat="server" style="font-weight: bold" Text="Cancel" OnClick="btnEditStaffCancel_Click" />
    </strong>
        </div>
</asp:Content>
