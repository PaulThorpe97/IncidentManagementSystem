<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorEquipmentScreen.aspx.cs" Inherits="FrontEnd.AdministratorEquipmentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <p>
        <strong><span style="text-decoration: underline; font-size: x-large;"><em>Equipment Screen</em></span><span style="font-weight: normal">&nbsp;&nbsp;&nbsp;&nbsp; </span><em>
        <asp:Button ID="btnLogOut" runat="server" Text="Log Out" style="text-align: left; font-weight: bold; font-style: italic;" />
        </em></strong>
    </p>
    <hr>
    <div id="printDiv" runat="server" align="center">
    <p>
        <asp:Button ID="btnPDF" runat="server" Text="Export to PDF" OnClick="btnPDF_Click" />
        <em><span style="text-decoration: underline"><strong style="text-align: center">
        <br />List Of Equipment<br />
        <br></strong>
        <asp:ListBox ID="lstEquipment" runat="server" Height="421px" Width="523px" style="text-align: center"></asp:ListBox>
        </span></em>
    </p>
        </div>
    <div align="center">
    <p>
        <strong>
        <br />
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </strong>
    </p>
    <p>
        <span style="text-decoration: underline"><em>
        <br /></em></span>Filter by equipment name:<strong> <em><span style="text-decoration: underline">
        <asp:TextBox ID="txtFilterByEquipmentName" runat="server"></asp:TextBox>
        </span></em></strong>&nbsp;<strong><em><span style="text-decoration: underline"><asp:Button ID="btnSearchForEquipment" runat="server" Text="Search for equipment" style="font-weight: bold" />
        </span></em></strong>
    </p>
    <p>
        <span style="font-size: medium">Add equipment details: </span><strong>
        <asp:Button ID="btnAddEquipment" runat="server" style="font-weight: bold" Text="Add" OnClick="btnAddEquipment_Click"/>
        </strong><em><strong><span style="text-decoration: underline">
        <br />
        <br /></span></strong></em>Edit equipment details: <em><span style="text-decoration: underline"><strong>
        <asp:Button ID="btnEditEquipmentDetails" runat="server" style="font-weight: bold" Text="Edit" OnClick="btnEditEquipmentDetails_Click" />
        <br /></strong>
        <br /></span></em>Delete equipment details: <strong>
        <asp:Button ID="btnDeleteEquipmentDetails" runat="server" style="font-weight: bold; margin-bottom: 0px" Text="Delete" OnClick="btnDeleteEquipmentDetails_Click" />
        </strong>
    </p>
    <p>
        &nbsp;</p>
        </div>
</asp:Content>
