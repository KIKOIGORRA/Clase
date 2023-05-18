using System.Drawing;
using System.Windows.Forms;
using TestVarios.Almacenes;

namespace TestVarios
{
    public partial class Form1 : Form
    {
        Flujo flujo = new Flujo();

        public Form1()
        {
            InitializeComponent();
            //flujo.CrearControles(this);
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.Anchor = AnchorStyles.None;

        }

        private void groupBox4_Enter(object sender, System.EventArgs e)
        {

        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}

