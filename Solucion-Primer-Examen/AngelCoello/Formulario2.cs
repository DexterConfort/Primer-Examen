using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngelCoello
{
    public partial class Formulario2 : Form
    {
        public Formulario2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            MenuPrincipal regreso = new MenuPrincipal();
            regreso.Show();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (Descripcion1TextBox.Text == "")
            {
                PosibleErrorProvider.SetError(Descripcion1TextBox, "Ingrese un Producto");
                return;
            }
            PosibleErrorProvider.Clear();
            if (Precio1TextBox.Text == "")
            {
                PosibleErrorProvider.SetError(Precio1TextBox, "Ingrese el Precio");
                return;
            }
            PosibleErrorProvider.Clear();
            if (Descripcion2TextBox.Text == "")
            {
                PosibleErrorProvider.SetError(Descripcion2TextBox, "Ingrese un Producto");
                return;
            }
            PosibleErrorProvider.Clear();
            if (Precio2TextBox.Text == "")
            {
                PosibleErrorProvider.SetError(Precio2TextBox, "Ingrese el Precio");
                return;
            }
            PosibleErrorProvider.Clear();
            if (Descripcion3TextBox.Text == "")
            {
                PosibleErrorProvider.SetError(Descripcion3TextBox, "Ingrese un Producto");
                return;
            }
            PosibleErrorProvider.Clear();
            if (Precio3TextBox.Text == "")
            {
                PosibleErrorProvider.SetError(Precio3TextBox, "Ingrese el Precio");
                return;
            }
            PosibleErrorProvider.Clear();
            Habilitar();

            decimal precio1 = Convert.ToDecimal(Precio1TextBox.Text);
            decimal precio2 = Convert.ToDecimal(Precio2TextBox.Text);
            decimal precio3 = Convert.ToDecimal(Precio3TextBox.Text);

            decimal descuento = await DescuentoAsync(precio1, precio2, precio3);

            TotaFacturaLabel.Text = Convert.ToString(precio1 + precio2 + precio3);
            DescuentoLabel.Text = Convert.ToString(descuento);
            TotalLabel.Text = Convert.ToString((precio1 + precio2 + precio3) - descuento);

        }

        private async Task<decimal> DescuentoAsync(decimal precio1, decimal precio2, decimal precio3)
        {
            decimal porcentajeDescuento = 15;
            decimal descuento = await Task.Run(() =>
            {
                return (precio1 + precio2 + precio3) * porcentajeDescuento / 100;
            });
            return descuento;
        }


        public void Habilitar()
        {
            RefrescarButton.Enabled = true;
        }

        private void RefrescarButton_Click(object sender, EventArgs e)
        {
            Descripcion1TextBox.Text = "";
            Descripcion2TextBox.Text = "";
            Descripcion3TextBox.Text = "";
            Precio1TextBox.Text = "";
            Precio2TextBox.Text = "";
            Precio3TextBox.Text = "";
            DescuentoLabel.Text = "";
            TotalLabel.Text = "";
            TotaFacturaLabel.Text = "";
            RefrescarButton.Enabled = false;
        }
    }
}
