<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="HomeScreen.aspx.cs" Inherits="FrontEnd.HomeScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br>
    <strong><span style="text-decoration: underline">
    Home Screen</span>&nbsp;&nbsp;&nbsp;&nbsp; </strong><span style="text-decoration: underline"><strong>
    <em>
    <asp:Button ID="btnAddNewIncident" runat="server" Text="Add New Incident" style="font-weight: bold; font-style: italic;" />
    </em>
    </strong>
    </span>&nbsp;<span style="text-decoration: underline"><strong><em><asp:Button ID="btnSearhForClosedIncidents" runat="server" Text="Search For Closed Incidents" style="font-weight: bold; font-style: italic;" />
    </em>
    </strong>
    </span>
    <strong>
    &nbsp;<em><asp:Button ID="btnLogOut" runat="server" Text="Log Out" style="text-align: left; font-weight: bold; font-style: italic;" />
    </em>
    </strong>
    <hr>
    <em>
    <span style="text-decoration: underline"><strong>
    <br />
    List Of Incidents<br />
    <br>
    </strong>
    <asp:ListBox ID="ListBox1" runat="server" Height="421px" Width="1000px"></asp:ListBox>
    <br />
    <br />
    </span>
    </em>Display all incidents:
    <span style="text-decoration: underline"><em><strong>
    <asp:Button ID="btnDisplayAllIncidents" runat="server" style="font-weight: bold" Text="Display All" />
    </strong>
    <br />
    <br />
    </em></span>Filter by Staff ID:<strong>
    <em><span style="text-decoration: underline">
    <asp:TextBox ID="txtFilterByStaffID" runat="server"></asp:TextBox>
    </span>
    </em>
    </strong>&nbsp;<strong><em><span style="text-decoration: underline"><asp:Button ID="btnSearchForIncident" runat="server" Text="Search for Incidents" style="font-weight: bold" />
    <br />
    <br />
    </span>
    </em>
    </strong>Edit incident details: <em><span style="text-decoration: underline"><strong>
    <asp:Button ID="btnEditIncidentDetails" runat="server" style="font-weight: bold" Text="Edit" />
    <br />
    </strong>
    <br />
    </span>
    </em>Delete incident details: <strong>
    <asp:Button ID="btnDeleteIncidentDetails" runat="server" style="font-weight: bold; margin-bottom: 0px" Text="Delete" />
    </strong>
    <br />
    <br />
    </asp:Content>
