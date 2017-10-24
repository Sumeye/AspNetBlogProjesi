<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Blogum.WebUI.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Repeater ID="rpSummary" runat="server">
        <ItemTemplate>
            <div class="col-md-12 blog-post">
                <div class="post-title">

                    <a href="Article.aspx">
                        <h1><%#Eval("ArticleTitle")%></h1>
                    </a>
                </div>

                <div class="post-info">
                    <span><%#Eval("CreatedDate")%> / by <a href="#" target="_blank">Sümeyye Şentürk</a></span>
                </div>
                <p><%#Eval("ArticleSummary") %></p>
                <a href="Article.aspx?ArticleId=<%#Eval("ArticleId")%>" class="button button-style button-anim fa fa-long-arrow-right"><span>Read More</span></a>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <div class="col-md-12 text-center">
        <a id="load-more-post" class="load-more-button" style="cursor:pointer">Load</a>
        <div id="post-end-message"></div>
    </div>

</asp:Content>
