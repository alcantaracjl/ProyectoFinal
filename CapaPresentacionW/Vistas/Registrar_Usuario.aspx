<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/principal.Master" AutoEventWireup="true" CodeBehind="Registrar_Usuario.aspx.cs" Inherits="CapaPresentacionW.Vistas.Registrar_Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-contact100">
		<div class="wrap-contact100">
			
				<span class="contact100-form-title">
					Registro de Usuarios
				</span>
				<div class="wrap-input100 validate-input bg1" data-validate="Ingrese su usuario">
					<span class="label-input100">Usuario : *</span>
                    <asp:TextBox class="input100" type="text" ID="txtUsuario" runat="server" placeholder="Ingrese sus usuario"></asp:TextBox>
				
				</div>

			<div class="wrap-input100 validate-input bg1" data-validate="Ingrese su contraseña" >
					<span class="label-input100">Contraseña : *</span>
                    <asp:TextBox class="input100" type="password" ID="txtContrasenia" runat="server" placeholder="Ingrese sus contraseña"></asp:TextBox>
				</div>
				<div class="wrap-input100 validate-input bg1" data-validate="Ingrese su nombre">
					<span class="label-input100">Nombres : *</span>
                    <asp:TextBox class="input100" type="text" ID="txtNombre" runat="server" placeholder="Ingrese sus nombres"></asp:TextBox>
				</div>
                <div class="wrap-input100 validate-input bg1" data-validate="Ingrese su apellido paterno">
					<span class="label-input100">Apellido Paterno : *</span>
                    <asp:TextBox class="input100" type="text" ID="TxtApellidopat" runat="server"  placeholder="Ingrese su apellido paterno"></asp:TextBox>
				</div>

			
                <div class="wrap-input100 validate-input bg1" data-validate="Ingrese su apellido materno">
					<span class="label-input100">Apellido Materno : *</span>
                    <asp:TextBox class="input100" type="text" ID="txtApellidomat" runat="server"  placeholder="Ingrese su apellido materno"></asp:TextBox>
				</div>
                <div class="wrap-input100 validate-input bg1" data-validate="Ingrese su Telefono">
					<span class="label-input100">Telefono : *</span>
                    <asp:TextBox class="input100" type="text" ID="txtTelefono" runat="server"  placeholder="Ingrese su telefono"></asp:TextBox>
				</div>
				 <div class="wrap-input100 validate-input bg1" data-validate="Ingrese su Correo">
					<span class="label-input100">Correo : *</span>
                    <asp:TextBox class="input100" type="email" ID="txtCorreo" runat="server"  placeholder="Ingrese su correo"></asp:TextBox>
				</div>
				<div class="wrap-input100 input100-select bg1">
					<span class="label-input100">Estado *</span>
					<div>
					    <asp:ListBox class="js-select2" Rows="2" ID="lbxEstado" runat="server" SelectionMode="Single" >
                            <asp:ListItem>Activo</asp:ListItem>
                            <asp:ListItem>Inactivo</asp:ListItem>
                        </asp:ListBox>
						<div class="dropDownSelect2"></div>
					</div>
				</div>
                <div class="wrap-input100 input100-select bg1">
					<span class="label-input100">Tipo de Usuario *</span>
					<div>
					    <asp:DropDownList class="js-select2"  ID="cboTipousuario" runat="server" SelectionMode="Single" >
                          
                        </asp:DropDownList>
						<div class="dropDownSelect2"></div>
					</div>
				</div>
                 

				<div class="container-contact100-form-btn">
                <asp:Button class="contact100-form-btn" ID="cmdRegistrar" runat="server" Text="Registrar" OnClick="cmdRegistrar_Click"/>                    
               </div>


			</div>



		
		</div>
	
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

</asp:Content>
