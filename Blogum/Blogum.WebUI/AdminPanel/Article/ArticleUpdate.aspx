﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/Admin.Master" AutoEventWireup="true" CodeBehind="ArticleUpdate.aspx.cs" Inherits="Blogum.WebUI.AdminPanel.Article.ArticleUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <script src="https://cdn.ckeditor.com/4.7.1/standard/ckeditor.js"></script>

    <style>
        .liste input, .liste label {
            padding: 0px;
            float: left;
        }
    </style>




    <div class="content-box">
        <div class="content-box-header">
            <h3>Content box</h3>
            <ul class="content-box-tabs">
                <li><a href="#tab2" class="default-tab">Makale Islemleri</a></li>
            </ul>
            <div class="clear">
            </div>
        </div>
        <div class="content-box-content">
            <div class="tab-content default-tab" id="tab2">
                <fieldset>
                    <p>
                        <label>Baslik</label>
                        <asp:TextBox ID="txtBaslik" runat="server" CssClass="text-input large-input" />


                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtBaslik" CssClass="input-notification error png_bg" ErrorMessage="RequiredFieldValidator" ValidationGroup="vgEkleme">Baslik bos gecilemez.</asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <label>Kategorileri</label>
                 <asp:DropDownList ID="ddlCat" runat="server">

                 </asp:DropDownList>
                    </p>
                    <p>
                        <asp:Label ID="Label1" runat="server" Text="Label">Oluşturma Tarihi</asp:Label></p>
                    <p>  <asp:TextBox ID="txtCreatedDate" runat="server" TextMode="Date"></asp:TextBox></p>
                    <p>
                        <label>Özet</label>
                        <asp:TextBox ID="TxtSummary" runat="server" TextMode="MultiLine" ValidateRequestMode="Disabled"></asp:TextBox>
                        <label>Icerigi</label>
                       <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" Width="200px" ValidateRequestMode="Disabled"></asp:TextBox>
                        <script>
                      CKEDITOR.replace('<%=txtMessage.UniqueID%>')//  <%%> html sayfas&#305;nda c# kodlar&#305;n&#305; yazabilmemizi sa&#287;lar.
                        </script>
                    </p>
                    <p>
                        <asp:Button Text="Geri Don" runat="server" CssClass="button" ID="btnGeriDon" OnClick="btnGeriDon_Click" />
                        &nbsp;&nbsp;
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