<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorDeleteCommentScreen.aspx.cs" Inherits="FrontEnd.AdministratorDeleteCommentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <p style="font-size: x-large; text-decoration: underline"><strong><em>Delete Comment Screen </em></strong>
    </p>
    <hr />
        <div align ="center">
    <br />Are you sure you wish to delete this comment?<br />
    <br /><strong>
    <asp:Button ID="btnDeleteCommentYes" runat="server" style="font-weight: bold" Text="Yes" OnClick="btnDeleteCommentYes_Click"/>
    <asp:Button ID="btnDeleteCommentNo" runat="server" style="font-weight: bold" Text="No" OnClick="btnDeleteCommentNo_Click"/>
    </strong>
            </div>
</asp:Content>
