<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorEditRoleScreen.aspx.cs" Inherits="FrontEnd.AdministratorEditRoleScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-size: x-large; text-decoration: underline">
        <strong><em>Edit Role Screen</em></strong></p>
    <hr />
    <div align ="center">
    <span style="color: #CC0000">
    <br />
    *</span>Role Description:
    <asp:TextBox ID="txtEditRoleDescription" runat="server"></asp:TextBox>
    <br />
    <br />
    <br />
    <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
    <br />
    <br /><strong>
    <asp:Button ID="btnEditRole" runat="server" style="font-weight: bold" Text="Edit Role" OnClick="btnEditRole_Click" />
    <asp:Button ID="btnEditRoleCancel" runat="server" style="font-weight: bold" Text="Cancel" OnClick="btnEditRoleCancel_Click" />
    </strong>
        </div>
</asp:Content>
