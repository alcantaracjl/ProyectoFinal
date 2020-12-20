using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionW.Vistas
{
    public partial class Registrar_Docente : System.Web.UI.Page
    {

 
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
            {

                if (Session["iduser"] != null)
                {


                    cmdRegistrar.Enabled = false;






                    if (Session["idDocenteReg"] != null)       // actualizacion
                        Session["idregistrar"] = (String)Session["idDocenteReg"]; // saco el valor de la variable de sesion y la asigno a idcliente
                    if (Session["idregistrar"] != null)
                    {
                        CapaEntidadesW.clsDocenteEntidad cls = new CapaEntidadesW.clsDocenteEntidad();
                        cls = CapaLogicaW.clsDocenteLogica.GetInstance().UbicarDocente((String)Session["idregistrar"]);
                        if (cls != null)
                        {
                            this.txtcoddocente.Text = cls.Iddocente;
                            this.txtidusuario.Text = cls.Idusuario;
                            this.lbxEstado.SelectedValue = cls.Estado;
                          
                            this.cmdRegistrar.Text = "Actualizar";
                            Session["idDocenteReg"] = null;
                            cmdRegistrar.Enabled = true;
                            txtidusuario.Enabled = false;
                            btnNuevo.Enabled = false;
                            btnAlumno.Enabled = false;


                        }

                    }


                }
                else { Response.Redirect("index.aspx"); }




            }






        }






        protected void cmdRegistrar_Click(object sender, EventArgs e)
        {
            CapaEntidadesW.clsDocenteEntidad cls = new CapaEntidadesW.clsDocenteEntidad();
            cls.Iddocente = txtcoddocente.Text;
            cls.Idusuario = txtidusuario.Text;
        
            cls.Estado = lbxEstado.SelectedValue;

            if (Session["idregistrar"] == null)
            {
                CapaLogicaW.clsDocenteLogica.GetInstance().RegistrarDocente(cls);
                Response.Redirect("Docente.aspx");
               
            }
            else
            {
                CapaLogicaW.clsDocenteLogica.GetInstance().ActualizarDocente(cls);
                Response.Redirect("Docente.aspx");
                Session["idregistrar"] = null;
            }
        }



        protected void cmdVerificar_Click(object sender, EventArgs e)
        {


            CapaEntidadesW.clsDocenteEntidad cls = new CapaEntidadesW.clsDocenteEntidad();
            cls = CapaLogicaW.clsDocenteLogica.GetInstance().UbicarDocenteIdUsuario(txtidusuario.Text);
            if (cls != null)
            {
                lblverificar.Text = "El usuario ya esta registrado como Docente";
                cmdRegistrar.Enabled = false;

            }
            else
            {
                CapaEntidadesW.clsDocenteEntidad cls2 = new CapaEntidadesW.clsDocenteEntidad();
                cls2 = CapaLogicaW.clsDocenteLogica.GetInstance().UbicarDocente(txtidusuario.Text);
                if (cls2 != null)
                {
                    lblverificar.Text = "El usuario no esta registrado como Docente";
                    cmdRegistrar.Enabled = true;
                    btnAlumno.Enabled = false;
                }
                else
                {
                    lblverificar.Text = "El usuario no existe";



                }







            }





        }

        protected void cmdNuevo_Click(object sender, EventArgs e)
        {
            txtidusuario.Text = "";
            btnAlumno.Enabled = true;
            cmdRegistrar.Enabled = false;




        }


    }
}