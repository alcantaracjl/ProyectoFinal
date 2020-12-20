<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/principal.Master" AutoEventWireup="true" CodeBehind="Docente.aspx.cs" Inherits="CapaPresentacionW.Vistas.Docente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/styles.css" rel="stylesheet" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="Divleft" >
        <div>
            <asp:Label ID="Label1" runat="server" Text="idDocente:"></asp:Label>
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
            <asp:GridView ID="dtgDocente" runat="server" AllowPaging="True" CssClass="mGrid" 
            PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" HorizontalAlign="Center"  OnPageIndexChanging="GVForm_PageIndexChanging" Width="1178px" AutoGenerateColumns="False"  DataKeyNames="iddocente" OnRowCommand="GVForm_RowCommand" 
            >
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>

                <Columns>
                    <asp:BoundField DataField="iddocente" HeaderText="iddocente" SortExpression="iddocente" />
                    <asp:BoundField DataField="idusuario" HeaderText="idusuario" SortExpression="idusuario" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
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
