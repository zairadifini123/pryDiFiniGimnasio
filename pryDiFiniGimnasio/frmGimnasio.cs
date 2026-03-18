namespace pryDiFiniGimnasio
{
    public partial class frmGimnasio : Form
    {
        public frmGimnasio()
        {
            InitializeComponent();
        }

        struct Datos
        {
            public string Nombre;
            public int DNI;
            public int Edad;
            public decimal Peso;
            public decimal Altura;
            public int AñosEntrenando;
        }

        string[] Socios = new string[30];
        decimal[] IMC = new decimal[30];
        int i = 0;

        // Variables para máximos
        decimal PersonaMasAlta = 0;
        string NombreMasAlto = "";

        int PersonaMasExperiencia = 0;
        string NombreMasExperiencia = "";

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Datos d;

            d.Nombre = txtNombre.Text;
            d.Edad = Convert.ToInt32(nudEdad.Text);
            d.DNI = Convert.ToInt32(mskDni.Text);
            d.Peso = Convert.ToDecimal(txtPeso.Text);
            d.Altura = Convert.ToDecimal(txtAltura.Text);
            d.AñosEntrenando = Convert.ToInt32(txtAñoEntrenando.Text);

            if (i >= Socios.Length)
            {
                MessageBox.Show("No se pueden ingresar más clientes.");
                return;
            }

            if (!ValidarDatos(d))
                return;

            // Guardar socio
            Socios[i] = d.Nombre;

            // Calcular IMC
            decimal imc = CalcularIMC(d);
            IMC[i] = imc;

            string clasificacion = ClasificarSocio(imc);
            lstClasificar.Items.Add("Clasificación: " + clasificacion);

            // Promedio IMC
            decimal suma = 0;

            for (int contador = 0; contador <= i; contador++)
                suma += IMC[contador];

            decimal promedio = suma / (i + 1);

            // Buscar mayor altura
            if (d.Altura > PersonaMasAlta)
            {
                PersonaMasAlta = d.Altura;
                NombreMasAlto = d.Nombre;
            }

            // Buscar mayor experiencia
            if (d.AñosEntrenando > PersonaMasExperiencia)
            {
                PersonaMasExperiencia = d.AñosEntrenando;
                NombreMasExperiencia = d.Nombre;
            }

            lstMostrar.Items.Add("Promedio IMC: " + promedio.ToString("0.00"));
            lstMostrar.Items.Add("Persona más alta: " + NombreMasAlto + " (" + PersonaMasAlta + " cm)");
            lstMostrar.Items.Add("Más experiencia: " + NombreMasExperiencia + " (" + PersonaMasExperiencia + " años)");

            i++;
        }

        bool ValidarDatos(Datos d)
        {
            if (d.Altura < 140 || d.Altura > 210)
            {
                MessageBox.Show("Altura debe estar entre 140 y 210 cm");
                return false;
            }

            if (d.Peso < 40 || d.Peso > 200)
            {
                MessageBox.Show("Peso debe estar entre 40 y 200 kg");
                return false;
            }

            if (d.AñosEntrenando > d.Edad - 16)
            {
                MessageBox.Show("Años entrenando no puede ser mayor que Edad - 16");
                return false;
            }

            return true;
        }

        decimal CalcularIMC(Datos d)
        {
            decimal imc = d.Peso / ((d.Altura / 100) * (d.Altura / 100));
            lblResultadosPeso.Text = "IMC: " + imc.ToString("0.00");
            return imc;
        }

        string ClasificarSocio(decimal imc)
        {
            if (imc < 18.5m)
                return "Bajo peso";
            else if (imc < 25)
                return "Normal";
            else if (imc < 30)
                return "Sobrepeso";
            else
                return "Obesidad";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mskDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y la tecla Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }

        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }

        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }

        }

        private void txtAñoEntrenando_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }

        }
    }
}