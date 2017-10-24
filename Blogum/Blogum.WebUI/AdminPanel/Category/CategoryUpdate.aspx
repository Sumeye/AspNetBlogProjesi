<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/Admin.Master" AutoEventWireup="true" CodeBehind="CategoryUpdate.aspx.cs" Inherits="Blogum.WebUI.AdminPanel.Category.CategoryUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="content-box">
        <div class="content-box-header">
            <h3>Content box</h3>
            <ul class="content-box-tabs">
                <li><a href="#tab2" class="default-tab">Kategori Islemleri</a></li>
            </ul>
            <div class="clear">
            </div>
        </div>
        <div class="content-box-content">
            <div class="tab-content default-tab" id="tab2">
                <fieldset>
                    <p>
                        <label>Kategori Adi</label>
                        <asp:TextBox ID="txtKategoriAdi" runat="server" CssClass="text-input medium-input" />
                        <%--<span class="input-notification error png_bg">Error message</span>--%>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtKategoriAdi" CssClass="input-notification error png_bg" ErrorMessage="RequiredFieldValidator" ValidationGroup="vgEkleme">Kategori Adi bos gecilemez.</asp:RequiredFieldValidator>
                    </p>

            &nbsp;<p>
                       
                        <asp:Button Text="Kaydet" runat="server" CssClass="button" ValidationGroup="vgEkleme" ID="btnKaydet" OnClick="btnKaydet_Click" />
                    </p>
                </fieldset>
                <div class="clear">
                </div>
            </div>
            <!-- End #tab2 -->
        </div>
        <!-- End .content-box-content -->
    </div>
</asp:Content>
