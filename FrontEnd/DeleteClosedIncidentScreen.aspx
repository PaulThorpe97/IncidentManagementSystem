<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="DeleteClosedIncidentScreen.aspx.cs" Inherits="FrontEnd.DeleteClosedIncidentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="text-decoration: underline; font-size: x-large;">
        <strong><em>Delete Closed Incident Screen </em></strong>
    </p>
    <hr />
    <br />Are you sure you wish to delete this closed incident?<br />
    <br /><strong>
    <asp:Button ID="btnDeleteClosedIncidentYes" runat="server" style="font-weight: bold" Text="Yes" />
    <asp:Button ID="btnDeleteClosedIncidentNo" runat="server" style="font-weight: bold" Text="No" />
    </strong>
</asp:Content>
