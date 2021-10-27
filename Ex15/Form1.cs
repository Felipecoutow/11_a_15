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

namespace Template_Vs
{
    public partial class Form1 : Form
    {
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
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double N1, N2, R;

            N1 = Convert.ToDouble(txtN1.Text);
            N2 = Convert.ToDouble(txtN2.Text);

            if (N1 > N2)
            {
                R = N1 - N2;
            }
            else
            {
                R = N2 - N1;
            }

            txtResultado.Text = "A diferença é " + R;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtN2.Clear();
            txtN1.Clear();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
