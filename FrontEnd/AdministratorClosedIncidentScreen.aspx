<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorClosedIncidentScreen.aspx.cs" Inherits="FrontEnd.AdministratorClosedIncidentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <p>
        <strong><span style="text-decoration: underline; font-size: x-large;"><em>Closed Incident Screen</em></span><span style="font-weight: normal">&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="font-weight: 700" Text="Home" />
            </span><em>
        <asp:Button ID="btnSignOut" runat="server" Text="Sign Out" style="text-align: left; font-weight: bold; font-style: italic;" OnClick="btnSignOut_Click" />
        </em></strong>
    </p>
    <hr>
    <div align="center">
    <p>
        <em><span style="text-decoration: underline"><strong style="text-align: center">
        <br />List Of Closed Incidents<br />
        <br></strong>
        <asp:ListBox ID="lstClosedIncident" runat="server" Height="421px" Width="523px" style="text-align: center"></asp:ListBox>
        </span></em>
    </p>
    <p>
        <strong>
        <br />
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </strong>
    </p>
    <p>
        Display All:
        <asp:Button ID="btnDisplayAll" runat="server" style="font-weight: 700" Text="Display All" />
    </p>
        <p>
            Filter by Incident ID:<strong> <em><span style="text-decoration: underline">
        <asp:TextBox ID="txtFilterByIncidentID" runat="server"></asp:TextBox>
        </span></em></strong>&nbsp;<strong><em><span style="text-decoration: underline"><asp:Button ID="btnFilterByIncidentID" runat="server" Text="Search for Closed Incidents" style="font-weight: bold" OnClick="btnFilterByIncidentID_Click"/>
        </span></em></strong><em><strong>&nbsp;&nbsp;&nbsp; <span style="font-weight: normal">&nbsp;Filter by Staff ID: </span><span style="text-decoration: underline">
            <asp:TextBox ID="txtFilterByStaffID" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnFilterByStaffID" runat="server" OnClick="btnFilterByStaffID_Click" style="font-weight: 700" Text="Search for Closed Incidents" />
        <br />
        <br /></span></strong></em>Edit Closed Incident details: <em><span style="text-decoration: underline"><strong>
        <asp:Button ID="btnEditEquipmentDetails" runat="server" style="font-weight: bold" Text="Edit" OnClick="btnEditEquipmentDetails_Click" />
        <br /></strong>
        <br /></span></em>Delete Closed Incident details: <strong>
        <asp:Button ID="btnDeleteClosedIncidentDetails" runat="server" style="font-weight: bold; margin-bottom: 0px" Text="Delete" OnClick="btnDeleteClosedIncidentDetails_Click"/>
        </strong>
    </p>
    <p>
        &nbsp;</p>
        </div>
</asp:Content>
