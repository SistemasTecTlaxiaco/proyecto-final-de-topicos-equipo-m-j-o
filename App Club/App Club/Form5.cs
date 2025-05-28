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
    public partial class Form5 : Form
    {
        private Alumno alumnoActual;

        public Form5(Alumno alumno)
        {
            InitializeComponent();
            this.alumnoActual = alumno;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3(alumnoActual);
            formulario.Show();
            this.Hide();
        }

        private void btnregistrarse_f5_Click(object sender, EventArgs e)
        {
            Form formulario = new Form9(alumnoActual);
            formulario.Show();
            this.Hide();
        }
    }
}
