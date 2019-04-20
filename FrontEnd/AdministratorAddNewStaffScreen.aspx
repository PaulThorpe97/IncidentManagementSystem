<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorAddNewStaffScreen.aspx.cs" Inherits="FrontEnd.AdministratorAddNewStaffScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-size: x-large; text-decoration: underline">
        <strong><em>Add New Staff Screen</em></strong></p>
    <hr />
        <div align ="center">
    <br />
            Role ID:
    <asp:TextBox ID="txtAddStaffRoleID" runat="server"></asp:TextBox>
    <br />
    <br />
    <span style="color: #CC0000">*</span>Surname:
    <asp:TextBox ID="txtAddStaffSurname" runat="server"></asp:TextBox>
    <br />
    <br />
    <span style="color: #CC0000">*</span>Forename:
    <asp:TextBox ID="txtAddStaffForename" runat="server"></asp:TextBox>
    <br />
    <br />
    <span style="color: #CC0000">*</span>Phone:
    <asp:TextBox ID="txtAddStaffPhone" runat="server"></asp:TextBox>
            <br />
    <br />
            <asp:Label ID="lblError" runat="server" style="font-weight: 700" Text="[lblError]"></asp:Label>
    <br />
    <br />
    <strong>
    <asp:Button ID="btnAddStaff" runat="server" style="font-weight: bold" Text="Add Staff Member" OnClick="btnAddStaff_Click" />
    <asp:Button ID="btnAddStaffCancel" runat="server" style="font-weight: bold" Text="Cancel" OnClick="btnAddStaffCancel_Click" />
    </strong>
            </div>
</asp:Content>
