using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega_3.Paneles
{
    public partial class FormUsuarioAdmin : Form
    {
        public FormUsuarioAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           // panel30.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
           // panel30.Visible = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
           // Reproductor2.Ctlcontrols.stop();
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
