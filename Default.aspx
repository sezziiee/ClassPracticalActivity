﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CLDVClassGroupActivity._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <asp:FileUpload runat="server" />
        <asp:Button runat="server" ID="btnUpload" OnClick="btnUpload_Click"/>
    </main>

</asp:Content>