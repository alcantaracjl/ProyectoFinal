using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionW.Vistas
{
    public partial class Docente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["iduser"] != null)
            {
                if (Session["accDOCENTE"] != null)
                {
                    this.dtgDocente.DataSource = CapaLogicaW.clsDocenteLogica.GetInstance().ListaDocentes();
                    this.dtgDocente.DataBind();

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
                this.dtgDocente.DataSource = CapaLogicaW.clsDocenteLogica.GetInstance().BuscarDocentePat(this.TxtBuscar.Text);
                this.dtgDocente.DataBind();
            }
            else
            {
                this.dtgDocente.DataSource = CapaLogicaW.clsDocenteLogica.GetInstance().ListaDocentes();  // restaurar la lista inicial
                this.dtgDocente.DataBind();
            }
        }


        protected void CmdRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrar_Docente.aspx");
            Session["idregistrar"] = null;
        }



        protected void GVForm_PageIndexChanging(object sender, GridViewPageEventArgs e) // paginado
        {
            dtgDocente.PageIndex = e.NewPageIndex;
            dtgDocente.DataBind();
        }


        protected void GVForm_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string idx;
            int index = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Seleccionar")
            {
                idx = Convert.ToString(dtgDocente.DataKeys[index].Value);
                Session["idDocenteReg"] = idx;
                Response.Redirect("Registrar_Docente.aspx");
            }
            if (e.CommandName == "Eliminar")
            {
                idx = Convert.ToString(this.dtgDocente.DataKeys[index].Value);
                CapaLogicaW.clsDocenteLogica.GetInstance().EliminarDocente(idx);
                this.dtgDocente.DataSource = CapaLogicaW.clsDocenteLogica.GetInstance().ListaDocentes();
                dtgDocente.DataBind();
            }
        }






    }
}