<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/principal.Master" AutoEventWireup="true" CodeBehind="Registrar_CursoMatricula.aspx.cs" Inherits="CapaPresentacionW.Vistas.Registrar_CursoMatricula" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/styles.css" rel="stylesheet" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

   
    <div class="Divright">
        <div> <asp:Label ID="Label1" runat="server" Text="Cursos Disponibles"></asp:Label></div>
   </div>
    <div class="mGrid" >        
        <div id="listados">
            <asp:GridView ID="dtgClases" runat="server" AllowPaging="True" CssClass="mGrid" 
            PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" HorizontalAlign="Center"  OnPageIndexChanging="GVForm_PageIndexChanging" Width="1178px" AutoGenerateColumns="False"  DataKeyNames="idclases" OnRowCommand="GVForm_RowCommand" 
            >
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>

                <Columns>
                    <asp:BoundField DataField="idclases" HeaderText="idclases" SortExpression="idclases" />
                    <asp:BoundField DataField="Escuela" HeaderText="Escuela" SortExpression="Escuela" />
                    <asp:BoundField DataField="idCurso" HeaderText="idCurso" SortExpression="idCurso" />
                    <asp:BoundField DataField="Curso" HeaderText="Curso" SortExpression="Curso" />
                    <asp:BoundField DataField="Creditos" HeaderText="Creditos" SortExpression="Creditos" />
                    <asp:BoundField DataField="idHorario" HeaderText="idHorario" SortExpression="idHorario" />
                    <asp:BoundField DataField="Dia" HeaderText="Dia" SortExpression="Dia" />
                    <asp:BoundField DataField="Horario" HeaderText="Horario" SortExpression="Horario" />
                    <asp:BoundField DataField="idSeccion" HeaderText="idSeccion" SortExpression="idSeccion" />
                    <asp:BoundField DataField="Seccion" HeaderText="Seccion" SortExpression="Seccion" />
                    <asp:BoundField DataField="Vacantes" HeaderText="Vacantes" SortExpression="Vacantes" />
                    <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
                    <asp:BoundField DataField="iddocente" HeaderText="iddocente" SortExpression="iddocente" />
                    <asp:BoundField DataField="Docente" HeaderText="Docente" SortExpression="Docente" />
                    <asp:ButtonField HeaderText="Quitar" ShowHeader="True" Text="Quitar" CommandName="Seleccionar" >
                    <FooterStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:ButtonField>
                    
                </Columns>

<PagerStyle CssClass="pgr"></PagerStyle>
            </asp:GridView>
        </div>
    </div>

     
</asp:Content>



<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    	<span class="contact100-form-title">
					Cursos Registrados
				</span>
     <div class="container-contact100-form-btn">
                <asp:Button class="contact100-form-btn" ID="cmdRegistrar" runat="server" Text="Registrar" OnClick="cmdRegistrar_Click" style="width: 78px"/>                    
               </div>

 <div class="mGrid" >        
        <div id="cursos">
            <asp:GridView ID="dtgCursos" runat="server" AllowPaging="True" CssClass="mGrid" 
            PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" HorizontalAlign="Center"  OnPageIndexChanging="GVForm2_PageIndexChanging" Width="1178px" AutoGenerateColumns="False"  DataKeyNames="idClase" OnRowCommand="GVForm2_RowCommand" 
            >
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>

                <Columns>
                     <asp:BoundField DataField="idClase" HeaderText="idClase" SortExpression="idClase" />
                    <asp:BoundField DataField="idCurso" HeaderText="idCurso" SortExpression="idCurso" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                   <asp:BoundField DataField="Creditos" HeaderText="Creditos" SortExpression="Creditos" />
                   <asp:ButtonField HeaderText="Actualizar" ShowHeader="True" Text="Añadir" CommandName="Seleccionar" >
                    <FooterStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:ButtonField>
                   
                </Columns>

<PagerStyle CssClass="pgr"></PagerStyle>
            </asp:GridView>
        </div>
    </div>

</asp:Content>
