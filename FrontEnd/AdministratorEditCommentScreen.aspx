<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorEditCommentScreen.aspx.cs" Inherits="FrontEnd.AdministratorEditCommentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <p style="font-size: x-large; text-decoration: underline">
        <strong><em>Edit Comment Screen</em></strong></p>
    <hr />
    <div align ="center">
    <span style="color: #CC0000">
    <br />
    *</span><span style="color: #000000">Incident ID</span>:
    <asp:TextBox ID="txtEditIncidentID" runat="server"></asp:TextBox>
        <br />
        <br />
    <span style="color: #CC0000">
    *</span>Staff<span style="color: #000000"> ID</span>:
    <asp:TextBox ID="txtEditStaffID" runat="server"></asp:TextBox>
        <br />
        <br />
    <span style="color: #CC0000">
    *</span><span style="color: #000000">Comment</span>:
    <strong>
    <asp:TextBox ID="txtEditComment" runat="server" Width="782px"></asp:TextBox>
    </strong>
    <br />
    <br />
    <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
    <br />
    <br /><strong>
    <asp:Button ID="btnEditComment" runat="server" style="font-weight: bold" Text="Edit Comment" OnClick="btnEditComment_Click" />
    <asp:Button ID="btnEditCommentCancel" runat="server" style="font-weight: bold" Text="Cancel" OnClick="btnEditCommentCancel_Click" />
    </strong>
        </div>
</asp:Content>
