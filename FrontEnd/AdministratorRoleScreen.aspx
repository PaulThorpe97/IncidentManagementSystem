<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorRoleScreen.aspx.cs" Inherits="FrontEnd.AdministratorRoleScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <strong><span style="text-decoration: underline; font-size: x-large;"><em>Role Screen</em></span><span style="font-weight: normal">&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="font-weight: 700; height: 26px;" Text="Home" />
        </span><em>
        <asp:Button ID="btnSignOut" runat="server" Text="Sign Out" style="text-align: left; font-weight: bold; font-style: italic;" OnClick="btnSignOut_Click"/>
        </em></strong>
    </p>
    <hr>
    <div align="center">
    <p>
        <em><span style="text-decoration: underline"><strong style="text-align: center">
        <br />List Of Roles<br />
        <br></strong>
        <asp:ListBox ID="lstRole" runat="server" Height="316px" Width="392px" style="text-align: center"></asp:ListBox>
        </span></em>
    </p>
    <p>
        <em>
        <br />
        </em>
        <asp:Label ID="lblError" runat="server" style="font-weight: 700" Text="[lblError]"></asp:Label>
    </p>
        <p>
            Display<em> all:&nbsp;
            <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="font-weight: 700" Text="Display All" />
            <span style="text-decoration: underline">
        <br />
        <br /></span></em>Filter by Role Description:<strong> <em><span style="text-decoration: underline">
        <asp:TextBox ID="txtFilterByRoleDescription" runat="server"></asp:TextBox>
        </span></em></strong>&nbsp;<strong><em><span style="text-decoration: underline"><asp:Button ID="btnSearchForRole" runat="server" Text="Search for role" style="font-weight: bold" OnClick="btnSearchForRole_Click" />
        </span></em></strong>
    </p>
    <p>
        Add role details:
        <asp:Button ID="btnAddRole" runat="server" style="font-weight: 700" Text="Add" OnClick="btnAddRole_Click" />
        <strong><em><span style="text-decoration: underline">
        <br />
        <br /></span></em></strong>Edit role details: <em><span style="text-decoration: underline"><strong>
        <asp:Button ID="btnEditRoleDetails" runat="server" style="font-weight: bold" Text="Edit" OnClick="btnEditRoleDetails_Click" />
        <br /></strong>
        <br /></span></em>Delete role details: <strong>
        <asp:Button ID="btnDeleteRoleDetails" runat="server" style="font-weight: bold; margin-bottom: 0px" Text="Delete" OnClick="btnDeleteRoleDetails_Click" />
        </strong>
    </p>
        </div>
</asp:Content>
