<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/Admin.Master" AutoEventWireup="true" CodeBehind="CategoryList.aspx.cs" Inherits="Blogum.WebUI.AdminPanel.Category.CategoryList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="content-box">
                <div class="content-box-header">
                    <h3>Kategori Listesi<asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
                    </h3>
                    <ul class="content-box-tabs">
                        <li><a href="#tab1" class="default-tab">Liste</a></li>
                    </ul>
                    <div class="clear">
                    </div>
                </div>
                <div class="content-box-content">
                    <div class="tab-content default-tab" id="tab1">
                        <a href="CategoryAdd.aspx" class="button">Yeni Kategori Olustur</a>
                        <table>
                            <thead>
                                <tr>
                                    <th>Kategori Adi
                                    </th>
                               
                                </tr>
                            </thead>
                            <tfoot>
                            </tfoot>
                            <tbody>
                                <asp:Repeater ID="rptCategory" runat="server" OnItemCommand="rptKategoriler_ItemCommand">
                                    
                                    <ItemTemplate>
                                        <tr>
                                            <td><%#Eval("CategoryName") %>
                                            </td>
                                             <td>
                                                <asp:ImageButton ImageUrl="~/AdminPanel/resources/images/icons/cross.png" runat="server" ID="imgbtnDelete" AlternateText="Sil" CommandName="delete" CommandArgument='<%#Eval("CatId") %>' OnClientClick="return confirm('Bu kategoriyi silmek istediginizden emni misiniz?')" />
                                                <asp:ImageButton ImageUrl="~/AdminPanel/resources/images/icons/hammer_screwdriver.png" runat="server" ID="ImageButton1" AlternateText="Guncelle" CommandName="update" CommandArgument='<%#Eval("CatId") %>' />
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
