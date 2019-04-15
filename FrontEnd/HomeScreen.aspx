<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="HomeScreen.aspx.cs" Inherits="FrontEnd.HomeScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <span style="font-size: x-large">&nbsp;</span><strong><span style="text-decoration: underline; font-size: x-large;"><em>Home Screen</em></span><span style="font-weight: normal">&nbsp;&nbsp;&nbsp;&nbsp; </span><span style="text-decoration: underline">
    <asp:Button ID="btnSearhForClosedIncidents" runat="server" Text="Search For Closed Incidents" style="font-weight: bold; " />
        </span><asp:Button ID="btnLogOut" runat="server" Text="Log Out" style="text-align: left; font-weight: bold; " />
        </strong>
    </p>
    <hr>
    <div align="center">
    <em>
    <span style="text-decoration: underline"><strong style="text-align: center">
    <br />
    List Of Incidents<br />
    <br>
    </strong>
    <asp:ListBox ID="lstIncidents" runat="server" Height="421px" Width="469px" style="text-align: left"></asp:ListBox>
    </span>
    </em>
    <p>
        <asp:Label ID="lblError" runat="server" style="font-weight: 700" Text="[lblError]"></asp:Label>
        <em>
        <span style="text-decoration: underline">
    <br />
    </span>
    </em><span style="text-decoration: underline"><em>
    <br />
    </em></span>Filter by Staff ID:<strong>
    <em><span style="text-decoration: underline">
    <asp:TextBox ID="txtFilterByStaffID" runat="server"></asp:TextBox>
    </span>
    </em>
    </strong>&nbsp;<strong><em><span style="text-decoration: underline"><asp:Button ID="btnSearchForIncident" runat="server" Text="Search for Incidents" style="font-weight: bold" OnClick="btnSearchForIncident_Click" />
    </span>
    </em>
    </strong>
    </p>
        <p>
    
            <strong><em><span style="text-decoration: underline">
    <br />
    </span>
    </em>
    </strong>Add new incident: <strong><em><span style="text-decoration: underline">
        <asp:Button ID="btnAddNewIncident" runat="server" Text="Add New Incident" style="font-weight: bold; font-style: italic;" OnClick="btnAddNewIncident_Click" />
    </span>
    </em>
    </strong>
    </p>
        <p>
            <strong><em><span style="text-decoration: underline">
    <br />
    </span>
    </em>
    </strong>Edit incident details: <em><span style="text-decoration: underline"><strong>
    <asp:Button ID="btnEditIncidentDetails" runat="server" style="font-weight: bold" Text="Edit" OnClick="btnEditIncidentDetails_Click" />
    <br />
    </strong>
    <br />
    </span>
    </em>Delete incident details: <strong>
    <asp:Button ID="btnDeleteIncidentDetails" runat="server" style="font-weight: bold; margin-bottom: 0px" Text="Delete" />
    </strong>
    </p>
        <p>

   
        Close incident:
        <asp:Button ID="btnCloseIncident" runat="server" style="font-weight: 700" Text="Close" />
    </p>
    <br />
    <br />
        </div>
    </asp:Content>
