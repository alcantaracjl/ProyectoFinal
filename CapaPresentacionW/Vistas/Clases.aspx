<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/principal.Master" AutoEventWireup="true" CodeBehind="Clases.aspx.cs" Inherits="CapaPresentacionW.Vistas.Clases" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/styles.css" rel="stylesheet" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="Divleft" >
        <div>
            <asp:Label ID="Label1" runat="server" Text="Curso:"></asp:Label>
            <asp:TextBox ID="TxtBuscar" runat="server"></asp:TextBox> </div>
   </div>
   <div class="Divright">
        <div><asp:Button  ID="CmdBuscar" runat="server" Text="Buscar" OnClick="CmdBuscar_Click" OnClientClick="Buscar" /> </div>
   </div>
    <div class="Divright">
        <div><asp:Button  ID="CmdRegistrar" runat="server" Text="Nuevo" OnClick="CmdRegistrar_Click" OnClientClick="Registrar" /> </div>
   </div>
    <div class="mGrid" >        
        <div id="listados">
            <asp:GridView ID="dtgClases" runat="server" AllowPaging="True" CssClass="mGrid" 
            PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" HorizontalAlign="Center"  OnPageIndexChanging="GVForm_PageIndexChanging" Width="1178px" AutoGenerateColumns="False"  DataKeyNames="idclases" OnRowCommand="GVForm_RowCommand" 
            >
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>

                <Columns>
                    <asp:BoundField DataField="idclases" HeaderText="idclases" SortExpression="idclases" Visible="false" />
                    <asp:BoundField DataField="Escuela" HeaderText="Escuela" SortExpression="Escuela" />
                    <asp:BoundField DataField="idCurso" HeaderText="idCurso" SortExpression="idCurso" Visible="false"  />
                    <asp:BoundField DataField="Curso" HeaderText="Curso" SortExpression="Curso" />
                    <asp:BoundField DataField="Creditos" HeaderText="Creditos" SortExpression="Creditos" />
                    <asp:BoundField DataField="idHorario" HeaderText="idHorario" SortExpression="idHorario" Visible="false"  />
                    <asp:BoundField DataField="Dia" HeaderText="Dia" SortExpression="Dia" />
                    <asp:BoundField DataField="Horario" HeaderText="Horario" SortExpression="Horario" />
                    <asp:BoundField DataField="idSeccion" HeaderText="idSeccion" SortExpression="idSeccion" Visible="false"  />
                    <asp:BoundField DataField="Seccion" HeaderText="Seccion" SortExpression="Seccion" />
                    <asp:BoundField DataField="Vacantes" HeaderText="Vacantes" SortExpression="Vacantes" />
                    <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
                    <asp:BoundField DataField="iddocente" HeaderText="iddocente" SortExpression="iddocente" />
                    <asp:BoundField DataField="Docente" HeaderText="Docente" SortExpression="Docente" />
                    <asp:ButtonField HeaderText="Actualizar" ShowHeader="True" Text="Actualizar" CommandName="Seleccionar" >
                    <FooterStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:ButtonField>
                    <asp:ButtonField CommandName="Eliminar" HeaderText="Eliminar" Text="Eliminar">
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:ButtonField>
                </Columns>

<PagerStyle CssClass="pgr"></PagerStyle>
            </asp:GridView>
        </div>
    </div>

     
</asp:Content>

