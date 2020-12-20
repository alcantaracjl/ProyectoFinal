using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionW.Vistas
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["iduser"] != null)
            {
                if (Session["accUSUARIO"] != null)
                {
                    this.DtgUsuario.DataSource = CapaLogicaW.clsUsuarioLogica.GetInstance().ListarUsuarios();
                    this.DtgUsuario.DataBind();
                }
                else
                {
                    Response.Redirect("Menu.aspx");
                }

            }
            else { Response.Redirect("index.aspx"); }









        }
        protected void CmdBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.TxtBuscar.Text.Trim()))
            { // cuanto hay texto y quiero buscar
                this.DtgUsuario.DataSource = CapaLogicaW.clsUsuarioLogica.GetInstance().BuscarUsuario(this.TxtBuscar.Text);
                this.DtgUsuario.DataBind();
            }
            else
            {
                this.DtgUsuario.DataSource = CapaLogicaW.clsUsuarioLogica.GetInstance().ListarUsuarios();  // restaurar la lista inicial
                this.DtgUsuario.DataBind();
            }
        }


        protected void CmdRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrar_Usuario.aspx");
           
            
        }



        protected void GVClientes_PageIndexChanging(object sender, GridViewPageEventArgs e) // paginado
        {
            DtgUsuario.PageIndex = e.NewPageIndex;
            DtgUsuario.DataBind();
        }
        protected void GVClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idusuario;
            idusuario = this.DtgUsuario.SelectedRow.Cells[0].Text;
            Session["idUsuario"] = idusuario;
            Response.Redirect("Registrar_Usuario.aspx");
        }

        protected void GVClientes_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string idusuario;
            idusuario = this.DtgUsuario.SelectedRow.Cells[0].Text;
            Session["idUsuario"] = idusuario;
            Response.Redirect("Registrar_Usuario.aspx");
        }

        protected void GVClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string idx;
            int index = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Seleccionar")
            {
                idx = Convert.ToString(DtgUsuario.DataKeys[index].Value);
                Session["idUsuario"] = idx;
                Response.Redirect("Registrar_Usuario.aspx");
            }
            if (e.CommandName == "Eliminar")
            {
                idx = Convert.ToString(this.DtgUsuario.DataKeys[index].Value);
                CapaLogicaW.clsUsuarioLogica.GetInstance().EliminarUsuario(idx);
                this.DtgUsuario.DataSource = CapaLogicaW.clsUsuarioLogica.GetInstance().ListarUsuarios();
                DtgUsuario.DataBind();
            }
        }

    }
}