using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionW.Vistas
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["iduser"] != null)
            {
                if (Session["accPERFIL"] != null)
                {
                    if (Session["Login"] != null)
                    {

                        CapaEntidadesW.clsUsuarioEntidad cls = new CapaEntidadesW.clsUsuarioEntidad();
                        cls = (CapaEntidadesW.clsUsuarioEntidad)Session["Login"];
                        if (cls != null)
                        {
                            lblusuario.Text = cls.Idusuario;
                            lblnombre.Text = cls.Nombres;
                            lblapepat.Text = cls.ApellidoPat;
                            lblapemat.Text = cls.ApellidoMat;
                            lbltelefono.Text = cls.Telefono;
                            lblcorreo.Text = cls.Correo;
                            lblestado.Text = cls.Estado;
                            lbltipo.Text = cls.Tipousuario;
                        }

                    }

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