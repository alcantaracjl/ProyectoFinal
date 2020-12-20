<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Presentacion.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../css/master.css" rel="stylesheet" />

    <link href="../css/stylesmenu.css" rel="stylesheet" />
    <link href="../css/styles.css" rel="stylesheet" type="text/css" />
    <title>LOGIN PE</title>
</head>
<body>
    <div class="login">
	<h1>Login</h1>
    <form method="post" runat="server">


    	<!--<input type="text" name="u" placeholder="Username" required="required" />-->
         <!-- <input type="password" name="p" placeholder="Password" required="required" />-->
         <!--   <button type="submit" class="btn btn-primary btn-block btn-large">Let me in.</button>-->
        <asp:TextBox type="text" ID="txtusuario" runat="server" required="required" placeholder="Usuario"></asp:TextBox>
              <asp:TextBox type="password" ID="txtclave" runat="server" required="required" placeholder="Contraseña"></asp:TextBox>
      
     
        <asp:Button class="btn btn-primary btn-block btn-large" type="submit"  ID="btnlogin" runat="server" Text="ingresar" OnClick="btnlogin_Click" />

        <asp:Label ID="lblmensaje" runat="server" Visible="false"></asp:Label>

    </form>
</div>
    
</body>
</html>
