using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionW.Vistas
{
    public partial class PlanEstudio_Curso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["iduser"] != null)
            {
                if (Session["accPLANESTUDIO_CURSOS"] != null)
                {
                    // this.DtgPermisos.DataSource = CapaLogicaW.clsRolModuloLogica.GetInstance().ListarPermisos();
                    // this.DtgPermisos.DataBind();

                }
                else
                {
                    Response.Redirect("Menu.aspx");
                }


            }
            else { Response.Redirect("index.aspx"); }
        }
    }
}