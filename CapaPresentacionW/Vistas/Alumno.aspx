<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/principal.Master" AutoEventWireup="true" CodeBehind="Alumno.aspx.cs" Inherits="CapaPresentacionW.Vistas.Alumno" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/styles.css" rel="stylesheet" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="Divleft" >
        <div>
            <asp:Label ID="Label1" runat="server" Text="IdUsuario:"></asp:Label>
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
            <asp:GridView ID="DtgAlumno" runat="server" AllowPaging="True" CssClass="mGrid" 
            PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" HorizontalAlign="Center"  OnPageIndexChanging="GVForm_PageIndexChanging" Width="1178px" AutoGenerateColumns="False"  DataKeyNames="codAlumno" OnRowCommand="GVForm_RowCommand" 
            >
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>

                <Columns>
                    <asp:BoundField DataField="codAlumno" HeaderText="codAlumno" SortExpression="codAlumno" />
                    <asp:BoundField DataField="idusuario" HeaderText="idusuario" SortExpression="idusuario" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="idescuela" HeaderText="idescuela" SortExpression="idescuela" visible="false"/>
                    <asp:BoundField DataField="Escuela" HeaderText="Escuela" SortExpression="Escuela" />
                    <asp:BoundField DataField="idPeriodo" HeaderText="idPeriodo" SortExpression="idPeriodo"  visible="false" />
                    <asp:BoundField DataField="Sem_Ingreso" HeaderText="Sem_Ingreso" SortExpression="Sem_Ingreso" />
                    <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado" />
                    
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