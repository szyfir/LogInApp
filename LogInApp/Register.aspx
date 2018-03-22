<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="LogInApp.Register" %>

<%@ MasterType VirtualPath="~/Site.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainBody" runat="server">
    <div class="body-content">
        <div class="container">
            <div class="register">
                <fieldset>
                    <legend>Formularz rejestracyjny</legend>
                    <p>Imię: </p>
                    <asp:TextBox runat="server" ID="tbImie" CssClass="tb"></asp:TextBox><br />
                    <br />
                    <p>Nazwisko: </p>
                    <asp:TextBox runat="server" ID="tbNaziwsko" CssClass="tb"></asp:TextBox><br />
                    <br />
                    <p>Email: </p>
                    <asp:TextBox runat="server" ID="tbEmail" TextMode="Email" CssClass="tb"></asp:TextBox><br />
                    <br />
                    <p>Hasło: </p>
                    <asp:TextBox runat="server" ID="tbHaslo" TextMode="Password" CssClass="tb"></asp:TextBox><br />
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" type="submit" class="btn btn-primary" Text="Akceptuj" OnClick="Button1_Click" />
                    <asp:Label ID="lab1" runat="server" Text="" Width="200px"></asp:Label>
                </fieldset>
            </div>
        </div>
    </div>
</asp:Content>
