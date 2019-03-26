<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="CloseIncidentScreen.aspx.cs" Inherits="FrontEnd.CloseIncidentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-size: large">
        <span style="text-decoration: underline; font-size: x-large;"><em>
        <strong>Close Incident Screen</strong></em></span>&nbsp;&nbsp;&nbsp;&nbsp; <strong>
        <asp:Button ID="btnCloseOK" runat="server" style="font-weight: bold" Text="OK" />
        <asp:Button ID="btnCloseCancel" runat="server" style="font-weight: bold" Text="Cancel" />
        </strong></p>
    <hr />
    <span style="color: #CC0000">*</span>Incident ID:
    <asp:TextBox ID="btnClosedIncidentID" runat="server"></asp:TextBox>
    <br />
    <br />
    <span style="color: #CC0000">*</span>Date of closure:
    <asp:TextBox ID="txtClosedIncidentDateClosed" runat="server"></asp:TextBox>
    <br />
    <br />
    How was this incident Resolved?<br />
    <br />
    <asp:TextBox ID="txtIncidentResolution" runat="server" Height="211px" Width="1030px"></asp:TextBox>
    <br />
    <br />
</asp:Content>
