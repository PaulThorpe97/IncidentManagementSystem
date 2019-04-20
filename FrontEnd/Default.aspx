<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FrontEnd.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>

<html>
<head>
    <title></title>
</head>
<body>
    <div id="form1" runat="server">
        <div>
            <asp:Button ID="btnSignIn" runat="server" OnClick="btnSignIn_Click" Text="Sign In" width="160px" style="font-weight: 700" />
            <br />
            <br />
            <asp:Button ID="btnSignUp" runat="server" OnClick="btnSignUp_Click" Text="Sign Up" width="160px" style="font-weight: 700" />
            <br />
            <br />
            <asp:Button ID="btnReSet" runat="server" OnClick="btnReSet_Click" Text="Re Set Password" width="160px" style="font-weight: 700" />
            <br />
            <br />
            <asp:Button ID="btnChangePassword" runat="server" OnClick="btnChangePassword_Click" Text="Change Password" Width="160px" style="font-weight: 700" />
            <br />
            <br />
            <asp:Button ID="btnSignOut" runat="server" OnClick="btnSignOut_Click" Text="Sign Out" width="160px" style="font-weight: 700" />
            <br />
            <br />
            <asp:Button ID="btnPIMS" runat="server" style="font-weight: 700" Text="PIMS" Width="160px" OnClick="btnPIMS_Click" />
            <br />
            <br />
            <asp:Button ID="btnPIMSAdmin" runat="server" OnClick="btnPIMSAdmin_Click" style="font-weight: 700" Text="PIMSAdmin" Width="160px" />
            <br />
        </div>
    </div>
</body>
</html>

</asp:Content>
