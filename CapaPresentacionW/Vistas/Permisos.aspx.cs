using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionW.Vistas
{
    public partial class Permisos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["iduser"] != null)
            {
                if (Session["accROL_MODULO"] != null)
            {
               this.DtgPermisos.DataSource = CapaLogicaW.clsRolModuloLogica.GetInstance().ListarPermisos();
              this.DtgPermisos.DataBind();

                }
                        else
                      {
                       Response.Redirect("Menu.aspx");
                      }


            }
            else { Response.Redirect("index.aspx"); }

                
            
            // 
        }




        protected void GVClientes_PageIndexChanging(object sender, GridViewPageEventArgs e) // paginado
        {
            DtgPermisos.PageIndex = e.NewPageIndex;
            DtgPermisos.DataBind();
        }
       

       

        protected void chkItem_CheckedChanged(object sender, EventArgs e)
        {
            int idrolmodulo;
            idrolmodulo = Convert.ToInt32(this.DtgPermisos.SelectedRow.Cells[0].Text);
        }

        protected void DtgPermisos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GVPermiso_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idx;
            int index = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Actualizar")
            {


                idx = Convert.ToInt32(DtgPermisos.DataKeys[index].Value);
                CapaLogicaW.clsRolModuloLogica.GetInstance().CambiarRolModulo(idx);
                Response.Redirect("Permisos.aspx");
            }
            
        }
    }
}