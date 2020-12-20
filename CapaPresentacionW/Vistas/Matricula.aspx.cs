using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionW.Vistas
{
    public partial class Matricula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["iduser"] != null)
            {
                if (Session["accMATRICULA"] != null)
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






    


        protected void CmdRegistrar_Click(object sender, EventArgs e)
        {
            Session["idregistrar"] = null;
            Response.Redirect("Registrar_Matricula.aspx");

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
                Session["idMatriculaReg"] = idx;

                CapaEntidadesW.clsMatriculaEntidad cls2 = new CapaEntidadesW.clsMatriculaEntidad();
                cls2.IdMatricula=idx;
                cls2.Estado="Reservado";
                cls2.Fecha= DateTime.Now.Date;
                CapaLogicaW.clsMatriculaLogica.GetInstance().ReservarMatricula(cls2);
                Response.Redirect("Matricula.aspx");

            }
        }




    }
}