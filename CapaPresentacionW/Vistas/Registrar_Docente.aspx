<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/principal.Master" AutoEventWireup="true" CodeBehind="Registrar_Docente.aspx.cs" Inherits="CapaPresentacionW.Vistas.Registrar_Docente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-contact100">
		<div class="wrap-contact100">
			
				<span class="contact100-form-title">
					Registro de Docente
				</span>




			
				<div class="wrap-input100 validate-input bg1" data-validate="Ingrese su Codigo">
					<span class="label-input100">idUsuario : *</span>
                    <asp:TextBox class="input100" type="text" ID="txtidusuario" runat="server" placeholder="Ingrese su DNI"></asp:TextBox>
				
				    <asp:Label ID="lblverificar" runat="server"></asp:Label>
				
				</div>
			<div class="container-contact100-form-btn">
                <asp:Button class="contact100-form-btn" ID="btnAlumno" runat="server" Text="Verificar" OnClick="cmdVerificar_Click"/>                    
                <asp:Button ID="btnNuevo" runat="server" Text="+" OnClick="cmdNuevo_Click" />
               </div>
			   


				<div class="wrap-input100 validate-input bg1" data-validate="Ingrese su Codigo">
					<span class="label-input100">CodDocente : *</span>
                    <asp:TextBox class="input100" type="text" ID="txtcoddocente" runat="server" placeholder="Ingrese su DNI"></asp:TextBox>
				
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
                
                 <div class="container-contact100-form-btn">
                <asp:Button class="contact100-form-btn" ID="cmdRegistrar" runat="server" Text="Registrar" OnClick="cmdRegistrar_Click" style="width: 78px"/>                    
               </div>







		
			</div>
               
             
		
		</div>
	
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

</asp:Content>
