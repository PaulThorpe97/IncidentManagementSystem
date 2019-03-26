<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorAddNewStaffScreen.aspx.cs" Inherits="FrontEnd.AdministratorAddNewStaffScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-size: x-large; text-decoration: underline">
        <strong><em>Add New Staff Screen</em></strong></p>
    <hr />
    <br />
    <span style="color: #CC0000">*</span>Allocated Role ID:
    <asp:TextBox ID="txtAddAllocatedRoleID" runat="server"></asp:TextBox>
    <br />
    <br />
    <span style="color: #CC0000">*</span>Surname:
    <asp:TextBox ID="txtAddSurname" runat="server"></asp:TextBox>
    <br />
    <br />
    <span style="color: #CC0000">*</span>Forname:
    <asp:TextBox ID="txtAddForname" runat="server"></asp:TextBox>
    <br />
    <br />
    <span style="color: #CC0000">*</span>Phone:
    <asp:TextBox ID="txtAddPhone" runat="server"></asp:TextBox>
    <br />
    <br />
    <span style="color: #CC0000">*</span>Email:
    <asp:TextBox ID="txtAddEmail" runat="server"></asp:TextBox>
    <br />
    <br />
    <span style="color: #CC0000">*</span>Password:
    <asp:TextBox ID="txtAddPassword" runat="server"></asp:TextBox>
    <br />
    <br />
    <strong>
    <asp:Button ID="btnAddStaff" runat="server" style="font-weight: bold" Text="Add Staff Member" />
    <asp:Button ID="btnAddStaffCancel" runat="server" style="font-weight: bold" Text="Cancel" />
    </strong>
</asp:Content>
