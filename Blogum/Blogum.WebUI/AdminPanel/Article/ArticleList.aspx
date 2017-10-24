<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/Admin.Master" AutoEventWireup="true" CodeBehind="ArticleList.aspx.cs" Inherits="Blogum.WebUI.AdminPanel.Article.ArticleList" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="content-box">
                <div class="content-box-header">
                    <h3>Makale Listesi</h3>
                    <ul class="content-box-tabs">
                        <li><a href="#tab1" class="default-tab">Liste</a></li>
                    </ul>
                    <div class="clear">
                    </div>
                </div>
                <div class="content-box-content">
                    <div class="tab-content default-tab" id="tab1">
                        <a href="ArticleAdd.aspx" class="button">Yeni Makale Olustur</a>
                        <table>
                            <thead>
                                <tr>
                                    <th></th>
                                    <th>Makale Basligi
                                    </th>
                                    <th>Kategorileri
                                    </th>
                                    <th>Olu&#351;turma Tarihi
                                    </th>
                                </tr>
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                        </asp:ScriptManager>
                            </thead>
                            <tfoot>
                            </tfoot>
                            <tbody>
                                <asp:Repeater ID="rptMakaleler" runat="server"    OnItemCommand="rptMakaleler_ItemCommand">
                                    <ItemTemplate>
                                        <tr>
                                            <td>
                                                <a href='#<%#Eval("ArticleId") %>' rel="modal" title="Makaleyi Goster">
                                                    <img src="../resources/images/icons/information.png" /></a><div id='<%#Eval("ArticleId") %>' style="display: none; overflow-y: scroll; height: 500px;"><%#Eval("ArticleContent") %></div>
                                            </td>
                                            <td><%#Eval("ArticleTitle") %>
                                            </td>
                                            <td>
                                                <%#Eval("CategoryName") %>
                                            </td>
                                            <td><%#Eval("CreatedDate","{0:dd MMM yyyy}") %></td>
        
                                            <td>
                                                <asp:ImageButton ImageUrl="~/AdminPanel/resources/images/icons/cross.png" runat="server" ID="imgbtnDelete" AlternateText="Sil" CommandName="delete" CommandArgument='<%#Eval("ArticleId") %>' OnClientClick="return confirm('Bu makaleyi silmek istediginizden emnin misiniz?')" />
                                                <asp:ImageButton ImageUrl="~/AdminPanel/resources/images/icons/hammer_screwdriver.png" runat="server" ID="ImageButton1" AlternateText="Guncelle" CommandName="update" CommandArgument='<%#Eval("ArticleId") %>' />
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>




</asp:Content>
