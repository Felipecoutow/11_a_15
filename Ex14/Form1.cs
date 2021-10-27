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
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
            /*Nível de Radius da Borda (últimos dois valores)*/
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double N1, N2, R;

            N1 = Convert.ToDouble(txtN1.Text);
            N2 = Convert.ToDouble(txtN2.Text);
            R = N1 / N2;

            if (N2 == 0)
            {
                txtResultado.Text = "Não foi possivel";
            }
            else
            {
                txtResultado.Text = Convert.ToString(R);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtResultado.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
