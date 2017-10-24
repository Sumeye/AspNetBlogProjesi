<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="Article.aspx.cs" Inherits="Blogum.WebUI.Article" %>

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
                    <span><%#Eval("CreatedDate")%> / by <a href="#" target="_blank"><%#Eval("ArticleAdminId") %></a></span>
                </div>
                <p><%#Eval("ArticleSummary") %></p>
                <a href="Article.aspx?ArticleId=<%#Eval("ArticleId")%>" class="button button-style button-anim fa fa-long-arrow-right"><span>Devamını Oku</span></a>
            </div>
        </ItemTemplate>
    </asp:Repeater>










    <div class="col-md-12 blog-post"> 
      <asp:Repeater ID="rptArticle" runat="server">
          <ItemTemplate>

      
        <!-- Post Headline Start -->
        <div class="post-title">
            <h1><%#Eval("ArticleTitle")%></h1>
        </div>
        <!-- Post Headline End -->
        <!-- Post Detail Start -->
        <div class="post-info">
            <span><%#Eval("CreatedDate")%> / by <a href="#" target="_blank"><%#Eval("ArticleAdminId") %></a></span>
        </div>
        <!-- Post Detail End -->
        <p><%#Eval("ArticleContent") %></p>
        <!-- Post Image Start -->
        <div class="post-image margin-top-40 margin-bottom-40">
            <img src="<%#Eval("ArticleImage")%>" alt="">
            <p>Daha Fazlası için  <a href="#" target="_blank">Tıklayınız</a></p>
        </div>

   
        <!-- Post Image End -->

        <!-- Post Video Tutorial Start -->
        <div class="video-box margin-top-40 margin-bottom-40">
            <div class="video-tutorial">
                <a class="video-popup" href="<%#Eval("VideoLink") %>" title="Video Tutorial">
                    <img src="images/blog/4.jpg" alt="">
                </a>
            </div>
        </div>
        <!-- Post Video Tutorial End -->




       

 </ItemTemplate>
      </asp:Repeater>


</div>

       <%-- <!-- Post Author Bio Box Start -->
        <div class="about-author margin-top-70 margin-bottom-50">
       <asp:Repeater ID="rptAdmin" runat="server">
        <ItemTemplate>
            <div class="picture">
                <img src="images/blog/<%#Eval("AdminPicture")%>" class="img-responsive" alt="">
            </div>
       
            <div class="c-padding">
                <h6>Makale Sahibi <a href="#" target="_blank" data-toggle="tooltip" data-placement="top" title="Visit Sümeyye Website"><%#Eval("NameSurName")%></a></h6>
                <p></p>
            </div>
                </ItemTemplate></asp:Repeater>
        </div>
        <!-- Post Author Bio Box End -->--%>
    
    

</asp:Content>
