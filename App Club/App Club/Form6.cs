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
    public partial class Form6 : Form
    {
        private Alumno alumnoActual;
        public Form6(Alumno alumnoActual)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.alumnoActual = alumnoActual;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Club de Voleibol";
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form9(alumnoActual);
            formulario.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMenu_f6_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3(alumnoActual);
            formulario.Show();
            this.Hide();
        }
    }
}
