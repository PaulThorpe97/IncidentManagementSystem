<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorEditRoleScreen.aspx.cs" Inherits="FrontEnd.AdministratorEditRoleScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-size: x-large; text-decoration: underline">
        <strong><em>Edit Role Screen</em></strong></p>
    <hr />
    <br /><span style="color: #CC0000">*</span><span style="color: #000000">Role ID</span>:
    <asp:TextBox ID="txtEditRoleID" runat="server"></asp:TextBox>
    <br />
    <br /><span style="color: #CC0000">*</span>Role Description:
    <asp:TextBox ID="txtEditRoleDescription" runat="server"></asp:TextBox>
    <br />
    <br /><strong>
    <asp:Button ID="btnEditRole" runat="server" style="font-weight: bold" Text="Edit Role" />
    <asp:Button ID="btnEditRoleCancel" runat="server" style="font-weight: bold" Text="Cancel" />
    </strong>
</asp:Content>
