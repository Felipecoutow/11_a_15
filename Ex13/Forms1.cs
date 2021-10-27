using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template_VS
{
    public partial class frmPositivoOuNegativo : Form
    {
        /*Border Radius Forms*/
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
               int left,
               int top,
               int right,
               int bottom,
               int width,
               int height
           );
        public frmPositivoOuNegativo()
        {
            InitializeComponent();
            /*Nível de Radius da Borda (últimos dois valores)*/
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtResultado.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double N1;

            N1 = Convert.ToDouble(txtN1.Text);

            if (N1 > 0)
            {
                txtResultado.Text = N1 + " O número é positivo";
            }
            else
            {
                txtResultado.Text = N1 + " O número é negativo";
            }
        }
    }
}
