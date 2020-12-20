using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionW.Vistas
{
    public partial class Registrar_Alumno : System.Web.UI.Page
    {
        public string idalumno = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
            {

                if (Session["iduser"] != null)
                {


                    cmdRegistrar.Enabled = false;



                    this.cboEscuela.DataSource = CapaLogicaW.clsEscuelaLogica.GetInstance().ListaEscuelasActivas();
                    cboEscuela.DataTextField = "Escuela";
                    cboEscuela.DataValueField = "idEscuela";
                    cboEscuela.DataBind();
                    
                    this.cboIngreso.DataSource = CapaLogicaW.clsPeriodoLogica.GetInstance().ListaPeriodos();
                    cboIngreso.DataTextField = "Periodo";
                    cboIngreso.DataValueField = "idPeriodo";
                     cboIngreso.DataBind();

                   

                    if (Session["idAlumnoReg"] != null)       // actualizacion
                        idalumno = (String)Session["idAlumnoReg"]; // saco el valor de la variable de sesion y la asigno a idcliente
                    if (idalumno != null)
                    {
                        CapaEntidadesW.clsAlumnoEntidad cls = new CapaEntidadesW.clsAlumnoEntidad();
                        cls = CapaLogicaW.clsAlumnoLogica.GetInstance().UbicarAlumno(idalumno);
                        if (cls != null)
                        {
                            this.txtcodalumno.Text = cls.CodAlumno;
                            this.txtidusuario.Text = cls.Idusuario;
                            this.lbxEstado.SelectedValue = cls.Estado;
                           this.cboEscuela.Items.FindByText(cls.NombreEscuela).Selected = true;
                          this.cboIngreso.Items.FindByText(cls.NombrePeriodo).Selected = true;
                            this.cmdRegistrar.Text = "Actualizar";
                            Session["idAlumnoReg"] = null;
                            cmdRegistrar.Enabled = true;
                            txtidusuario.Enabled = false;
                            btnNuevo.Enabled = false;
                            btnAlumno.Enabled = false;


                        }

                    }

                    else
                    {
                        cboIngreso.SelectedIndex = -1;
                        cboEscuela.SelectedIndex = -1;
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
            CapaEntidadesW.clsAlumnoEntidad cls = new CapaEntidadesW.clsAlumnoEntidad();
            cls.CodAlumno = txtcodalumno.Text;
            cls.Idusuario = txtidusuario.Text;
            cls.IdEscuela = Convert.ToInt32(cboEscuela.SelectedItem.Value);
            cls.IdPeriodo = Convert.ToInt32(cboIngreso.SelectedItem.Value);
            cls.Estado = lbxEstado.SelectedValue;

            if (idalumno == null)
            {
                CapaLogicaW.clsAlumnoLogica.GetInstance().RegistrarAlumno(cls);
                Response.Redirect("Alumno.aspx");
                idalumno = null;
            }
            else
            {
                CapaLogicaW.clsAlumnoLogica.GetInstance().ActualizarAlumno(cls);
                Response.Redirect("Alumno.aspx");
                idalumno = null;
            }
        }



        protected void cmdVerificar_Click(object sender, EventArgs e)
        {


            CapaEntidadesW.clsAlumnoEntidad cls = new CapaEntidadesW.clsAlumnoEntidad();
            cls = CapaLogicaW.clsAlumnoLogica.GetInstance().UbicarAlumnoIdUsuario(txtidusuario.Text);
            if (cls != null)
            {
                lblverificar.Text = "El usuario ya esta registrado como Alumno";
                cmdRegistrar.Enabled = false;
                
            }
            else
            {
                CapaEntidadesW.clsUsuarioEntidad cls2 = new CapaEntidadesW.clsUsuarioEntidad();
                cls2 = CapaLogicaW.clsUsuarioLogica.GetInstance().UbicarUsuario(txtidusuario.Text);
                if (cls2 != null)
                {
                    lblverificar.Text = "El usuario no esta registrado como Alumno";
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