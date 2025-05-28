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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Centro el formulario en la pantalla al cargar
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Alternativamente, podrías ponerlo aquí también:
            // this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void txt1Form1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            Form formula = new Form2();
            formula.Show();
            this.Hide();
        }

        private void btnInvitado_Click_1(object sender, EventArgs e)
        {
            Alumno invitado = new Alumno
            {
                numcontrol = "Invitado",
                nombreComp = "Invitado",
                carrera = "N/A",
                contraseña = ""
            };

            Form formulario = new Form3(invitado);
            formulario.Show();
            this.Hide();
        }
    }
}

