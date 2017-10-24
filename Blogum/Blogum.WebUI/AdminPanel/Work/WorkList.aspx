  <%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/Admin.Master" AutoEventWireup="true" CodeBehind="WorkList.aspx.cs" Inherits="Blogum.WebUI.AdminPanel.Work.WorkList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="content-box">
                <div class="content-box-header">
                    <h3>Proje Listesi</h3>
                    <ul class="content-box-tabs">
                        <li><a href="#tab1" class="default-tab">Liste</a></li>
                    </ul>
                    <div class="clear">
                    </div>
                </div>
                <div class="content-box-content">
                    <div class="tab-content default-tab" id="tab1">
                        <a href="WorkAdd.aspx" class="button">Yeni Proje Ekle</a>
                        <table>
                            <thead>
                                <tr>
                                    <th></th>
                                    <th>Proje Basligi
                                    </th>
                                    <th>Dil
                                    </th>
                                    <th>Proje Hakkında
                                    </th>
                                    <th>Proje Resmi
                                    </th>
                                </tr>
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                        </asp:ScriptManager>
                            </thead>
                            <tfoot>
                            </tfoot>
                            <tbody>
                                <asp:Repeater ID="rptProject" runat="server"  OnItemCommand="rptProject_ItemCommand">
                                    <ItemTemplate>
                                        <tr>
                                            <td>
                                                <a href='#<%#Eval("ProjeId") %>' rel="modal" title="Projeyi Goster">
                                                    <img src="../resources/images/icons/information.png" /></a><div id='<%#Eval("ProjeId") %>' style="display: none; overflow-y: scroll; height: 500px;"><%#Eval("ProjeAbout") %></div>
                                            </td>
                                            <td><%#Eval("Title") %>
                                            </td>
                                            <td>
                                                <%#Eval("ProjeLanguage") %>
                                            </td>
                                            <td><%#Eval("ProjeAbout") %></td>
                                            <td><img width="75" height="30" src="http://localhost:54070/<%#Eval("ProjeImage")%>" /></td>
        
                                            <td>
                                                <asp:ImageButton ImageUrl="~/AdminPanel/resources/images/icons/cross.png" runat="server" ID="imgbtnDelete" AlternateText="Sil" CommandName="delete" CommandArgument='<%#Eval("ProjeId") %>' OnClientClick="return confirm('Bu projeyi silmek istediginizden emnin misiniz?')" />
                                                <asp:ImageButton ImageUrl="~/AdminPanel/resources/images/icons/hammer_screwdriver.png" runat="server" ID="ImageButton1" AlternateText="Guncelle" CommandName="update" CommandArgument='<%#Eval("ProjeId") %>' />
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
