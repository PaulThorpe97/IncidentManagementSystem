<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorEditIncidentScreen.aspx.cs" Inherits="FrontEnd.AdministratorEditIncidentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <p>
        <span style="text-decoration: underline; font-size: x-large;"><strong><em>Edit Incident Screen</em></strong></span><span style="font-size: x-large;">&nbsp;&nbsp;&nbsp;&nbsp; </span>
    <asp:Button ID="btnEditIncident" runat="server" style="font-weight: bold" Text="Edit Incident" OnClick="btnEditIncident_Click"/>
         <asp:Button ID="btnCloseIncident" runat="server" style="font-weight: 700" Text="Close Incident" OnClick="btnCloseIncident_Click" />
         <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" style="font-weight: 700" Text="Home" />
    <asp:Button ID="btnEditCancel" runat="server" style="font-weight: bold" Text="Cancel" OnClick="btnEditCancel_Click"/>
        &nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    <div align="center">
    <asp:Label ID="lblError" runat="server" style="font-weight: 700" Text="[lblError]"></asp:Label>
        </div>
    <hr>
    <div align="center">
    <p>
        <span style="color: #CC0000">
        *<span style="color: #000000">Incident ID:</span>
        <asp:TextBox ID="txtEditIncidentID" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        *</span>Staff ID:&nbsp;
        <asp:TextBox ID="txtEditStaffID" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;
        Assign Incident to: 
        <asp:TextBox ID="txtEditAssignIncidentTo" runat="server"></asp:TextBox>
        <span style="color: #CC0000">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *</span>Date Occured/Last Edited:
        <asp:TextBox ID="txtEditIncidentDateOccured" runat="server"></asp:TextBox>
    </p>
    <hr>
    <p>
        <span style="color: #CC0000">*</span>Equipment ID:
        <asp:TextBox ID="txtEditEquipmentID" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;</p>
    <hr>
    <p style="text-decoration: underline">
        <strong><em>Incident Priority:</em></strong></p>
    <p>
        a) <span style="color: #CC0000">High</span>:<asp:CheckBox ID="chkEditHigh" runat="server" />
    &nbsp;&nbsp;&nbsp;&nbsp;
        b) <span style="color: #FF9900">Medium</span>:<asp:CheckBox ID="chkEditMedium" runat="server" />
    &nbsp;&nbsp;&nbsp;&nbsp;
        c) <span style="color: #009933">Low</span>:<asp:CheckBox ID="chkEditLow" runat="server" />
    </p>
    <hr>
    <p style="text-decoration: underline">
        <strong><em>Incident Status:</em></strong></p>
    <p>
        a) Pending<asp:CheckBox ID="chkEditPending" runat="server" />
    &nbsp;&nbsp;&nbsp;&nbsp;
        b) In Progress:<asp:CheckBox ID="chkEditInProgress" runat="server" />
    &nbsp;&nbsp;&nbsp;&nbsp; c) Close<asp:CheckBox ID="chkEditClose" runat="server" />
    </p>
    <hr>
    <br /><span style="color: #CC0000">*</span><span style="text-decoration: underline"><em><strong>Incident Description:<br />
    <br />
    <asp:TextBox ID="txtEditIncidentDescription" runat="server" Height="50px" Width="637px"></asp:TextBox>
    <br />
    <br />
    </strong></em></span>
    <hr>
    <span style="text-decoration: underline"><strong><em>
    <br />
    Comments:<br />
    <br />
    </em></strong></span><span style="color: #CC0000">*</span><span style="color: #000000">Incident ID:</span><span style="color: #CC0000">
        <asp:TextBox ID="txtCommentIncidentID" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; *</span>Staff ID: <asp:TextBox ID="txtCommentStaffID" runat="server"></asp:TextBox>
    <strong style="font-weight: 700">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtComment" runat="server" Width="782px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnCommentAdd" runat="server" style="font-weight: bold" Text="Add" OnClick="btnCommentAdd_Click"/>
    <br />
    <br />
    </strong>&nbsp;<asp:Button ID="btnSearchForComment" runat="server" Text="Search For Comment" style="font-weight: 700" OnClick="btnSearchForComment_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        Edit Comment: <strong>
        <asp:Button ID="btnEditComment" runat="server" style="font-weight: bold" Text="Edit " OnClick="btnEditComment_Click" />
&nbsp;&nbsp;&nbsp; </strong>Delete Comment:
        <asp:Button ID="btnDeleteComment" runat="server" style="font-weight: 700" Text="Delete" OnClick="btnDeleteComment_Click"/>
&nbsp;<strong><br />
    <br />
    <asp:ListBox ID="lstComment" runat="server" Height="183px" Width="1220px" style="font-weight: bold"></asp:ListBox>
        </strong>
        </div>
</asp:Content>
