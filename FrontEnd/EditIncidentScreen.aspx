<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="EditIncidentScreen.aspx.cs" Inherits="FrontEnd.EditIncidentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <span style="text-decoration: underline; font-size: x-large;"><strong><em>Edit Incident Screen</em></strong></span><span style="font-size: x-large;">&nbsp;&nbsp;&nbsp;&nbsp; </span>
    <asp:Button ID="btnEditIncident" runat="server" style="font-weight: bold" Text="Edit Incident" OnClick="btnEditEquipment_Click" />
    <asp:Button ID="btnEditCancel" runat="server" style="font-weight: bold" Text="Cancel" OnClick="btnEditCancel_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    <div align="center">
    <asp:Label ID="lblError" runat="server" style="font-weight: 700" Text="[lblError]"></asp:Label>
        </div>
    <hr>
    <div align="center">
    <p>
        <span style="color: #CC0000">
        *</span>Staff ID:&nbsp;
        <asp:TextBox ID="txtEditStaffID" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;
        Assign Incident to: 
        <asp:TextBox ID="txtEditAssignIncidentTo" runat="server"></asp:TextBox>
        <span style="color: #CC0000">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *</span>Date Occured:
        <asp:TextBox ID="txtEditIncidentDateOccured" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <hr>
    <p>
        <span style="color: #CC0000">*</span>Equipment ID:
        <asp:TextBox ID="txtEditEquipmentID" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;</p>
    <p>
        &nbsp;</p>
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
    </em></strong></span><span style="color: #CC0000">*</span>Staff ID: <asp:TextBox ID="txtCommentStaffID" runat="server"></asp:TextBox>
    <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtComment" runat="server" Width="782px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnCommentsAdd" runat="server" style="font-weight: bold" Text="Add" />
    <asp:Button ID="btnCommentsCancel" runat="server" style="font-weight: bold" Text="Cancel" />
    <br />
    <br />
    </strong>Display Comment History:
    <asp:Button ID="btnDisplayComments" runat="server" Text="Display Comments" />
    <br />
    <br />
    <asp:ListBox ID="lstCommentHistory" runat="server" Height="125px" Width="1220px"></asp:ListBox>
        </div>
</asp:Content>
