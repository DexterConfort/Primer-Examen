using System.Windows.Forms;

namespace AngelCoello
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, System.EventArgs e)
        {
            Hide();

            Formulario1 Form1 = new Formulario1();
            Form1.Show();










        }

        private void toolStripButton3_Click(object sender, System.EventArgs e)
        {
            Hide();

            Formulario2 Form2 = new Formulario2();
            Form2.Show();
        }

        private void toolStripButton4_Click(object sender, System.EventArgs e)
        {
            Hide();

            Formulario3 Form3 = new Formulario3();
            Form3.Show();
        }
    }
}
