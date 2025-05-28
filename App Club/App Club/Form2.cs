using System;
using System.Threading;
using System.Windows.Forms;
using ValidacionesITTL;

namespace App_Club
{
    public partial class Form2 : Form
    {
        private MySQLHelper dbHelper = new MySQLHelper();

        public Form2()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btninisiarform2_Click(object sender, EventArgs e)
        {
            if (Validador.ValidarCampoVacio(txt1form2, "No. Control") &&
                Validador.ValidarCampoVacio(txt2form2, "Contraseña"))
            {
                object[] credenciales = new object[] { txt1form2.Text, txt2form2.Text };
                Thread hilo = new Thread(new ParameterizedThreadStart(VerificarCredenciales));
                hilo.Start(credenciales);
            }
        }

        private void VerificarCredenciales(object parametro)
        {
            object[] credenciales = (object[])parametro;
            string numControl = credenciales[0].ToString();
            string contrasenaIngresada = credenciales[1].ToString();
            string contrasenaEncriptada = Encriptador.EncriptarSHA256(contrasenaIngresada);

            try
            {
                Alumno alumno = dbHelper.GetAlumnoPorCredenciales(numControl, contrasenaEncriptada);

                this.Invoke(new MethodInvoker(() =>
                {
                    if (alumno != null)
                    {
                        MessageBox.Show("Credenciales correctas.");
                        Form3 formulario = new Form3(alumno);
                        formulario.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Número de control o contraseña incorrectos.");
                    }
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    MessageBox.Show("Error al verificar credenciales: " + ex.Message);
                }));
            }
        }

        private void btnregresarFo2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Hide();
        }

        private void txt1form2_TextChanged(object sender, EventArgs e) { }
        private void txt2form2_TextChanged(object sender, EventArgs e) { }
        private void Form2_Load(object sender, EventArgs e) { }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form formul = new Form1();
            formul.Show();
            this.Hide();
        }
    }
}

