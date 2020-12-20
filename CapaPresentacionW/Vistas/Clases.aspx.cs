using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionW.Vistas
{
    public partial class Clases : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["iduser"] != null)
            {
                if (Session["accCLASES"] != null)
                {
                    this.dtgClases.DataSource = CapaLogicaW.clsClasesLogica.GetInstance().ListarClasesTodas();
                    this.dtgClases.DataBind();

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
                this.dtgClases.DataSource = CapaLogicaW.clsClasesLogica.GetInstance().BuscarClaseCurso(this.TxtBuscar.Text);
                this.dtgClases.DataBind();
            }
            else
            {
                this.dtgClases.DataSource = CapaLogicaW.clsClasesLogica.GetInstance().ListarClasesTodas();  // restaurar la lista inicial
                this.dtgClases.DataBind();
            }
        }


        protected void CmdRegistrar_Click(object sender, EventArgs e)
        {
            Session["idregistrar"] = null;
            Response.Redirect("Registrar_Clases.aspx");

        }



        protected void GVForm_PageIndexChanging(object sender, GridViewPageEventArgs e) // paginado
        {
            dtgClases.PageIndex = e.NewPageIndex;
            dtgClases.DataBind();
        }


        protected void GVForm_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idx;
            int index = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Seleccionar")
            {
                idx = Convert.ToInt32(dtgClases.DataKeys[index].Value);
                Session["idClasesReg"] = idx;
                Response.Redirect("Registrar_Clases.aspx");
            }
            if (e.CommandName == "Eliminar")
            {
                idx = Convert.ToInt32(this.dtgClases.DataKeys[index].Value);
                CapaLogicaW.clsClasesLogica.GetInstance().EliminarClase(idx);
                this.dtgClases.DataSource = CapaLogicaW.clsClasesLogica.GetInstance().ListarClasesTodas();
                dtgClases.DataBind();
            }
        }







    }
}