using System;
using System.Windows.Forms;

namespace AngelCoello
{
    public partial class Formulario3 : Form
    {
        public Formulario3()
        {
            InitializeComponent();
            Numeros();
        }

        public void Numeros()
        {
            for (int i = 1; i <= 100; i++)
            {
                NumerosComboBox.Items.Add(i.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            MenuPrincipal regreso = new MenuPrincipal();
            regreso.Show();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {

            if (NombreTextBox.Text == "")
            {
                PosibleErrorProvider.SetError(NombreTextBox, "Ingrese su nombre");
                return;
            }
            PosibleErrorProvider.Clear();
            if (ApellidoTextBox.Text == "")
            {
                PosibleErrorProvider.SetError(ApellidoTextBox, "Ingrese su apellido");
                return;
            }
            PosibleErrorProvider.Clear();

            Habilitar();

            string nombre = NombreTextBox.Text;
            string apellido = ApellidoTextBox.Text;

            int numero = Convert.ToInt32(NumerosComboBox.Text);

            if ((numero % 3 == 0) && (numero % 5 == 0))
            {
                MessageBox.Show(nombre.ToUpper() + " " + apellido.ToUpper(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (numero % 3 == 0)
            {
                MessageBox.Show(nombre.ToUpper(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (numero % 5 == 0)
            {
                MessageBox.Show(apellido.ToUpper(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El numero seleccionado no es múltiplo de 3 o 5", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void RefrescarButton_Click(object sender, EventArgs e)
        {
            NombreTextBox.Text = "";
            ApellidoTextBox.Text = "";
            RefrescarButton.Enabled = false;
        }
        public void Habilitar()
        {
            RefrescarButton.Enabled = true;
        }
    }
}
