using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacionW.Vistas
{
    public partial class Registrar_Usuario : System.Web.UI.Page
    {
        public string idUsuario = null;
     
        protected void Page_Load(object sender, EventArgs e)
        {

          
            if (Page.IsPostBack == false)
            {

                if (Session["iduser"] != null)
                {



                    this.cboTipousuario.DataSource = CapaLogicaW.clsRolLogica.GetInstance().ListarRoles();
                    cboTipousuario.DataTextField = "nombre";
                    cboTipousuario.DataValueField = "idrol";

                    cboTipousuario.DataBind();

                    cboTipousuario.SelectedIndex = -1;



                    if (Session["idUsuario"] != null)       // actualizacion
                        idUsuario = (string)Session["idUsuario"]; // saco el valor de la variable de sesion y la asigno a idcliente
                    if (idUsuario != null)
                    {
                        CapaEntidadesW.clsUsuarioEntidad cls = new CapaEntidadesW.clsUsuarioEntidad();
                        cls = CapaLogicaW.clsUsuarioLogica.GetInstance().UbicarUsuario(idUsuario);
                        if (cls != null)
                        {
                            this.txtUsuario.Text = cls.Idusuario;
                            this.txtContrasenia.Text = cls.Contrasenia;
                            this.txtNombre.Text = cls.Nombres;
                            this.TxtApellidopat.Text = cls.ApellidoPat;
                            this.txtApellidomat.Text = cls.ApellidoMat;
                            this.txtTelefono.Text = cls.Telefono;
                            this.txtCorreo.Text = cls.Correo;
                            this.lbxEstado.SelectedValue = cls.Estado;
                            //this.cboTipousuario.SelectedIndex = cls.Idrol;
                            //this.lbxEstado.SelectedIndex = Convert.ToInt32(Clie.Genero1);
                            //this.lbxTipousuario.SelectedIndex = Convert.ToInt32(Clie.TipoCliente1);
                            this.cboTipousuario.Items.FindByText(cls.Tipousuario).Selected = true;
                            this.cmdRegistrar.Text = "Actualizar";
                            Session["idUsuario"] = null;
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
            CapaEntidadesW.clsUsuarioEntidad cls = new CapaEntidadesW.clsUsuarioEntidad();
            cls.Idusuario = txtUsuario.Text;
            cls.Contrasenia = txtContrasenia.Text;
            cls.Nombres = txtNombre.Text;
            cls.ApellidoPat = this.TxtApellidopat.Text;
                       cls.ApellidoMat = this.txtApellidomat.Text;
            cls.Telefono = txtTelefono.Text;
            cls.Correo = txtCorreo.Text;
                        cls.Estado = lbxEstado.SelectedValue;


        
            cls.Idrol=Convert.ToInt32(cboTipousuario.SelectedItem.Value);


            if ( idUsuario!= null)
            {
                CapaLogicaW.clsUsuarioLogica.GetInstance().RegistrarUsuario(cls);
                Response.Redirect("Usuarios.aspx");
                idUsuario = null;
            }
            else
            {
                               CapaLogicaW.clsUsuarioLogica.GetInstance().ActualizarUsuario(cls);
                Response.Redirect("Usuarios.aspx");
                idUsuario = null;
            }
        }



    }
}