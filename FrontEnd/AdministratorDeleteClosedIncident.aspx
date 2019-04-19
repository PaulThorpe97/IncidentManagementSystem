<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorDeleteClosedIncident.aspx.cs" Inherits="FrontEnd.AdministratorDeleteClosedIncident" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           <p style="font-size: x-large; text-decoration: underline"><strong><em>Delete Closed Incident Screen </em></strong>
    </p>
    <hr />
    <div align ="center">
    <br />Are you sure you wish to delete this closed incident?<br />
    <br /><strong>
    <asp:Button ID="btnDeleteClosedIncidentYes" runat="server" style="font-weight: bold" Text="Yes" OnClick="btnDeleteClosedIncidentYes_Click"/>
    <asp:Button ID="btnDeleteClosedncidentNo" runat="server" style="font-weight: bold" Text="No" OnClick="btnDeleteClosedncidentNo_Click"/>
    </strong>
            </div>
</asp:Content>
