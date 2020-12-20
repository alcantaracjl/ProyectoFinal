<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/principal.Master" AutoEventWireup="true" CodeBehind="Permisos.aspx.cs" Inherits="CapaPresentacionW.Vistas.Permisos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/styles.css" rel="stylesheet" />
    
<style type="text/css">
    .mGrid {
        margin-bottom: 0px;
    }
</style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
  
    <div class="mGrid" >        
        <div id="listados">
            <asp:GridView ID="DtgPermisos" runat="server" AllowPaging="True" CssClass="mGrid" 
            PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" HorizontalAlign="Center"  OnPageIndexChanging="GVClientes_PageIndexChanging" Width="1178px" AutoGenerateColumns="False" OnRowCommand="GVPermiso_RowCommand"  DataKeyNames="idrolmodulo" 
            >
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>

                <Columns>
                    <asp:BoundField DataField="idrolmodulo" HeaderText="idrolmodulo" SortExpression="idusuario" />
                    <asp:BoundField DataField="idrol" HeaderText="idrol" SortExpression="nombres" />
                    <asp:BoundField DataField="rol" HeaderText="Rol" SortExpression="apellidoPat" />
                    <asp:BoundField DataField="idmodulo" HeaderText="idmodulo" SortExpression="apellidoMat" />
                     <asp:BoundField DataField="modulo" HeaderText="Modulo" SortExpression="telefono" />
                    <asp:BoundField DataField="estado" HeaderText="Estado" SortExpression="correo" />
                    <asp:CheckBoxField DataField="Habilitar"  HeaderText="Habilitar"   />
                   <asp:ButtonField HeaderText="Actualizar" ShowHeader="True" Text="Cambiar" CommandName="Actualizar" >
                    <FooterStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:ButtonField>



                </Columns>

<PagerStyle CssClass="pgr"></PagerStyle>
            </asp:GridView>
        </div>
    </div>

     
</asp:Content>