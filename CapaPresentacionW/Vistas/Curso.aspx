<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/principal.Master" AutoEventWireup="true" CodeBehind="Curso.aspx.cs" Inherits="CapaPresentacionW.Vistas.Curso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/styles.css" rel="stylesheet" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="Divleft" >
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label>
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
            <asp:GridView ID="dtgCurso" runat="server" AllowPaging="True" CssClass="mGrid" 
            PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" HorizontalAlign="Center"  OnPageIndexChanging="GVForm_PageIndexChanging" Width="1178px" AutoGenerateColumns="False"  DataKeyNames="idCurso" OnRowCommand="GVForm_RowCommand" 
            >
<AlternatingRowStyle CssClass="alt"></AlternatingRowStyle>

                <Columns>
                    <asp:BoundField DataField="idCurso" HeaderText="idCurso" SortExpression="idCurso" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                                        <asp:BoundField DataField="Creditos" HeaderText="Creditos" SortExpression="Creditos" />
                    <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
                    
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
