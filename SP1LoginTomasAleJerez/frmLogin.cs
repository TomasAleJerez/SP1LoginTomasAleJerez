using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP1LoginTomasAleJerez
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int intentos = 0; // contador de intentos de acceso
       
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "Administrador" && txtContraseña.Text == "adm135$") || (txtUsuario.Text == "Operador" && txtContraseña.Text == "ope246$"));
            {
                this.Hide();
                frmInicio f= new frmInicio();
                f.Text = txtUsuario.Text;
                f.ShowDialog();
                this.Show(); 
            }

            else 
            {
                MessageBox.Show("Datos incorrectos. Acceso denegado");
                intentos++;
                if (intentos == 3)
                {
                    this.Close();
                
                }
            }
        }
    }
}
