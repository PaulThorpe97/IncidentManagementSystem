<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="FrontEnd.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!DOCTYPE html>

<html>
<head>
    <title></title>
</head>
<body>
    <div id="form1" runat="server">
            <div>
            <br />
            <h1>Sign-in<br />
            </h1>
            <table style="width: 100%;">
                <tr>
                    <td style="width: 192px">
            <asp:Label ID="lblEMail" runat="server" Text="E Mail Address"></asp:Label>
                    </td>
                    <td><asp:TextBox ID="txtEMail" runat="server" Width="283px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 192px">
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="283px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 192px">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
&nbsp;&nbsp;<br />
                <br />
                <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
&nbsp;</div>
        <asp:Button ID="btnSignIn" runat="server" Text="Sign-in" OnClick="btnSignIn_Click" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
&nbsp;</div>
</body>
</html>
</asp:Content>
