<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="HomeScreen.aspx.cs" Inherits="FrontEnd.HomeScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br>
    <strong><span style="text-decoration: underline">
    Home Screen</span>&nbsp;&nbsp;&nbsp;&nbsp; </strong><span style="text-decoration: underline"><strong>
    <em>
    <asp:Button ID="btnAddNewIncident" runat="server" Text="Add New Incident" style="font-weight: bold" />
    </em>
    <asp:Button ID="btnSearchForIncident" runat="server" Text="Search for Incident" style="font-weight: bold" />
    <asp:Button ID="btnSearhForClosedIncidents" runat="server" Text="Search For Closed Incidents" style="font-weight: bold" />
    </strong>
    </span>
    <strong>
    <asp:Button ID="btnLogOut" runat="server" Text="Log Out" style="text-align: left; font-weight: bold;" />
    </strong>
    <hr>
    <span style="text-decoration: underline"><em><strong>
    <br />
    List Of Incidents<br />
    <br>
    </strong>
    <asp:ListBox ID="ListBox1" runat="server" Height="421px" Width="1000px"></asp:ListBox>
    </em></span>
    <br />
    <br />
    </asp:Content>
