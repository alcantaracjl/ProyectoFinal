using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionW.Vistas
{
    public partial class Registrar_Curso : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {



            if (Page.IsPostBack == false)
            {

                if (Session["iduser"] != null)
                {
                                   

                    if (Session["idCursoReg"] != null)       // actualizacion
                        Session["idregistrar"] = (int)Session["idCursoReg"]; // saco el valor de la variable de sesion y la asigno a idcliente
                    if (Session["idregistrar"] != null)
                    {
                        CapaEntidadesW.clsCursoEntidad cls = new CapaEntidadesW.clsCursoEntidad();
                        cls = CapaLogicaW.clsCursosLogica.GetInstance().UbicarCurso((int)Session["idregistrar"]);
                        if (cls != null)
                        {
                           this.txtnombre.Text = cls.Nombre;
                            this.lbxEstado.SelectedValue = cls.Estado;
                            this.lblcreditos.SelectedValue = Convert.ToString(cls.Creditos);
                            this.cmdRegistrar.Text = "Actualizar";
                            
                            Session["idCursoReg"] = null;



                        }

                    }


                }
                else { Response.Redirect("index.aspx"); }

            }

        }

        protected void cmdRegistrar_Click(object sender, EventArgs e)
        {

            CapaEntidadesW.clsCursoEntidad cls = new CapaEntidadesW.clsCursoEntidad();
           
            cls.Nombre = txtnombre.Text;
            cls.Estado = lbxEstado.SelectedValue;
            cls.Creditos = Convert.ToInt32(lblcreditos.SelectedValue);
        
            if (Session["idregistrar"] == null)
            {

                CapaLogicaW.clsCursosLogica.GetInstance().RegistrarCurso(cls);
                Response.Redirect("Curso.aspx");

            }
            else
            {
                cls.IdCurso = (int)Session["idregistrar"];
                CapaLogicaW.clsCursosLogica.GetInstance().ActualizarCurso(cls);
                Session["idregistrar"] = null;
                Response.Redirect("Curso.aspx");
                



            }




         

        }






    }
}