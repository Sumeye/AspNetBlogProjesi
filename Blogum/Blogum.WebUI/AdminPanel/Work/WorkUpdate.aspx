<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanel/Admin.Master" AutoEventWireup="true" CodeBehind="WorkUpdate.aspx.cs" Inherits="Blogum.WebUI.AdminPanel.Work.WorkUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
       <script src="https://cdn.ckeditor.com/4.7.1/standard/ckeditor.js"></script>
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
                        <label>
                            Proje Adi:</label>
                        <asp:TextBox ID="txtProjectName" runat="server" CssClass="text-input medium-input" />

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtProjectName" CssClass="input-notification error png_bg" ErrorMessage="RequiredFieldValidator" ValidationGroup="vgEkleme">Bo&#351; gecilemez.</asp:RequiredFieldValidator>
                        <label>
                            Dil:</label>
                        <asp:TextBox ID="txtProjeLanguage" runat="server" CssClass="text-input medium-input" />

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtProjeLanguage" CssClass="input-notification error png_bg" ErrorMessage="RequiredFieldValidator" ValidationGroup="vgEkleme"> Bo&#351; gecilemez.</asp:RequiredFieldValidator>
                        <label>
                           Proje hakk&#305;nda:</label>
                        <asp:TextBox ID="txtProjectAbout" runat="server" CssClass="text-input medium-input" />

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtProjectAbout" CssClass="input-notification error png_bg" ErrorMessage="RequiredFieldValidator" ValidationGroup="vgEkleme">Bo&#351; gecilemez.</asp:RequiredFieldValidator>
                        <label>
                            Resim:</label>
                        <asp:FileUpload Id="fuImage" runat="server" />

                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="fuImage" CssClass="input-notification error png_bg" ErrorMessage="RequiredFieldValidator" ValidationGroup="vgEkleme">Bo&#351; gecilemez.</asp:RequiredFieldValidator>
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
