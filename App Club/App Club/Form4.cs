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
    public partial class Form4 : Form
    {
        private Alumno alumnoActual;

        public Form4(Alumno alumno)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.alumnoActual = alumno;
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3(alumnoActual); // ✅ ¡Ahora sí funciona!
            formulario.Show();
            this.Hide();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.SelectionLength = 0;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}

