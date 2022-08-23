using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;


namespace disedu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void usuariotxt_Enter(object sender, EventArgs e)
        {
            if(usuariotxt.Text == "Usuario")
            {
                usuariotxt.Text = "";
                usuariotxt.ForeColor = Color.Black;
            }
        }

        private void usuariotxt_Leave(object sender, EventArgs e)
        {
            if(usuariotxt.Text == "")
            {
                usuariotxt.Text = "Usuario";
                usuariotxt.ForeColor = Color.Silver;
            }
        }

        private void contraseñatxt_Enter(object sender, EventArgs e)
        {
            if(contraseñatxt.Text == "Contraseña" )
            {
                contraseñatxt.Text = "";
                contraseñatxt.ForeColor = Color.Black;
                contraseñatxt.UseSystemPasswordChar = true;
            }
        }

        private void contraseñatxt_Leave(object sender, EventArgs e)
        {
            if(contraseñatxt.Text == "")
            {
                contraseñatxt.Text = "Contraseña";
                contraseñatxt.ForeColor = Color.Silver;
                contraseñatxt.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            menu m = new menu();
            m.ShowDialog();

            this.Close();

        }
    }
}
