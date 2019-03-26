<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorDeleteStaffScreen.aspx.cs" Inherits="FrontEnd.AdministratorDeleteStaffScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="text-decoration: underline; font-size: x-large;">
        <strong><em>Delete Staff Screen </em></strong>
    </p>
    <hr />
    <br />Are you sure you wish to delete this staff member?<br />
    <br /><strong>
    <asp:Button ID="btnDeleteStaffYes" runat="server" style="font-weight: bold" Text="Yes" />
    <asp:Button ID="btnDeleteStaffNo" runat="server" style="font-weight: bold" Text="No" />
    </strong>
</asp:Content>
