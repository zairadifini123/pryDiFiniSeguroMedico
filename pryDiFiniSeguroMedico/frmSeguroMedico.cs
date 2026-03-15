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

        struct Resultados
        {
            public decimal CostoBase;
            public decimal RecargosAplicados;
            public decimal DescuentosAplicados;
            public int ClientesAceptados;
            public int ClientesRechazados;
            public decimal PromedioCostoFinal;
            public decimal CostoFinal;
            public decimal CostoFinalAlto;
            public decimal CostoFinalBajo;
            public int ClientesBasico;
            public int ClientesIntermedio;
            public int ClientesPremium;
            public decimal PorcentajeClientesMayores;
            public decimal PorcentajeClientesAccidentes;
            public decimal TotalRecaudadoEmpresa;
        }

        string[] VecClientesAceptados = new string[20];
        string[] VecClientesRechazados = new string[20];
        string[] Clientes = new string[20];

        int i = 0;
        int iAceptados = 0;
        int iRechazados = 0;

        string ClienteCostoAlto = "";
        string ClienteCostoBajo = "";

        int ClientesBasico = 0;
        int ClientesIntermedio = 0;
        int ClientesPremium = 0;

        decimal TotalRecaudadoEmpresa = 0;
        decimal CostoFinalAlto = 0;
        decimal CostoFinalBajo = 0;
        decimal SumaCostos = 0;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DatosClientes c;

            c.DNI = Convert.ToInt32(mskDni.Text);
            c.Nombre = txtNombre.Text;
            c.Edad = Convert.ToInt32(nudEdad.Value);
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

            Resultados r;

            decimal CostoBase = 0;
            r.CostoBase = CostoBase;

            decimal DescuentosAplicados = 0;
            r.DescuentosAplicados = DescuentosAplicados;

            decimal RecargosAplicados = 0;
            r.RecargosAplicados = RecargosAplicados;

            decimal PromedioCostoFinal = 0;
            r.PromedioCostoFinal = PromedioCostoFinal;

            decimal CostoFinal = 0;
            r.CostoFinal = CostoFinal;

            decimal PorcentajeClientesMayores = 0;
            r.PorcentajeClientesMayores = PorcentajeClientesMayores;

            decimal PorcentajeClientesAccidentes = 0;
            r.PorcentajeClientesAccidentes = PorcentajeClientesAccidentes;

            if (c.Enfermedades < 0)
            {
                MessageBox.Show("Las enfermedades no pueden ser negativas");
                return;
            }

            if (c.Accidentes < 0)
            {
                MessageBox.Show("Los accidentes no pueden ser negativos");
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

            if (c.Enfermedades > 5)
            {
                MessageBox.Show("Seguro rechazado");
                return;
            }

            if (c.Accidentes > 10)
            {
                MessageBox.Show("Seguro rechazado");
                return;
            }

            if (i < Clientes.Length)
            {
                Clientes[i] = c.Nombre;
                i = i + 1;
            }
            else
            {
                MessageBox.Show("No se pueden ingresar más clientes, límite alcanzado.");
            }

            if (rdbBasico.Checked)
            {
                CostoBase = 25000;
            }
            else if (rdbIntermedio.Checked)
            {
                CostoBase = 40000;
            }
            else if (rdbPremium.Checked)
            {
                CostoBase = 60000;
            }
            else
            {
                CostoBase = 0;
            }

            decimal RecargosAplicadosEnfermedades = 0;
            decimal RecargosAplicadosAccidentes = 0;
            decimal RecargosAplicadosEdadMayores = 0;
            decimal RecargosAplicadosEdadMenores = 0;
            decimal RecargosAplicadosExperiencia = 0;

            if (c.Enfermedades > 0)
            {
                RecargosAplicadosEnfermedades = RecargosAplicadosEnfermedades + (0.08m * c.Enfermedades);
            }

            if (c.Accidentes > 0)
            {
                RecargosAplicadosAccidentes = RecargosAplicadosAccidentes + (0.10m * c.Accidentes);
            }

            int ClientesMayores = 0;

            if (c.Edad > 50)
            {
                RecargosAplicadosEdadMayores = RecargosAplicadosEdadMayores + 0.15m;
                ClientesMayores = ClientesMayores + 1;
            }

            if (i > 0)
            {
                PorcentajeClientesMayores = (decimal)ClientesMayores / i * 100;
            }

            if (c.Edad < 25)
            {
                RecargosAplicadosEdadMenores = RecargosAplicadosEdadMenores + 0.10m;
            }

            if (c.Experiencia < 2)
            {
                RecargosAplicadosExperiencia = RecargosAplicadosExperiencia + 0.12m;
            }

            RecargosAplicados = RecargosAplicadosAccidentes + RecargosAplicadosEnfermedades + RecargosAplicadosEdadMayores + RecargosAplicadosEdadMenores + RecargosAplicadosExperiencia;

            decimal DescuentosAplicadosEnfermedades = 0;
            decimal DescuentosAplicadosAccidentes = 0;
            decimal DescuentosAplicadosExperiencia = 0;

            if (c.Enfermedades == 0)
            {
                DescuentosAplicadosEnfermedades = DescuentosAplicadosEnfermedades - 0.05m;
            }

            int ClientesAccidentes = 0;

            if (c.Accidentes == 0)
            {
                DescuentosAplicadosAccidentes = DescuentosAplicadosAccidentes - 0.05m;
                ClientesAccidentes = ClientesAccidentes + 1;
            }

            if (i > 0)
            {
                PorcentajeClientesAccidentes = (decimal)ClientesAccidentes / i * 100;
            }

            if (c.Experiencia > 10)
            {
                DescuentosAplicadosExperiencia = DescuentosAplicadosExperiencia - 0.10m;
            }

            DescuentosAplicados = DescuentosAplicadosEnfermedades + DescuentosAplicadosAccidentes + DescuentosAplicadosExperiencia;

            if (iAceptados < VecClientesAceptados.Length)
            {
                VecClientesAceptados[iAceptados] = c.Nombre;
                iAceptados = iAceptados + 1;
            }

            if (c.Plan == "Basico")
            {
                ClientesBasico = ClientesBasico + 1;
            }
            else if (c.Plan == "Intermedio")
            {
                ClientesIntermedio = ClientesIntermedio + 1;
            }
            else if (c.Plan == "Premium")
            {
                ClientesPremium = ClientesPremium + 1;
            }

            CostoFinal = CostoBase + (CostoBase * RecargosAplicados) - (CostoBase * DescuentosAplicados);

            SumaCostos = SumaCostos + CostoFinal;

            if (iAceptados > 0)
            {
                PromedioCostoFinal = SumaCostos / iAceptados;
            }

            if (CostoFinal > CostoFinalAlto)
            {
                CostoFinalAlto = CostoFinal;
                ClienteCostoAlto = c.Nombre;
            }

            if (CostoFinalBajo == 0)
            {
                CostoFinalBajo = CostoFinal;
                ClienteCostoBajo = c.Nombre;
            }
            else if (CostoFinal < CostoFinalBajo)
            {
                CostoFinalBajo = CostoFinal;
                ClienteCostoBajo = c.Nombre;
            }

            TotalRecaudadoEmpresa = TotalRecaudadoEmpresa + CostoFinal;

            lstResultados.Items.Clear();

            lstResultados.Items.Add("Cantidad de clientes aceptados: " + iAceptados);
            lstResultados.Items.Add("Cantidad de clientes rechazados: " + iRechazados);
            lstResultados.Items.Add("Promedio del costo final de las pólizas aceptadas: " + PromedioCostoFinal);
            lstResultados.Items.Add("Cliente con el costo final mas alto: " + ClienteCostoAlto);
            lstResultados.Items.Add("Cliente con el costo final mas bajo: " + ClienteCostoBajo);
            lstResultados.Items.Add("Cantidad de clientes en plan Basico: " + ClientesBasico);
            lstResultados.Items.Add("Cantidad de clientes en plan Intermedio: " + ClientesIntermedio);
            lstResultados.Items.Add("Cantidad de clientes en plan Premium: " + ClientesPremium);
            lstResultados.Items.Add("Porcentaje de clientes mayores: % " + PorcentajeClientesMayores);
            lstResultados.Items.Add("Porcentaje de clientes con accidentes : % " + PorcentajeClientesAccidentes);
            lstResultados.Items.Add("Total recaudado por la empresa: $ " + TotalRecaudadoEmpresa);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtExperiencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEnfermedades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAccidentes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
