﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorDeleteRoleScreen.aspx.cs" Inherits="FrontEnd.AdministratorDeleteRoleScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="text-decoration: underline; font-size: x-large;">
        <strong><em>Delete Role Screen </em></strong>
    </p>
    <hr />
    <br />Are you sure you wish to delete this Role?<br />
    <br /><strong>
    <asp:Button ID="btnDeleteRoleYes" runat="server" style="font-weight: bold" Text="Yes" />
    <asp:Button ID="btnDeleteRoleNo" runat="server" style="font-weight: bold" Text="No" />
    </strong>
</asp:Content>
