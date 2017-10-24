<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="Work.aspx.cs" Inherits="Blogum.WebUI.Work" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Portfolio Detail Start -->
    <asp:Repeater ID="rptportfolio" runat="server">
        <ItemTemplate>
            <div class="row portfolio">
                <div class="col-sm-6 custom-pad-1">
                    <img width="100" height="50" src="<%#Eval("ProjeImage")%>" class="img-responsive" alt="">
                </div>
                <div class="col-sm-6 custom-pad-2">
                    <div class="table-responsive">
                        <table class="table table-bordered">
                            <tbody>

                                <tr>
                                    <td><b>Proje Adı</b></td>
                                    <td><%#Eval("Title") %></td>
                                </tr>
                                <tr>
                                    <td><b>Yazılım Dili</b></td>
                                    <td><%#Eval("ProjeLanguage") %></td>
                                </tr>
                                <tr>
                                    <td><b>Proje Hakkında</b></td>
                                    <td><%#Eval("ProjeAbout") %></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <!-- Portfolio End -->

        </ItemTemplate>
    </asp:Repeater>

    <div class="col-md-12 text-center">
        <a href="javascript:void(0)" id="load-more-portfolio" class="load-more-button">Load</a>
        <div id="portfolio-end-message"></div>
    </div>
</asp:Content>
