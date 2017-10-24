<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Blogum.WebUI.AdminPanel.Dashboard" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head>
 <script type="text/javascript">
  $(document).ready(function () {
    $("#remember").change(function () {
      if ($(this).is(":checked")) {
        $(".check label").addClass("true");
      }
      else {
        $(".check label").removeClass("true");
      }
    });
 });
 </script>
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />

    <title>Admin Paneli | Oturum Aç</title>

    <!--                       CSS                       -->

    <!-- Reset Stylesheet -->
    <link rel="stylesheet" href="resources/css/reset.css" type="text/css" media="screen" />

    <!-- Main Stylesheet -->
    <link rel="stylesheet" href="resources/css/style.css" type="text/css" media="screen" />

    <!-- Invalid Stylesheet. This makes stuff look pretty. Remove it if you want the CSS completely valid -->
    <link rel="stylesheet" href="resources/css/invalid.css" type="text/css" media="screen" />

    <!-- Colour Schemes
	  
		Default colour scheme is green. Uncomment prefered stylesheet to use it.
		
		<link rel="stylesheet" href="resources/css/blue.css" type="text/css" media="screen" />
		
		<link rel="stylesheet" href="resources/css/red.css" type="text/css" media="screen" />  
	 
		-->

    <!-- Internet Explorer Fixes Stylesheet -->

    <!--[if lte IE 7]>
			<link rel="stylesheet" href="resources/css/ie.css" type="text/css" media="screen" />
		<![endif]-->

    <!--                       Javascripts                       -->

    <!-- jQuery -->
    <script type="text/javascript" src="resources/scripts/jquery-1.3.2.min.js"></script>

    <!-- jQuery Configuration -->
    <script type="text/javascript" src="resources/scripts/simpla.jquery.configuration.js"></script>

    <!-- Facebox jQuery Plugin -->
    <script type="text/javascript" src="resources/scripts/facebox.js"></script>

    <!-- jQuery WYSIWYG Plugin -->
    <script type="text/javascript" src="resources/scripts/jquery.wysiwyg.js"></script>

    <!-- Internet Explorer .png-fix -->

    <!--[if IE 6]>
			<script type="text/javascript" src="resources/scripts/DD_belatedPNG_0.0.7a.js"></script>
			<script type="text/javascript">
				DD_belatedPNG.fix('.png_bg, img, li');
			</script>
		<![endif]-->

    <style type="text/css">
        .auto-style1 {
            margin-left: 0;
        }
    </style>

</head>
<body id="login">
    <div id="login-wrapper" class="png_bg">
        <div id="login-top">
            <h1>Admin Paneli</h1>
            <!-- Logo (221px width) -->
            <h2 style="color:white">ADMİN PANELİ</h2>
        </div>
        <!-- End #logn-top -->
        <div id="login-content">

            <form method="get" runat="server">

                <p>
                    <asp:Label ID="lblUserName" class="text-input" runat="server" Text="Kullan&#305;c&#305; Ad&#305;"></asp:Label>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </p>
                
                <p>
                    <asp:Label ID="lblPassword" runat="server" Text="&#350;ifre"></asp:Label>
                    <asp:TextBox ID="txtPassword" class="text-input" TextMode="Password" runat="server" CssClass="auto-style1" Height="16px" Width="199px"></asp:TextBox>

                </p>
                <div class="clear"></div>
                <p id="remember-password">
                    <input type="checkbox" />Beni Hatırla
                </p>
                <div class="clear"></div>
                <p>
                    <asp:Button ID="Button1" runat="server" CssClass="button" Text="Oturum Aç" OnClick="btnLogin_Click" />
                </p>
            </form>
        </div>
        <!-- End #login-content -->
    </div>
    <!-- End #login-wrapper -->
</body>
</html>


