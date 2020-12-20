using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionW.Vistas
{
    public partial class Curso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["iduser"] != null)
            {
                if (Session["accCURSO"] != null)
                {
                    this.dtgCurso.DataSource = CapaLogicaW.clsCursosLogica.GetInstance().ListaCursos();
                    this.dtgCurso.DataBind();

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
                this.dtgCurso.DataSource = CapaLogicaW.clsCursosLogica.GetInstance().BuscarCursoNombre(this.TxtBuscar.Text);
                this.dtgCurso.DataBind();
            }
            else
            {
                this.dtgCurso.DataSource = CapaLogicaW.clsCursosLogica.GetInstance().ListaCursos();  // restaurar la lista inicial
                this.dtgCurso.DataBind();
            }
        }


        protected void CmdRegistrar_Click(object sender, EventArgs e)
        {
            Session["idregistrar"] = null;
            Response.Redirect("Registrar_Curso.aspx");
                        
        }



        protected void GVForm_PageIndexChanging(object sender, GridViewPageEventArgs e) // paginado
        {
            dtgCurso.PageIndex = e.NewPageIndex;
            dtgCurso.DataBind();
        }


        protected void GVForm_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idx;
            int index = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Seleccionar")
            {
                idx = Convert.ToInt32(dtgCurso.DataKeys[index].Value);
                Session["idCursoReg"] = idx;
                Response.Redirect("Registrar_Curso.aspx");
            }
            if (e.CommandName == "Eliminar")
            {
                idx = Convert.ToInt32(this.dtgCurso.DataKeys[index].Value);
                CapaLogicaW.clsCursosLogica.GetInstance().EliminarCurso(idx);
                this.dtgCurso.DataSource = CapaLogicaW.clsCursosLogica.GetInstance().ListaCursos();
                dtgCurso.DataBind();
            }
        }






    }
}