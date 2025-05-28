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
    public partial class Form7 : Form
    {
        private Alumno alumnoActual;
        public Form7(Alumno alumnoActual)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.alumnoActual = alumnoActual;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMenu_f7_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3(alumnoActual);
            formulario.Show();
            this.Hide();
        }

        private void btnRegistrarse_f7_Click(object sender, EventArgs e)
        {
            Form formulario = new Form9(alumnoActual);
            formulario.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
