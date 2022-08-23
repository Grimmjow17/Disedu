using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace disedu
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Tiempo_tick (object sender, EventArgs e)
        {
            progressBar1.Increment(2);
            Opacity -= 0.010;
            nroDecarga.Text = progressBar1.Value.ToString() + "%";

            if (progressBar1.Value == progressBar1.Maximum)
            {
                Tiempo.Stop();
                this.Hide();
                Login f = new Login();
                f.ShowDialog();
            }
        }

    }
}
