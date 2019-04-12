<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorAddNewRoleScreen.aspx.cs" Inherits="FrontEnd.AdministratorAddNewRoleScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-size: x-large; text-decoration: underline">
        <strong><em>Add New Role Screen</em></strong></p>
    <hr />
    <br /><span style="color: #CC0000">*</span>Role Description:
    <asp:TextBox ID="txtAddRoleDescription" runat="server"></asp:TextBox>
    <br />
    <br />
    <br />
    <asp:Label ID="lblError" runat="server" style="font-weight: 700" Text="[lblError]"></asp:Label>
    <br />
    <br /><strong>
    <asp:Button ID="btnAddRole" runat="server" style="font-weight: bold" Text="Add Role" OnClick="btnAddRole_Click" />
    <asp:Button ID="btnAddRoleCancel" runat="server" style="font-weight: bold" Text="Cancel" OnClick="btnAddRoleCancel_Click" />
    </strong>
</asp:Content>
