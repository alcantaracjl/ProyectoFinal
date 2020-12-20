using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionW.Vistas
{
    public partial class Alumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["iduser"] != null)
            {
                if (Session["accALUMNO"] != null)
                {
                   this.DtgAlumno.DataSource = CapaLogicaW.clsAlumnoLogica.GetInstance().ListaAlumnos();
                   this.DtgAlumno.DataBind();

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
                this.DtgAlumno.DataSource = CapaLogicaW.clsAlumnoLogica.GetInstance().BuscarAlumnoIdUsuario(this.TxtBuscar.Text);
                this.DtgAlumno.DataBind();
            }
            else
            {
                this.DtgAlumno.DataSource = CapaLogicaW.clsAlumnoLogica.GetInstance().ListaAlumnos();  // restaurar la lista inicial
                this.DtgAlumno.DataBind();
            }
        }


        protected void CmdRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrar_Alumno.aspx");


        }



        protected void GVForm_PageIndexChanging(object sender, GridViewPageEventArgs e) // paginado
        {
            DtgAlumno.PageIndex = e.NewPageIndex;
            DtgAlumno.DataBind();
        }
   

        protected void GVForm_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string idx;
            int index = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Seleccionar")
            {
                idx = Convert.ToString(DtgAlumno.DataKeys[index].Value);
                Session["idAlumnoReg"] = idx;
                Response.Redirect("Registrar_Alumno.aspx");
            }
            if (e.CommandName == "Eliminar")
            {
                idx = Convert.ToString(this.DtgAlumno.DataKeys[index].Value);
                CapaLogicaW.clsAlumnoLogica.GetInstance().EliminarAlumno(idx);
                this.DtgAlumno.DataSource = CapaLogicaW.clsAlumnoLogica.GetInstance().ListaAlumnos();
                DtgAlumno.DataBind();
            }
        }








    }




}
