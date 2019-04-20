<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorEquipmentScreen.aspx.cs" Inherits="FrontEnd.AdministratorEquipmentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <p>
        <strong><span style="text-decoration: underline; font-size: x-large;"><em>Equipment Screen</em></span><span style="font-weight: normal">&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="font-weight: 700" Text="Home" />
            </span><em>
        <asp:Button ID="btnSignOut" runat="server" Text="Sign Out" style="text-align: left; font-weight: bold; font-style: italic;" OnClick="btnSignOut_Click" />
        </em></strong>
    </p>
    <hr>
    <div align="center">
    <p>
        <em><span style="text-decoration: underline"><strong style="text-align: center">
        <br />List Of Equipment<br />
        <br></strong>
        <asp:ListBox ID="lstEquipment" runat="server" Height="421px" Width="523px" style="text-align: center"></asp:ListBox>
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
        <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="font-weight: 700" Text="Display All" />
    </p>
        <p>
            Filter by equipment name:<strong> <em><span style="text-decoration: underline">
        <asp:TextBox ID="txtFilterByEquipmentName" runat="server"></asp:TextBox>
        </span></em></strong>&nbsp;<strong><em><span style="text-decoration: underline"><asp:Button ID="btnSearchForEquipment" runat="server" Text="Search for equipment" style="font-weight: bold" OnClick="btnSearchForEquipment_Click" />
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
