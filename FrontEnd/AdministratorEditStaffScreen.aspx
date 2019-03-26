<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorEditStaffScreen.aspx.cs" Inherits="FrontEnd.AdministratorEditStaffScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p style="font-size: x-large; text-decoration: underline">
        <strong><em>Edit Staff Screen</em></strong></p>
    <hr />
    <br />
    <span style="color: #CC0000">*</span>Allocated Role ID:
    <asp:TextBox ID="txtEditAllocatedRoleID" runat="server"></asp:TextBox>
    <br />
    <br />
    <span style="color: #CC0000">*</span>Surname:
    <asp:TextBox ID="txtEditSurname" runat="server"></asp:TextBox>
    <br />
    <br />
    <span style="color: #CC0000">*</span>Forname:
    <asp:TextBox ID="txtEditForname" runat="server"></asp:TextBox>
    <br />
    <br />
    <span style="color: #CC0000">*</span>Phone:
    <asp:TextBox ID="txtEditPhone" runat="server"></asp:TextBox>
    <br />
    <br />
    <span style="color: #CC0000">*</span>Email:
    <asp:TextBox ID="txtEditEmail" runat="server"></asp:TextBox>
    <br />
    <br />
    <span style="color: #CC0000">*</span>Password:
    <asp:TextBox ID="txtEditPassword" runat="server"></asp:TextBox>
    <br />
    <br />
    <strong>
    <asp:Button ID="btnEditStaff" runat="server" style="font-weight: bold" Text="Edit Staff Member" />
    <asp:Button ID="btnEditStaffCancel" runat="server" style="font-weight: bold" Text="Cancel" />
    </strong>
</asp:Content>
