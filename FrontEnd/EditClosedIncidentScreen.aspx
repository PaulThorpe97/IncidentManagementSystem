<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="EditClosedIncidentScreen.aspx.cs" Inherits="FrontEnd.EditClosedIncidentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <span style="text-decoration: underline">    <span style="font-size: large; color: #000000"><strong><em>
    <br />
    </em></strong>
    </span>
    <strong><em>
<span style="font-size: x-large; color: #000000">Edit Closed Incident Screen</span></em></strong></span><span style="font-size: large; color: #000000">&nbsp;&nbsp;&nbsp;&nbsp; <strong><em>
    <asp:Button ID="btnClosedEditSave" runat="server" style="font-weight: bold" Text="Save" />
    </em></strong><em><strong>
    <asp:Button ID="btnClosedEditCancel" runat="server" style="font-weight: bold" Text="Cancel" />
    <br />
    </strong></em><br />
    </span>
    <hr />
    <span style="color: #CC0000">
    <br />
    *</span>Incident ID:
    <asp:TextBox ID="btnClosedIncidentID" runat="server"></asp:TextBox>
    <br />
    <br />
    <span style="color: #CC0000">*</span>Date of closure:
    <asp:TextBox ID="txtClosedIncidentDateClosed" runat="server"></asp:TextBox>
    <br />
    <br />How was this incident Resolved?<br />
    <br />
    <asp:TextBox ID="txtIncidentResolution" runat="server" Height="211px" Width="1030px"></asp:TextBox>
</asp:Content>
