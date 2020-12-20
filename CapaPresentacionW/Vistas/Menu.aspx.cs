using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionW.Vistas
{
    public partial class Menu : System.Web.UI.Page
    {



       





        public string idUser = null;
       public DataTable Permisos = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            string idUser = null;


            if (!IsPostBack)
            {

                if (Session["iduser"] != null)
                {
                    idUser = (string)Session["iduser"];
                    CapaEntidadesW.clsUsuarioEntidad Login = new CapaEntidadesW.clsUsuarioEntidad();
                    Login = CapaLogicaW.clsUsuarioLogica.GetInstance().UbicarUsuario(idUser);
                    if (Login != null)
                    {
                        Session["Login"] = Login;
                       
                    }

                    if (Session["Permisos"] != null)
                    {

                        Permisos = (DataTable)Session["Permisos"];

                        for (int i = 0; i < Permisos.Rows.Count; i++)
                        {

                            switch (Permisos.Rows[i]["modulo"].ToString())
                            {
                                case "ALUMNO":
                                    if (Permisos.Rows[i]["estado"].ToString() == "Activo")
                                    { Session["accALUMNO"] = 1; }
                                    break;
                                case "CICLO":
                                    if (Permisos.Rows[i]["estado"].ToString() == "Activo")
                                    { Session["accCICLO"] = 1; }
                                    break;
                                case "CLASES":
                                    if (Permisos.Rows[i]["estado"].ToString() == "Activo")
                                    { Session["accCLASES"] = 1; }
                                    break;
                                case "CURSO":
                                    if (Permisos.Rows[i]["estado"].ToString() == "Activo")
                                    { Session["accCURSO"] = 1; }
                                    break;
                                case "DOCENTE":
                                    if (Permisos.Rows[i]["estado"].ToString() == "Activo")
                                    { Session["accDOCENTE"] = 1; }
                                    break;
                                case "ESCUELA":
                                    if (Permisos.Rows[i]["estado"].ToString() == "Activo")
                                    { Session["accESCUELA"] = 1; }
                                    break;
                                case "FACULTAD":
                                    if (Permisos.Rows[i]["estado"].ToString() == "Activo")
                                    { Session["accFACULTAD"] = 1; }
                                    break;
                                case "HORARIO":
                                    if (Permisos.Rows[i]["estado"].ToString() == "Activo")
                                    { Session["accHORARIO"] = 1; }
                                    break;
                                case "MATRICULA":
                                    if (Permisos.Rows[i]["estado"].ToString() == "Activo")
                                    { Session["accMATRICULA"] = 1; }
                                    break;
                                case "MATRICULA_CURSOS":
                                    if (Permisos.Rows[i]["estado"].ToString() == "Activo")
                                    { Session["accMATRICULA_CURSOS"] = 1; }
                                    break;
                                case "PLANESTUDIO":
                                    if (Permisos.Rows[i]["estado"].ToString() == "Activo")
                                    { Session["accPLANESTUDIO"] = 1; }
                                    break;
                                case "PLANESTUDIO_CURSOS":
                                    if (Permisos.Rows[i]["estado"].ToString() == "Activo")
                                    { Session["accPLANESTUDIO_CURSOS"] = 1; }
                                    break;
                                case "ROL":
                                    if (Permisos.Rows[i]["estado"].ToString() == "Activo")
                                    { Session["accROL"] = 1; }
                                    break;
                                case "ROL_MODULO":
                                    if (Permisos.Rows[i]["estado"].ToString() == "Activo")
                                    { Session["accROL_MODULO"] = 1; }
                                    break;
                                case "SECCION":
                                    if (Permisos.Rows[i]["estado"].ToString() == "Activo")
                                    { Session["accSECCION"] = 1; }
                                    break;
                                case "MODULO":
                                    if (Permisos.Rows[i]["estado"].ToString() == "Activo")
                                    { Session["accMODULO"] = 1; }
                                    break;
                                case "USUARIO":
                                    if (Permisos.Rows[i]["estado"].ToString() == "Activo")
                                    { Session["accUSUARIO"] = 1; }
                                    break;
                                case "PERFIL":
                                    if (Permisos.Rows[i]["estado"].ToString() == "Activo")
                                    { Session["accPERFIL"] = 1; }
                                    break;
                                default:
                                    //numero = "error";
                                    break;
                            }


                        }
                        Session["Permisos"] = null;
                    }

                }
                else { Response.Redirect("index.aspx"); }



            }


           



        }
    }
}