<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CLDVClassGroupActivity.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="loginbox">
    <div id="logincontain">
                <div class="login-text">
                    <h1 id="login" class="login" runat="server"><strong><em>Login Page</em></strong></h1>
                </div>
            
                <asp:Label runat="server" ID="User" Text="Username" />

                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            
        
                <asp:Label runat="server" ID="Passwords" Text="Password:" />
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
               
            
            <div class="butonstyle">
                <asp:Button ID="btnReg" class="btlogin" OnClick="btnReg_Click" runat="server" Text="Register" />
                <asp:Button ID="btnLogin" class="btlogin" OnClick="btnLogin_Click" runat="server" Text="Login" />
            </div>
             <asp:Label ID="lblWarning" runat="server" />
        </div>
        </div>

</asp:Content>
