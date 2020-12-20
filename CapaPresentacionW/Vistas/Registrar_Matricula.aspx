<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/principal.Master" AutoEventWireup="true" CodeBehind="Registrar_Matricula.aspx.cs" Inherits="CapaPresentacionW.Vistas.Registrar_Matricula" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-contact100">
		<div class="wrap-contact100">
			
				<span class="contact100-form-title">
					Registro de Matricula
				</span>


			 
		
		<div class="wrap-input100 input100-select bg1">
					<span class="label-input100">Periodo: *</span>
					<div>
					    <asp:DropDownList class="js-select2"  ID="cboPeriodo" runat="server" SelectionMode="Single" >
                          
                        </asp:DropDownList>
						<div class="dropDownSelect2"></div>
					</div>
				</div>

		
		<div class="wrap-input100 input100-select bg1">
					<span class="label-input100">Ciclo *</span>
					<div>
					    <asp:DropDownList class="js-select2"  ID="cboCiclo" runat="server" SelectionMode="Single" >
                          
                        </asp:DropDownList>
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

