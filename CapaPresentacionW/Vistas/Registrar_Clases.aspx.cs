using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionW.Vistas
{
    public partial class Registrar_Clases : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            if (Page.IsPostBack == false)
            {

                if (Session["iduser"] != null)
                {


                    this.cboHorario.DataSource = CapaLogicaW.clsHorarioLogica.GetInstance().ListaHorarios();
                    cboHorario.DataTextField = "Horario";
                    cboHorario.DataValueField = "idHorario";
                    cboHorario.DataBind();
                  //  cboHorario.SelectedIndex = -1;

                    this.cboCurso.DataSource = CapaLogicaW.clsCursosLogica.GetInstance().ListaCursosActivas();
                    cboCurso.DataTextField = "Nombre";
                    cboCurso.DataValueField = "idCurso";
                    cboCurso.DataBind();
                    // cboCurso.SelectedIndex = -1;

                    this.cboSeccion.DataSource = CapaLogicaW.clsSeccionLogica.GetInstance().ListaSecciones();
                    cboSeccion.DataTextField = "Seccion";
                    cboSeccion.DataValueField = "idSeccion";
                    cboSeccion.DataBind();
                    // cboCurso.SelectedIndex = -1;

                    this.cboDocente.DataSource = CapaLogicaW.clsDocenteLogica.GetInstance().ListaDocentes();
                    cboDocente.DataTextField = "Nombre";
                    cboDocente.DataValueField = "iddocente";
                    cboDocente.DataBind();
                    // cboDocente.SelectedIndex = -1;


                    if (Session["idClasesReg"] != null)       // actualizacion
                        Session["idregistrar"] = (int)Session["idClasesReg"]; // saco el valor de la variable de sesion y la asigno a idcliente
                    if (Session["idregistrar"] != null)
                    {
                        CapaEntidadesW.clsClasesEntidad cls = new CapaEntidadesW.clsClasesEntidad();
                        cls = CapaLogicaW.clsClasesLogica.GetInstance().UbicarClase((int)Session["idregistrar"]);
                        if (cls != null)
                        {
                            this.cboHorario.Items.FindByText(cls.NombreHorario1).Selected = true;
                            this.cboCurso.Items.FindByText(cls.NombreCurso1).Selected = true;
                            this.cboSeccion.Items.FindByText(cls.NombreSeccion1).Selected = true;
                            this.cboDocente.Items.FindByText(cls.NombreDocente1).Selected = true;
                            this.lbxEstado.SelectedValue = cls.Estado;
                            this.txtvacantes.Text = Convert.ToString(cls.Vacantes);
                            this.cmdRegistrar.Text = "Actualizar";
                            Session["idClasesReg"] = null;



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

            CapaEntidadesW.clsClasesEntidad cls = new CapaEntidadesW.clsClasesEntidad();

            cls.IdHorario = Convert.ToInt32(cboHorario.SelectedItem.Value);

            cls.IdCurso = Convert.ToInt32(cboCurso.SelectedItem.Value);
            cls.IdSeccion = Convert.ToInt32(cboSeccion.SelectedItem.Value);
            cls.Iddocente = Convert.ToInt32(cboDocente.SelectedItem.Value);
            cls.Vacantes = Convert.ToInt32(txtvacantes.Text);
            cls.Estado = lbxEstado.SelectedValue;
           

            if (Session["idregistrar"] == null)
            {

                CapaLogicaW.clsClasesLogica.GetInstance().RegistrarClase(cls);
                Response.Redirect("Clases.aspx");

            }
            else
            {
                cls.Idclases = (int)Session["idregistrar"];
                CapaLogicaW.clsClasesLogica.GetInstance().ActualizarClase(cls);
                Session["idregistrar"] = null;
                Response.Redirect("Clases.aspx");




            }






        }
    }
}