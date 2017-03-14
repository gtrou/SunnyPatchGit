using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Contratos;
using Repositorio;

namespace Presentacion
{
    public partial class Logueo : Form
    {
        private IMantenimientoUsuario mantenimientoUsuario;

        public Logueo()
        {
            InitializeComponent();
        }

        private void btnAceptarLogueo_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == String.Empty || txtContraseña.Text == String.Empty)
            {
                MessageBox.Show("Se deben completar todos los campos para continuar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    bool autentico = true;
                        //mantenimientoUsuario.AutenticarUsuario(txtNombreUsuario.Text, txtContraseña.Text);
                    if (autentico)
                    {
                        ComenzarSesionUsuario();
                    }
                    else
                    {
                        MessageBox.Show("Error al iniciar sesión. El usuario/contraseña no son válidos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void ComenzarSesionUsuario()
        {
                MenuPrincipal ventanaPrincipal = new MenuPrincipal(txtNombreUsuario.Text);
                this.Hide();
                ventanaPrincipal.ShowDialog();
               if (ventanaPrincipal.Salir)
                {
                    this.Dispose();
                }
                else
                {
                   /* this.Show();
                    txtNombreUsuarioIniciarSesion.Text = String.Empty;
                    txtContraseñaIniciarSesion.Text = String.Empty;*/
                }
            
        }

    }
    
}
