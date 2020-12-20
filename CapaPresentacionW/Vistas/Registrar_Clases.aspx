<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/principal.Master" AutoEventWireup="true" CodeBehind="Registrar_Clases.aspx.cs" Inherits="CapaPresentacionW.Vistas.Registrar_Clases" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-contact100">
		<div class="wrap-contact100">
			
				<span class="contact100-form-title">
					Registro de Clases
				</span>


			 
		
		<div class="wrap-input100 input100-select bg1">
					<span class="label-input100">Horario: *</span>
					<div>
					    <asp:DropDownList class="js-select2"  ID="cboHorario" runat="server" SelectionMode="Single" >
                          
                        </asp:DropDownList>
						<div class="dropDownSelect2"></div>
					</div>
				</div>

		
		<div class="wrap-input100 input100-select bg1">
					<span class="label-input100">Curso *</span>
					<div>
					    <asp:DropDownList class="js-select2"  ID="cboCurso" runat="server" SelectionMode="Single" >
                          
                        </asp:DropDownList>
						<div class="dropDownSelect2"></div>
					</div>
				</div>
			
		<div class="wrap-input100 input100-select bg1">
					<span class="label-input100">Seccion *</span>
					<div>
					    <asp:DropDownList class="js-select2"  ID="cboSeccion" runat="server" SelectionMode="Single" >
                          
                        </asp:DropDownList>
						<div class="dropDownSelect2"></div>
					</div>
				</div>


			
		<div class="wrap-input100 input100-select bg1">
					<span class="label-input100">Docente *</span>
					<div>
					    <asp:DropDownList class="js-select2"  ID="cboDocente" runat="server" SelectionMode="Single" >
                          
                        </asp:DropDownList>
						<div class="dropDownSelect2"></div>
					</div>
				</div>

				<div class="wrap-input100 input100-select bg1">
					<span class="label-input100">Estado *</span>
					<div>
					    <asp:ListBox class="js-select2" Rows="2" ID="lbxEstado" runat="server" SelectionMode="Single" >
                            <asp:ListItem>Activo</asp:ListItem>
                            <asp:ListItem>Inactivo</asp:ListItem>
							<asp:ListItem>Publicado</asp:ListItem>
                        </asp:ListBox>
						<div class="dropDownSelect2"></div>
					</div>
				</div>

			<div class="wrap-input100 validate-input bg1" data-validate="Ingrese el numero de Vacantes">
					<span class="label-input100">Vacantes : *</span>
                    <asp:TextBox class="input100" type="text" ID="txtvacantes" runat="server" placeholder="Ingrese el numero de Vacantes"></asp:TextBox>
				
				</div>

                
                 <div class="container-contact100-form-btn">
                <asp:Button class="contact100-form-btn" ID="cmdRegistrar" runat="server" Text="Registrar" OnClick="cmdRegistrar_Click" style="width: 78px"/>                    
               </div>

		
			</div>
               
             
		
		</div>
	
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

</asp:Content>
