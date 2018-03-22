<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="LogInApp.LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainBody" runat="server">
    <div class="body-content">
        <div class="container">
            <div class="register">
                <fieldset>
                    <legend>Logowanie</legend>
                    <asp:Label runat="server" ID="labWynik" CssClass="labWynik"></asp:Label>
                    <p>Email: </p>
                    <asp:TextBox runat="server" ID="tbEmail" TextMode="Email" CssClass="tb"></asp:TextBox><br />
                    <br />
                    <p>Hasło: </p>
                    <asp:TextBox runat="server" ID="tbHaslo" TextMode="Password" CssClass="tb"></asp:TextBox><br />
                    <br />
                    <br />
                    <asp:Button ID="Button2" runat="server" type="submit" class="btn btn-primary" Text="Akceptuj" OnClick="Button2_Click"/>
                    <asp:Label ID="lab1" runat="server" Text="" Width="200px"></asp:Label>
                </fieldset>
            </div>
            
        </div>
    </div>
</asp:Content>
