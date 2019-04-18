<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorDeleteIncidentScreen.aspx.cs" Inherits="FrontEnd.AdministratorDeleteIncidentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <p style="text-decoration: underline; font-size: x-large;">
        <strong><em>Delete Incident Screen </em></strong>
    </p>
    <hr />
    <div align="center">
    <br />
    Are you sure you wish to delete this incident?<br />
    <br />
    <strong>
    <asp:Button ID="btnDeleteIncidentYes" runat="server" style="font-weight: bold" Text="Yes" OnClick="btnDeleteIncidentYes_Click" />
    <asp:Button ID="btnDeleteIncidentNo" runat="server" style="font-weight: bold" Text="No" OnClick="btnDeleteIncidentNo_Click" />
    </strong>
        </div>
</asp:Content>
