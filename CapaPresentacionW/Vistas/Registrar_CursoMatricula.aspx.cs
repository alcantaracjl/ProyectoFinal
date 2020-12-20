using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionW.Vistas
{
    public partial class Registrar_CursoMatricula : System.Web.UI.Page
    {

                
        //hacerla sesion
        protected void Page_Load(object sender, EventArgs e)
        {

          


            if (Page.IsPostBack == false)
            {

                if (Session["iduser"] != null)
                {


                    
                    if (Session["idCursoMatriculaReg"] != null)       // actualizacion
                        Session["iddatos"] = (int)Session["idCursoMatriculaReg"]; // saco el valor de la variable de sesion y la asigno a idcliente
                    if (Session["iddatos"] != null)
                    {
                        CapaEntidadesW.clsMatriculaEntidad DatMatricula = new CapaEntidadesW.clsMatriculaEntidad();
                        DatMatricula = CapaLogicaW.clsMatriculaLogica.GetInstance().UbicarMatricula((int)Session["iddatos"]);
                        if (DatMatricula != null)
                        {

                            CapaEntidadesW.clsUsuarioEntidad datUsuario = new CapaEntidadesW.clsUsuarioEntidad();
                            datUsuario = (CapaEntidadesW.clsUsuarioEntidad)Session["Login"];

                            CapaEntidadesW.clsAlumnoEntidad datAlumno = new CapaEntidadesW.clsAlumnoEntidad();
                            datAlumno = CapaLogicaW.clsAlumnoLogica.GetInstance().UbicarAlumnoIdUsuario(datUsuario.Idusuario);



                            this.dtgClases.DataSource = CapaLogicaW.clsClasesLogica.GetInstance().ListarClasesporCicloNoRegistradas(datAlumno.IdEscuela,DatMatricula.IdCiclo,datAlumno.CodAlumno);
                            this.dtgClases.DataBind();
                            dtgCursos.DataSource = ((DataTable)Session["tablita"]);
                            dtgCursos.DataBind();
                         

                          

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




        protected void GVForm_PageIndexChanging(object sender, GridViewPageEventArgs e) // paginado
        {
            dtgClases.PageIndex = e.NewPageIndex;
            dtgClases.DataBind();
        }


        protected void GVForm_RowCommand(object sender, GridViewCommandEventArgs e)
        {
           int idx;
            int existe=0;
            int suma = 0;

            int index = Convert.ToInt32(e.CommandArgument);
            idx = Convert.ToInt32(dtgClases.DataKeys[index].Value);
            Session["idregistrar"] = idx;
            if (e.CommandName == "Seleccionar")
            {
                CapaEntidadesW.clsClasesEntidad datClase = new CapaEntidadesW.clsClasesEntidad();
                datClase = CapaLogicaW.clsClasesLogica.GetInstance().UbicarClase(idx);

                CapaEntidadesW.clsCursoEntidad datCurs = new CapaEntidadesW.clsCursoEntidad();
                datCurs = CapaLogicaW.clsCursosLogica.GetInstance().UbicarCurso(datClase.IdCurso);


                if (((DataTable)Session["tablita"]).Rows.Count > 0) {

                    foreach (DataRow f in ((DataTable)Session["tablita"]).Rows)
                    {

                        if (Convert.ToInt32(f[((DataTable)Session["tablita"]).Columns[1]].ToString()) == datClase.IdCurso)
                        {
                            // valor = Convert.ToInt32(f[dt.Columns[1]].ToString());
                            existe = 1;
                        }

                    }

                }




                if (existe == 0) {


                    if (((DataTable)Session["tablita"]).Rows.Count > 0)
                    {

                        foreach (DataRow f in ((DataTable)Session["tablita"]).Rows)
                        {

                           suma=suma+ Convert.ToInt32(f[((DataTable)Session["tablita"]).Columns[3]].ToString());
                                                   }

                    }



                    if (suma+datCurs.Creditos<=20)
                    {
                        DataRow row = ((DataTable)Session["tablita"]).NewRow();
                        row["idClase"] = datClase.Idclases;
                        row["idCurso"] = datClase.IdCurso;
                        row["Nombre"] = datClase.NombreCurso1;
                        row["Creditos"] = datCurs.Creditos;
                        ((DataTable)Session["tablita"]).Rows.Add(row);
                        dtgCursos.DataSource = ((DataTable)Session["tablita"]);
                        dtgCursos.DataBind();
                        suma = 0;
                    }

                                    }
                else {
                    existe = 0;
                }



                


                

               // Response.Redirect("Registrar_CursoMatricula.aspx");
            }
        }


        protected void GVForm2_PageIndexChanging(object sender, GridViewPageEventArgs e) // paginado
        {
            dtgCursos.PageIndex = e.NewPageIndex;
            dtgCursos.DataBind();
        }


        protected void GVForm2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
        }

        protected void cmdRegistrar_Click(object sender, EventArgs e)
        {
            CapaEntidadesW.clsDetalleMatriculaEntidad cls = new CapaEntidadesW.clsDetalleMatriculaEntidad();
            if (((DataTable)Session["tablita"]).Rows.Count > 0)
            {
                foreach (DataRow f in ((DataTable)Session["tablita"]).Rows)
                {
                    cls.IdMatricula = (int)Session["idCursoMatriculaReg"];
                    cls.IdClases= Convert.ToInt32(f[((DataTable)Session["tablita"]).Columns[0]].ToString());
                    cls.Estado = "Activo";

                    CapaLogicaW.clsDetalleMatriculaLogica.GetInstance().RegistrarDetalleMatricula(cls);
                    
                    


                }
                Session["idCursoMatriculaReg"] = null;
                Session["idregistrar"] = null;
                Response.Redirect("Menu.aspx");
            }





           
        }



    }
}