﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorDeleteEquipmentScreen.aspx.cs" Inherits="FrontEnd.AdministratorDeleteEquipmentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="text-decoration: underline; font-size: x-large;">
        <strong><em>Delete Equipment Screen </em></strong>
    </p>
    <hr />
    <br />Are you sure you wish to delete this equipment?<br />
    <br /><strong>
    <asp:Button ID="btnDeleteEquipmentYes" runat="server" style="font-weight: bold" Text="Yes" />
    <asp:Button ID="btnDeleteEquipmentNo" runat="server" style="font-weight: bold" Text="No" />
    </strong>
</asp:Content>
