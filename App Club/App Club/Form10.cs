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
    public partial class Form10 : Form
    {
        private Alumno alumnoActual;
        public Form10(Alumno alumnoActual)
        {
            InitializeComponent();
            this.MaximizeBox = false; 
            this.MinimizeBox = false;
            this.alumnoActual = alumnoActual;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnRegresar_f10_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3(alumnoActual);
            formulario.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3(alumnoActual);
            formulario.Show();
            this.Hide();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
