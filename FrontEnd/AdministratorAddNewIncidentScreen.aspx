<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AdministratorAddNewIncidentScreen.aspx.cs" Inherits="FrontEnd.AdministratorAddNewIncidentScreen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <p>
        <span style="text-decoration: underline; font-size: x-large;">
        <strong><em>Add New Incident Screen</em></strong></span>&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    <hr>
    <div align="center">
    <p>
        <span style="color: #CC0000">*</span>Staff ID:&nbsp;
        <asp:TextBox ID="txtAddStaffID" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;
        Assign Incident to: <asp:TextBox ID="txtAssignIncidentTo" runat="server"></asp:TextBox>
        <span style="color: #CC0000">&nbsp;&nbsp;&nbsp;&nbsp; </span>&nbsp;&nbsp;&nbsp;&nbsp; <span style="color: #CC0000">*</span>Date Occured:
        <asp:TextBox ID="txtAddIncidentDateOccured" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <hr>
    <p>
        <span style="color: #CC0000">*</span>Equipment ID:
        <asp:TextBox ID="txtAddEquipmentID" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        &nbsp;</p>
    <hr>
    <p style="text-decoration: underline">
        <strong><em>Incident Priority:</em></strong></p>
    <p>
        a) <span style="color: #CC0000">High</span>:<asp:CheckBox ID="chkAddHigh" runat="server" />
    &nbsp;&nbsp;&nbsp;&nbsp;
        b) <span style="color: #FF9900">Medium</span>:<asp:CheckBox ID="chkAddMedium" runat="server"  />
    &nbsp;&nbsp;&nbsp;&nbsp;
        c) <span style="color: #009933">Low</span>:<asp:CheckBox ID="chkAddLow" runat="server" />
    </p>
    <p>
        &nbsp;</p>
    <hr>
    <p style="text-decoration: underline">
        <strong><em>Incident Status:</em></strong></p>
    <p>
        a) Pending<asp:CheckBox ID="chkAddPending" runat="server" />
    &nbsp;&nbsp;&nbsp;&nbsp;
        b) In Progress:<asp:CheckBox ID="chkAddInProgress" runat="server" />
    &nbsp;&nbsp;&nbsp;&nbsp; c) Close<asp:CheckBox ID="chkAddClose" runat="server" />
    </p>
    <p>
        &nbsp;</p>
    <hr>
    <br />
    <span style="color: #CC0000">*</span><span style="text-decoration: underline"><em><strong>Incident Description:<br />
    <br />
    <asp:TextBox ID="txtAddIncidentDescription" runat="server" Height="78px" Width="637px"></asp:TextBox>
    <br />
    <br />
    </strong></em></span>
        <asp:Label ID="lblError" runat="server" style="font-weight: 700" Text="[lblError]"></asp:Label>
        <span style="text-decoration: underline"><em><strong>
        <br />
    <br />
    </strong></em></span>
        <asp:Button ID="btnAddIncident" runat="server" style="font-weight: bold" Text="Add Incident" OnClick="btnAddIncident_Click" />
        &nbsp;<asp:Button ID="btnAddCancel" runat="server" style="font-weight: bold" Text="Cancel" OnClick="btnAddCancel_Click" />
        </div>
    </asp:Content>
