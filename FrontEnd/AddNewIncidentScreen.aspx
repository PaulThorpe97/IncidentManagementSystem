<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AddNewIncidentScreen.aspx.cs" Inherits="FrontEnd.AddNewIncidentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <span style="text-decoration: underline; font-size: x-large;">
        <strong><em>Add New Incident Screen</em></strong></span>&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    <hr>
    <p>
        <span style="color: #CC0000">*</span>Staff ID:&nbsp;
        <asp:TextBox ID="txtAddStaffID" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;
        Assign Incident to: <asp:TextBox ID="txtAssignIncidentTo" runat="server"></asp:TextBox>
        <span style="color: #CC0000">&nbsp;&nbsp;&nbsp;&nbsp; *</span>Logged by: <asp:TextBox ID="txtLoggedBy" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp; <span style="color: #CC0000">*</span>Date of Occurrence:
        <asp:TextBox ID="txtAddDateOfOccurrence" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <hr>
    <p>
        <span style="color: #CC0000">*</span>Equipment Name:
        <asp:TextBox ID="btnAddEquipmentName" runat="server" OnTextChanged="btnAddNewIncidentEquipmentName_TextChanged"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;
        Hardware:
        <asp:CheckBox ID="chkHardware" runat="server" />
    &nbsp;&nbsp;&nbsp;&nbsp;
        Software:<asp:CheckBox ID="chkSoftware" runat="server" />
    </p>
    <p>
        &nbsp;</p>
    <hr>
    <p style="text-decoration: underline">
        <strong><em>Incident Priority:</em></strong></p>
    <p>
        a) <span style="color: #CC0000">High</span>:<asp:CheckBox ID="chkHigh" runat="server" />
    &nbsp;&nbsp;&nbsp;&nbsp;
        b) <span style="color: #FF9900">Medium</span>:<asp:CheckBox ID="chkMedium" runat="server" />
    &nbsp;&nbsp;&nbsp;&nbsp;
        c) <span style="color: #009933">Low</span>:<asp:CheckBox ID="chkLow" runat="server" />
    </p>
    <p>
        &nbsp;</p>
    <hr>
    <p style="text-decoration: underline">
        <strong><em>Incident Status:</em></strong></p>
    <p>
        a) Pending<asp:CheckBox ID="chkPending" runat="server" />
    &nbsp;&nbsp;&nbsp;&nbsp;
        b) In Progress:<asp:CheckBox ID="chkInProgress" runat="server" />
    </p>
    <p>
        &nbsp;</p>
    <hr>
    <br />
    <span style="color: #CC0000">*</span><span style="text-decoration: underline"><em><strong>Incident Description:<br />
    <br />
    <asp:TextBox ID="txtIncidentDescription" runat="server" Height="78px" Width="637px"></asp:TextBox>
    <br />
    <br />
    <br />
    </strong></em></span>
        <asp:Button ID="btnAddIncident" runat="server" style="font-weight: bold" Text="Add Incident" />
        &nbsp;<asp:Button ID="btnAddCancel" runat="server" style="font-weight: bold" Text="Cancel" />
    </asp:Content>
