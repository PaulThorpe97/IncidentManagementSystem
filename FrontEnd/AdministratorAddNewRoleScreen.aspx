<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorAddNewRoleScreen.aspx.cs" Inherits="FrontEnd.AdministratorAddNewRoleScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-size: x-large; text-decoration: underline">
        <strong><em>Add New Role Screen</em></strong></p>
    <hr />
    <br /><span style="color: #CC0000">*</span><span style="color: #000000">Role ID</span>:
    <asp:TextBox ID="txtAddRoleID" runat="server"></asp:TextBox>
    <br />
    <br /><span style="color: #CC0000">*</span>Role Description:
    <asp:TextBox ID="txtAddRoleDescription" runat="server"></asp:TextBox>
    <br />
    <br /><strong>
    <asp:Button ID="btnAddRole" runat="server" style="font-weight: bold" Text="Add Role" />
    <asp:Button ID="btnAddRoleCancel" runat="server" style="font-weight: bold" Text="Cancel" />
    </strong>
</asp:Content>
