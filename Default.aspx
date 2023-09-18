<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CLDVClassGroupActivity._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="heading">
            <h1>Welcome to Jarryd Inc.</h1>
            <p>we take Pride in coding the best applications and take pride in our front end developer.</p>
        </div>
        <div class="flex">
            <asp:DataGrid runat="server" ID="dtgUploaded" BackColor="Pink" CssClass="dtg" BorderStyle="Solid">
    <ItemStyle BorderStyle="Solid" BorderWidth="1px" />
    <AlternatingItemStyle BorderStyle="Solid" BorderWidth="1px" />
    <HeaderStyle BorderStyle="Solid" BorderWidth="1px" />
    <FooterStyle BorderStyle="Solid" BorderWidth="1px" />
</asp:DataGrid>

            <div>
            <asp:Label runat="server" Text="Files"/>
            <asp:DataGrid runat="server" />
            <asp:FileUpload runat="server" ID="fuFiles" />
            <asp:Button runat="server" ID="btnUpload" OnClick="btnUpload_Click" Text="Upload"/>
            <asp:Label runat="server" ID="lblStatus"/>

            </div>
        </div>
    </main>

</asp:Content>
