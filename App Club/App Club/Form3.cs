using System;
using System.Windows.Forms;

namespace App_Club
{
    public partial class Form3 : Form
    {
        private Alumno alumnoActual; // ✅ 1. Campo para guardar al alumno

        // ✅ 2. Constructor que recibe al alumno
        public Form3(Alumno alumno)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.alumnoActual = alumno;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Menu de Clubes";
        }

        // ✅ 3. Mostrar los datos al cargar el formulario
        private void Form3_Load(object sender, EventArgs e)
        {
            labelNumcontrol.Text = alumnoActual.numcontrol;
            labelNombre.Text = alumnoActual.nombreComp;
            labelCarrera.Text = alumnoActual.carrera;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario = new Form8(alumnoActual);
            formulario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Form4(alumnoActual);
            formulario.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form5(alumnoActual);
            formulario.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form6(alumnoActual);
            formulario.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario = new Form7(alumnoActual);
            formulario.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formulario = new Form9(alumnoActual);
            formulario.Show();
            this.Hide();
        }

        private void btnCerrarSes_f3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Hide();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            // Tu lógica si se usa
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Tu lógica si se usa
        }

        private void label4_Click(object sender, EventArgs e) { }
        private void label4_Click_1(object sender, EventArgs e) { }
        private void label4_Click_2(object sender, EventArgs e) { }
        private void label4_Click_3(object sender, EventArgs e) { }

        private void labelNombre_Click(object sender, EventArgs e) { }
        private void labelNumcontrol_Click(object sender, EventArgs e) { }
        private void labelCarrera_Click(object sender, EventArgs e) { }
    }
}

