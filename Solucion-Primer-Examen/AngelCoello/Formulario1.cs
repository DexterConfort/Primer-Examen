using System;
using System.Windows.Forms;

namespace AngelCoello
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            MenuPrincipal regreso = new MenuPrincipal();
            regreso.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Habilitar();
            float capital = 200000;
            float[] interesArreglo = new float[12];
            String[] nombreMes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            float interes = 0, tasaInteres = 0.015F;
            int contador;




            for (int i = 0; i < 12; i++)
            {
                contador = i + 1;
                interes = (capital * contador * tasaInteres);
                capital = capital + interes;
                interesArreglo[i] = interes;
                InteresListBox.Items.Add("Intereses generados en el Mes de " + nombreMes[i] + ": " + interesArreglo[i]);
            }





        }

        public void Habilitar()
        {
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InteresListBox.Items.Clear();
            button3.Enabled = false;
        }
    }
}
