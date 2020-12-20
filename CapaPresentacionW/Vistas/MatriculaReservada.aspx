<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/principal.Master" AutoEventWireup="true" CodeBehind="MatriculaReservada.aspx.cs" Inherits="CapaPresentacionW.Vistas.MatriculaReservada" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/styles.css" rel="stylesheet" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
   
    <div class="mGrid" >        
        <div id="listados">
            <asp:GridView ID="dtgMatricula" runat="server" AllowPaging="True" CssClass="mGrid" 
            PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" HorizontalAlign="Center"  OnPageIndexChanging="GVForm_PageIndexChanging" Width="1178px" AutoGenerateColumns="False"  DataKeyNames="idMatricula"
            >
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>

                <Columns>
                    <asp:BoundField DataField="idMatricula" HeaderText="idMatricula" SortExpression="idMatricula" Visible="false" />
                    <asp:BoundField DataField="codAlumno" HeaderText="codAlumno" SortExpression="codAlumno" />
                    <asp:BoundField DataField="Alumno" HeaderText="Alumno" SortExpression="Alumno" />
                    <asp:BoundField DataField="idPeriodo" HeaderText="idPeriodo" SortExpression="idPeriodo" Visible="false"  />
                    <asp:BoundField DataField="Periodo" HeaderText="Periodo" SortExpression="Periodo" />
                    <asp:BoundField DataField="idCiclo" HeaderText="idCiclo" SortExpression="idCiclo" Visible="false"  />
                    <asp:BoundField DataField="Ciclo" HeaderText="Ciclo" SortExpression="Ciclo" />
                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                    <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
                   
                                   </Columns>

<PagerStyle CssClass="pgr"></PagerStyle>
            </asp:GridView>
        </div>
    </div>

     
</asp:Content>


