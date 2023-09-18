<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CLDVClassGroupActivity._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <asp:DataGrid runat="server" ID="dtgUploaded"/>
        <asp:Label runat="server" Text="Files"/>
        <asp:DataGrid runat="server" />
        <asp:FileUpload runat="server" ID="fuFiles" />
        <asp:Button runat="server" ID="btnUpload" OnClick="btnUpload_Click" Text="Upload"/>
        <asp:Label runat="server" ID="lblStatus"/>
    </main>

</asp:Content>
