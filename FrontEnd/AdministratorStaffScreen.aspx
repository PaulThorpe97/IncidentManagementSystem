<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorStaffScreen.aspx.cs" Inherits="FrontEnd.AdministratorStaffScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <strong><span style="text-decoration: underline; font-size: x-large;"><em>Staff Screen</em></span><span style="font-weight: normal">&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="font-weight: 700" Text="Home" />
        </span><em>
        <asp:Button ID="btnSignOut" runat="server" Text="Sign Out" style="text-align: left; font-weight: bold; font-style: italic;" OnClick="btnSignOut_Click" />
        </em></strong>
    </p>
    <hr>
        <div align ="center">
    <p>
        <span style="text-decoration: underline">
        <em><strong style="text-align: center">
        <br />List Of Staff Members<br />
        <br></strong>
        <asp:ListBox ID="lstStaff" runat="server" Height="421px" Width="528px" style="text-align: center"></asp:ListBox>
        <br />
        <br /></em></span>
        <asp:Label ID="lblError" runat="server" style="font-weight: 700" Text="[lblError]"></asp:Label>
    </p>
            </div>
    <div align ="center">
        <p>
            Display all staff members: <span style="text-decoration: underline"><em><strong>
        <asp:Button ID="btnDisplayAllStaff" runat="server" style="font-weight: bold" Text="Display All" />
        </strong>
        <br />
        <br /></em></span>Filter by Staff Surname:<strong> <em><span style="text-decoration: underline">
        <asp:TextBox ID="txtFilterByStaffSurname" runat="server"></asp:TextBox>
        </span></em></strong>&nbsp;<strong><em><span style="text-decoration: underline"><asp:Button ID="btnSearchForStaffSurname" runat="server" Text="Search " style="font-weight: bold" OnClick="btnSearchForStaffSurname_Click" />
            </span></em></strong>
    </p>
            </div>
    <div align ="center">
        <p>
            Add new staff details:
            <asp:Button ID="btnAddStaff" runat="server" style="font-weight: 700" Text="Add" OnClick="btnAddStaff_Click" />
    </p>
            </div>
    <div align ="center">
        <p>
            Edit staff details: <em><span style="text-decoration: underline"><strong>
            <asp:Button ID="btnEditStaffDetails" runat="server" style="font-weight: bold" Text="Edit" OnClick="btnEditStaffDetails_Click" />
            <br /></strong>
            <br /></span></em>Delete staff details: <strong>
            <asp:Button ID="btnDeleteStaffDetails" runat="server" style="font-weight: bold; margin-bottom: 0px" Text="Delete" OnClick="btnDeleteStaffDetails_Click" />
            </strong>
    </p>
            </div>
</asp:Content>
