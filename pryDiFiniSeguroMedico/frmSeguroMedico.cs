using System.Diagnostics.CodeAnalysis;

namespace pryDiFiniSeguroMedico
{
    public partial class frmSeguroMedico : Form
    {
        public frmSeguroMedico()
        {
            InitializeComponent();
        }

        struct DatosClientes
        {
            public int DNI;
            public string Nombre;
            public int Edad;
            public bool Sexo;
            public bool LicenciaValida;
            public int Experiencia;
            public int Enfermedades;
            public int Accidentes;
            public string Plan; 
        }

        string[] Clientes = new string[19];
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DatosClientes c;

            c.DNI = Convert.ToInt32(mskDni.Text);
            c.Nombre = txtNombre.Text;
            c.Edad = Convert.ToInt32(nudEdad.Text);
            c.Sexo = cmbSexo.SelectedIndex == 0;
            c.LicenciaValida = cmbLicenciaValida.SelectedIndex == 0;
            c.Experiencia = Convert.ToInt32(txtExperiencia.Text);
            c.Enfermedades = Convert.ToInt32(txtEnfermedades.Text);
            c.Accidentes = Convert.ToInt32(txtAccidentes.Text);

            if (rdbBasico.Checked)
            {
                c.Plan = "Basico";
            }
            else if (rdbIntermedio.Checked)
            {
                c.Plan = "Intermedio";
            }
            else if (rdbPremium.Checked)
            {
                c.Plan = "Premium";
            }
            else
            {
                c.Plan = "No seleccionado";
            }

            if (c.Experiencia < 0 && c.Accidentes < 0)
            {
                MessageBox.Show("La experiencia y los accidentes no pueden ser negativos");
                return;
            }

            if (c.Experiencia > c.Edad - 17)
            {
                MessageBox.Show("La experiencia laboral no puede ser mayor que Edad - 17");
                return; 
            }

            if (c.LicenciaValida == false)
            {
                MessageBox.Show("Seguro rechazado");
                return;
            }
            if (c.Enfermedades>5)
            {
                MessageBox.Show("Seguro rechazado");
                return;
            }
            if (c.Accidentes>10)
            {
                MessageBox.Show("Seguro rechazado");
                return;
            }

            if (rdbBasico.Checked)
            {
                c.Plan = "Basico";
            }
            else if (rdbIntermedio.Checked)
            {
                c.Plan = "Intermedio";
            }
            else if (rdbPremium.Checked)
            {
                c.Plan = "Premium";
            }
            else
            {
                c.Plan = "No seleccionado";
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras y la tecla Backspace
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void txtExperiencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }

        }

        private void txtEnfermedades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void txtAccidentes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

     
    }


}
