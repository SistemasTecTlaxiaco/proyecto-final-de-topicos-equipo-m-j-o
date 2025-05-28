using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidacionesITTL
{
    public class Validador
    {
        public static bool ValidarCredenciales(string usuario, string contraseña)
        {
            // Permitir cualquier usuario/contraseña no vacíos
            return !string.IsNullOrWhiteSpace(usuario) &&
                   !string.IsNullOrWhiteSpace(contraseña);
        }

        public static bool ValidarCampoVacio(TextBox textBox, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show($"{nombreCampo} no puede estar vacío.",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }
        public static bool ValidarRadioButton(params RadioButton[] radioButtons)
        {
            return radioButtons.Any(rb => rb.Checked);
        }



    }

}
