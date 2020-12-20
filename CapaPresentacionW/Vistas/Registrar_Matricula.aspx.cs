using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionW.Vistas
{
    public partial class Registrar_Matricula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {




            if (Page.IsPostBack == false)
            {

                if (Session["iduser"] != null)
                {


                    this.cboCiclo.DataSource = CapaLogicaW.clsCicloLogica.GetInstance().ListaCiclo();
                    cboCiclo.DataTextField = "Nombre";
                    cboCiclo.DataValueField = "idCiclo";
                    cboCiclo.DataBind();
                    //  cboHorario.SelectedIndex = -1;

                    this.cboPeriodo.DataSource = CapaLogicaW.clsPeriodoLogica.GetInstance().ListarPeriodoActivas();
                    cboPeriodo.DataTextField = "Periodo";
                    cboPeriodo.DataValueField = "idPeriodo";
                    cboPeriodo.DataBind();
                    // cboCurso.SelectedIndex = -1;


                    if (Session["idMatriculaReg"] != null)       // actualizacion
                        Session["idregistrar"] = (int)Session["idMatriculaReg"]; // saco el valor de la variable de sesion y la asigno a idcliente
                    if (Session["idregistrar"] != null)
                    {
                        CapaEntidadesW.clsMatriculaEntidad cls = new CapaEntidadesW.clsMatriculaEntidad();
                        cls = CapaLogicaW.clsMatriculaLogica.GetInstance().UbicarMatricula((int)Session["idregistrar"]);
                        if (cls != null)
                        {
                            this.cboCiclo.Items.FindByText(cls.Ciclo1).Selected = true;
                            this.cboPeriodo.Items.FindByText(cls.Periodo1).Selected = true;
                           this.cmdRegistrar.Text = "Actualizar";
                            Session["idMatriculaReg"] = null;



                        }

                    }

                }
                else { Response.Redirect("index.aspx"); }




                /*
                this.cbCategorias.Datasource = CapaLogica.ClsProductos.GetInstace().listarPrductos();
                DisplayMember = "Nombre";
                ValueMember = "IDProducto"; */
            }



        }


        protected void cmdRegistrar_Click(object sender, EventArgs e)
        {

            CapaEntidadesW.clsMatriculaEntidad cls = new CapaEntidadesW.clsMatriculaEntidad();

            cls.Fecha = DateTime.Now.Date;


            if (Session["idregistrar"] == null)
            {
                CapaEntidadesW.clsUsuarioEntidad Login = new CapaEntidadesW.clsUsuarioEntidad();
                Login = (CapaEntidadesW.clsUsuarioEntidad)Session["Login"];

              

                CapaEntidadesW.clsAlumnoEntidad Alum = new CapaEntidadesW.clsAlumnoEntidad();
                Alum = CapaLogicaW.clsAlumnoLogica.GetInstance().UbicarAlumnoIdUsuario(Login.Idusuario);


                cls.CodAlumno = Alum.CodAlumno;
                cls.IdCiclo = Convert.ToInt32(cboCiclo.SelectedItem.Value);
                cls.IdPeriodo = Convert.ToInt32(cboPeriodo.SelectedItem.Value);
                cls.Estado = "Activo";
                CapaLogicaW.clsMatriculaLogica.GetInstance().RegistrarMatricula(cls);
                Response.Redirect("Matricula.aspx");

            }

        }
    }
}