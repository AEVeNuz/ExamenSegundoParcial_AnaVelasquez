using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Accesos;
using Datos.Entidades;

namespace Ejercicio3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(UsuarioTextBox.Text, ClaveTextBox.Text);


            if (usuario == null)
            {
                MessageBox.Show("Datos erróneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!usuario.EstaActivo)
            {
                MessageBox.Show("Usuario inactivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return ;
            }

            FrmMenu frmMenu = new FrmMenu();
            frmMenu.ShowDialog();
            this.Hide();

            
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsuarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
