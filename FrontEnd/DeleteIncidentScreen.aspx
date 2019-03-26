<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="DeleteIncidentScreen.aspx.cs" Inherits="FrontEnd.DeleteIncidentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="text-decoration: underline; font-size: x-large;">
        <strong><em>Delete Incident Screen </em></strong>
    </p>
    <hr />
    <br />
    Are you sure you wish to delete this incident?<br />
    <br />
    <strong>
    <asp:Button ID="btnDeleteIncidentYes" runat="server" style="font-weight: bold" Text="Yes" />
    <asp:Button ID="btnDeleteIncidentNo" runat="server" style="font-weight: bold" Text="No" />
    </strong>
</asp:Content>
