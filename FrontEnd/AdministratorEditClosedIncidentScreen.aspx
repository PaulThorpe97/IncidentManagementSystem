<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorEditClosedIncidentScreen.aspx.cs" Inherits="FrontEnd.AdministratorEditClosedIncidentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           <p style="font-size: x-large; ">
        <strong><em>Edit Closed Incident Screen&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="font-weight: 700" Text="Home" />
            </em></strong></p>
    <hr />
    <div align="center">
    <br /><span style="color: #CC0000">*</span><span style="color: #000000">Incident ID</span>:
    <asp:TextBox ID="txtEditIncidentID" runat="server"></asp:TextBox>
        <br />
        <br />
        <span style="color: #CC0000">*</span><span style="color: #000000">Staff ID</span>:
    <asp:TextBox ID="txtEditStaffID" runat="server"></asp:TextBox>
        <br />
        <br />
        <span style="color: #CC0000">*</span><span style="color: #000000">Date of Closure</span>:
    <asp:TextBox ID="txtEditDateClosed" runat="server"></asp:TextBox>
    <br />
    <br />
    <br />
    <br /><span style="color: #CC0000">*</span><span style="color: #000000">How was this incident resolved?:</span><br />
    <br />
    <asp:TextBox ID="txtEditClosedIncidentDescription" runat="server" Height="92px" Width="365px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
    <br />
    <br /><strong>
    <asp:Button ID="btnEditClosedIncident" runat="server" style="font-weight: bold" Text="Edit" OnClick="btnEditClosedIncident_Click"/>
    <asp:Button ID="btnEditClosedIncidentCancel" runat="server" style="font-weight: bold" Text="Cancel" OnClick="btnEditClosedIncidentCancel_Click"  />
    </strong>
        </div>
</asp:Content>
