<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/principal.Master" AutoEventWireup="true" CodeBehind="Registrar_Curso.aspx.cs" Inherits="CapaPresentacionW.Vistas.Registrar_Curso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-contact100">
		<div class="wrap-contact100">
			
				<span class="contact100-form-title">
					Registro de Curso
				</span>

			
				<div class="wrap-input100 validate-input bg1" data-validate="Ingrese su Codigo">
					<span class="label-input100">Nombre : *</span>
                    <asp:TextBox class="input100" type="text" ID="txtnombre" runat="server" placeholder="Ingrese el nombre"></asp:TextBox>
				   			
				</div>
			<div class="wrap-input100 input100-select bg1">
					<span class="label-input100">Creditos *</span>
					<div>
					    <asp:ListBox class="js-select2" Rows="2" ID="lblcreditos" runat="server" SelectionMode="Single" >
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
							<asp:ListItem>3</asp:ListItem>
							<asp:ListItem>4</asp:ListItem>
							<asp:ListItem>5</asp:ListItem>
							<asp:ListItem>6</asp:ListItem>
							<asp:ListItem>7</asp:ListItem>
                        </asp:ListBox>
						<div class="dropDownSelect2"></div>
					</div>
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
