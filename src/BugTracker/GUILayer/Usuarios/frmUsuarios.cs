using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using BugTracker.BusinessLayer;
using BugTracker.Entities;

namespace BugTracker.GUILayer.Usuarios
{
    public partial class frmUsuarios : Form
    {

        private UsuarioService oUsuarioService;
        private PerfilService oPerfilService;

        public frmUsuarios()
        {
            InitializeComponent();
            //InitializeDataGridView();
            oUsuarioService = new UsuarioService();
            oPerfilService = new PerfilService();

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboPerfiles, oPerfilService.ObtenerTodos(), "Nombre", "IdPerfil");
            this.CenterToParent();
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMUsuario formulario = new frmABMUsuario();
            formulario.ShowDialog();

            //Forzamos el evento Click para actualizar la grilla.
            btnConsultar_Click(sender, e);
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chkTodos.Checked)
                {
                    txtNombre.Enabled = false;
                    cboPerfiles.Enabled = false;
                }
                else
                {
                    txtNombre.Enabled = true;
                    cboPerfiles.Enabled = true;
                }
            }
        }

        private void btnSalir_Click(System.Object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(System.Object sender, System.EventArgs e)
        {
            if (chkTodos.Checked)
            {
                try
                {
                    CargarGrilla(txtNombre.Text, cboPerfiles.SelectedIndex);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al intentar consultar en la base de datos");
                }
            }
            else
            {
                if (txtNombre.Text.Equals(""))
                {
                    MessageBox.Show("Error, todos los campos son obligatorios");
                    return;
                }
                else
                {
                    try
                    {
                        CargarGrilla(txtNombre.Text, cboPerfiles.SelectedIndex);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al intentar consultar en la base de datos");
                    }
                }
            }
            
        }

        private void btnEditar_Click(System.Object sender, System.EventArgs e)
        {
       
        }

        private void btnQuitar_Click(System.Object sender, System.EventArgs e)
        {
            
        }

        

        //Metodo para cargar la grilla
        private void CargarGrilla(string nombre, int perfil)
        {

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaDB"];

            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                string consulta = "";
                if (!nombre.Equals(""))
                {
                    consulta = "SELECT usuario, email, id_perfil FROM Usuarios WHERE @nombre like usuario ";
                }
                else if (nombre.Length == 0/* && perfil == 0*/)
                {
                    consulta = "SELECT usuario, email, id_perfil FROM Usuarios";
                }
                

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", nombre );
                //cmd.Parameters.AddWithValue("@perfil", perfil);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable table = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);

                dgvUsers.DataSource = table;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }


        }
    }
}
