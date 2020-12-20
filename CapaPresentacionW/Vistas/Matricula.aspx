<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/principal.Master" AutoEventWireup="true" CodeBehind="Matricula.aspx.cs" Inherits="CapaPresentacionW.Vistas.Matricula" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/styles.css" rel="stylesheet" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="Divright">
        <div><asp:Button  ID="CmdRegistrar" runat="server" Text="Nuevo" OnClick="CmdRegistrar_Click" OnClientClick="Registrar" /> </div>
   </div>
    <div class="mGrid" >        
        <div id="listados">
            <asp:GridView ID="dtgMatricula" runat="server" AllowPaging="True" CssClass="mGrid" 
            PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" HorizontalAlign="Center"  OnPageIndexChanging="GVForm_PageIndexChanging" Width="1178px" AutoGenerateColumns="False"  DataKeyNames="idMatricula" OnRowCommand="GVForm_RowCommand" 
            >
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>

                <Columns>
                    <asp:BoundField DataField="idMatricula" HeaderText="idMatricula" SortExpression="idMatricula" />
                    <asp:BoundField DataField="codAlumno" HeaderText="codAlumno" SortExpression="codAlumno" />
                    <asp:BoundField DataField="Alumno" HeaderText="Alumno" SortExpression="Alumno" />
                    <asp:BoundField DataField="idPeriodo" HeaderText="idPeriodo" SortExpression="idPeriodo" />
                    <asp:BoundField DataField="Periodo" HeaderText="Periodo" SortExpression="Periodo" />
                    <asp:BoundField DataField="idCiclo" HeaderText="idCiclo" SortExpression="idCiclo" />
                    <asp:BoundField DataField="Ciclo" HeaderText="Ciclo" SortExpression="Ciclo" />
                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                    <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
                    
                                        <asp:ButtonField HeaderText="Actualizar" ShowHeader="True" Text="Actualizar" CommandName="Seleccionar" >
                    <FooterStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:ButtonField>
                                   </Columns>

<PagerStyle CssClass="pgr"></PagerStyle>
            </asp:GridView>
        </div>
    </div>

     
</asp:Content>

