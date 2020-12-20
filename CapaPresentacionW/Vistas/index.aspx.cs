using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { Session.Clear(); }

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            CapaEntidadesW.clsUsuarioEntidad Cls = new CapaEntidadesW.clsUsuarioEntidad();
           Cls= CapaLogicaW.clsUsuarioLogica.GetInstance().Acceso(this.txtusuario.Text, this.txtclave.Text);
            try
            {
                if (Cls!=null)
                {
                    Session["iduser"] = Cls.Idusuario;
                                        DataTable tabla = new DataTable();
                   tabla=(CapaLogicaW.clsRolModuloLogica.GetInstance().BuscarRolModuloIdRol(Cls.Idrol));
                    Session["Permisos"] = tabla;
                    DataTable dt = new DataTable();
                    dt.Columns.Add("idClase");
                    dt.Columns.Add("idCurso");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Creditos");
                    Session["tablita"] = dt;




                    Response.Redirect("Menu.aspx");

                   

                }
                else
                {
                  
                    
                    this.lblmensaje.Visible = true;
                    this.lblmensaje.Text = "Usuario Incorrecto";

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}