<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Blogum.WebUI.About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="rptAbout" runat="server">
        <ItemTemplate>
            <div class="post-title margin-bottom-30">
                <h5>Merhaba Ben<span class="main-color">    <%#Eval("NameSurName") %></span></h5>
                <%#Eval("AdminAbout") %>
            </div>
        </ItemTemplate>
    </asp:Repeater>



</asp:Content>
