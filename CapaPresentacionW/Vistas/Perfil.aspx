<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/principal.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="CapaPresentacionW.Vistas.Perfil" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="container-contact100">
		<div class="wrap-contact100">
			
				<span class="contact100-form-title">
					Perfil:
				</span>
				<div class="wrap-input100 validate-input bg1" data-validate="Ingrese su usuario">
					<span class="label-input100">Usuario : </span>
                    <asp:Label ID="lblusuario" runat="server" Text="Label"></asp:Label>

				</div>

			
				<div class="wrap-input100 validate-input bg1" data-validate="Ingrese su nombre">
					<span class="label-input100">Nombres : </span>
                     <asp:Label ID="lblnombre" runat="server" Text="Label"></asp:Label>
				</div>
                <div class="wrap-input100 validate-input bg1" data-validate="Ingrese su apellido paterno">
					<span class="label-input100">Apellido Paterno : </span>
                    <asp:Label ID="lblapepat" runat="server" Text="Label"></asp:Label>
				</div>
			 <div class="wrap-input100 validate-input bg1" data-validate="Ingrese su apellido materno">
					<span class="label-input100">Apellido Materno : </span>
                     <asp:Label ID="lblapemat" runat="server" Text="Label"></asp:Label>
				</div>
                <div class="wrap-input100 validate-input bg1" data-validate="Ingrese su Telefono">
					<span class="label-input100">Telefono : </span>
                     <asp:Label ID="lbltelefono" runat="server" Text="Label"></asp:Label>
				</div>
				 <div class="wrap-input100 validate-input bg1" data-validate="Ingrese su Correo">
					<span class="label-input100">Correo : </span>
                     <asp:Label ID="lblcorreo" runat="server" Text="Label"></asp:Label>
				</div>
				 <div class="wrap-input100 validate-input bg1" data-validate="Ingrese su Correo">
					<span class="label-input100">Estado : </span>
                     <asp:Label ID="lblestado" runat="server" Text="Label"></asp:Label>
				</div>
		  <div class="wrap-input100 validate-input bg1" data-validate="Ingrese su Correo">
					<span class="label-input100">Tipo Usuario : </span>
                     <asp:Label ID="lbltipo" runat="server" Text="Label"></asp:Label>
				</div>

			</div>
               

			
		</div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
