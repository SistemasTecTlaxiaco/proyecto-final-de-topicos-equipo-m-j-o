using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Club
{
    public partial class Form8 : Form
    {
        private Alumno alumnoActual;
        public Form8(Alumno alumnoActual)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.alumnoActual = alumnoActual;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMenu_F8_Click(object sender, EventArgs e)
        {
            Form formulario = new Form9(alumnoActual);
            formulario.Show();
            this.Hide();
        }

        private void btnRegistrrse_f8_Click(object sender, EventArgs e)
        {
            Form formulario = new Form9(alumnoActual);
            formulario.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
