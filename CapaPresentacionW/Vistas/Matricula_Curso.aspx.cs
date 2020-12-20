using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionW.Vistas
{
    public partial class Matricula_Curso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["iduser"] != null)
            {
                if (Session["accMATRICULA_CURSOS"] != null)
                {
                    CapaEntidadesW.clsUsuarioEntidad cls = new CapaEntidadesW.clsUsuarioEntidad();
                    cls = (CapaEntidadesW.clsUsuarioEntidad)Session["Login"];


                    this.dtgMatricula.DataSource = CapaLogicaW.clsMatriculaLogica.GetInstance().ListarMatriculaActivaIdUsuario(cls.Idusuario);
                    this.dtgMatricula.DataBind();

                }
                else
                {
                    Response.Redirect("Menu.aspx");
                }


            }
            else { Response.Redirect("index.aspx"); }
        }


        protected void GVForm_PageIndexChanging(object sender, GridViewPageEventArgs e) // paginado
        {
            dtgMatricula.PageIndex = e.NewPageIndex;
            dtgMatricula.DataBind();
        }


        protected void GVForm_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idx;
            int index = Convert.ToInt32(e.CommandArgument);
           
            if (e.CommandName == "Seleccionar")
            {
                idx = Convert.ToInt32(dtgMatricula.DataKeys[index].Value);
                Session["idCursoMatriculaReg"] = idx;

                Response.Redirect("Registrar_CursoMatricula.aspx");
            }
        }



    }
}