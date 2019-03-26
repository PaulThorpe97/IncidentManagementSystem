<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorEquipmentScreen.aspx.cs" Inherits="FrontEnd.AdministratorEquipmentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <strong><span style="text-decoration: underline; font-size: x-large;"><em>Equipment Screen</em></span><span style="font-weight: normal">&nbsp;&nbsp;&nbsp;&nbsp; </span><span style="text-decoration: underline"><em>
        <asp:Button ID="btnAddNewEquipment" runat="server" Text="Add New Equipment" style="font-weight: bold; font-style: italic;" />
        </em></span><em>
        <asp:Button ID="btnLogOut" runat="server" Text="Log Out" style="text-align: left; font-weight: bold; font-style: italic;" />
        </em></strong>
    </p>
    <hr>
    <p>
        <em><span style="text-decoration: underline"><strong style="text-align: center">
        <br />List Of Equipment<br />
        <br></strong>
        <asp:ListBox ID="lstEquipment" runat="server" Height="421px" Width="1000px" style="text-align: center"></asp:ListBox>
        <br />
        <br /></span></em>Display all equipment: <span style="text-decoration: underline"><em><strong>
        <asp:Button ID="btnDisplayAllEquipment" runat="server" style="font-weight: bold" Text="Display All" />
        </strong>
        <br />
        <br /></em></span>Filter by equipment type:<strong> <em><span style="text-decoration: underline">
        <asp:TextBox ID="txtFilterByStaffID" runat="server"></asp:TextBox>
        </span></em></strong>&nbsp;<strong><em><span style="text-decoration: underline"><asp:Button ID="btnSearchForEquipment" runat="server" Text="Search for equipment" style="font-weight: bold" />
        <br />
        <br /></span></em></strong>Edit equipment details: <em><span style="text-decoration: underline"><strong>
        <asp:Button ID="btnEditEquipmentDetails" runat="server" style="font-weight: bold" Text="Edit" />
        <br /></strong>
        <br /></span></em>Delete equipment details: <strong>
        <asp:Button ID="btnDeleteEquipmentDetails" runat="server" style="font-weight: bold; margin-bottom: 0px" Text="Delete" />
        </strong>
    </p>
</asp:Content>
