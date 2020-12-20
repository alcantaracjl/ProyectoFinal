<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/principal.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="CapaPresentacionW.Vistas.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/styles.css" rel="stylesheet" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="Divleft" >
        <div><asp:TextBox ID="TxtBuscar" runat="server"></asp:TextBox> </div>
   </div>
   <div class="Divright">
        <div><asp:Button  ID="CmdBuscar" runat="server" Text="Buscar" OnClick="CmdBuscar_Click" OnClientClick="Buscar" /> </div>
   </div>
    <div class="Divright">
        <div><asp:Button  ID="CmdRegistrar" runat="server" Text="Nuevo" OnClick="CmdRegistrar_Click" OnClientClick="Registrar" /> </div>
   </div>
    <div class="mGrid" >        
        <div id="listados">
            <asp:GridView ID="DtgUsuario" runat="server" AllowPaging="True" CssClass="mGrid" 
            PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" HorizontalAlign="Center"  OnPageIndexChanging="GVClientes_PageIndexChanging" Width="1178px" AutoGenerateColumns="False" OnSelectedIndexChanged="GVClientes_SelectedIndexChanged" OnSelectedIndexChanging="GVClientes_SelectedIndexChanging" DataKeyNames="idusuario" OnRowCommand="GVClientes_RowCommand" 
            >
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>

                <Columns>
                    <asp:BoundField DataField="idusuario" HeaderText="IdUsuario" SortExpression="idusuario" />
                    <asp:BoundField DataField="contrasenia" HeaderText="Contraseña" SortExpression="contrasenia" visible="false" />
                    <asp:BoundField DataField="nombres" HeaderText="Nombres" SortExpression="nombres" />
                    <asp:BoundField DataField="apellidoPat" HeaderText="ApePaterno" SortExpression="apellidoPat" />
                    <asp:BoundField DataField="apellidoMat" HeaderText="ApeMaterno" SortExpression="apellidoMat" />
                     <asp:BoundField DataField="telefono" HeaderText="Telefono" SortExpression="telefono" />
                    <asp:BoundField DataField="correo" HeaderText="correo" SortExpression="correo" />
                    <asp:BoundField DataField="estado" HeaderText="Estado" SortExpression="estado" />
                    <asp:BoundField DataField="idrol" HeaderText="idrol" SortExpression="idrol" visible="false" />
                    <asp:BoundField DataField="tipousuario" HeaderText="TipoUsuario" SortExpression="tipousuario" />
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