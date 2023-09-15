<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CLDVClassGroupActivity.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%; height: 202px">
        <tr>
            <td style="height: 129px; text-align: center;" colspan="2">
                <strong><em>
                <asp:Label ID="Label1" runat="server" Text="Login Page" style="font-size: xx-large"></asp:Label>
                </em></strong>
            </td>
        </tr>
        <tr>
            <td style="height: 34px; text-align: center; width: 732px;">Enter username: </td>
            <td style="height: 34px">
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 34px; text-align: center; width: 732px;">Enter password:</td>
            <td style="height: 34px">
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 34px; text-align: center; width: 732px;">&nbsp;</td>
            <td style="height: 34px">
                <asp:Button ID="btnLogin" runat="server" Text="Login" />
            </td>
        </tr>
    </table>
</asp:Content>
