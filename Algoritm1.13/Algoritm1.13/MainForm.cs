using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm1._13
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double x1Dot, x2Dot, y1Dot, y2Dot, distance;
            try
            {
                x1Dot = Convert.ToDouble(tbX1Dot.Text);
                y1Dot = Convert.ToDouble(tbY1Dot.Text);
                x2Dot = Convert.ToDouble(tbX2Dot.Text);
                y2Dot = Convert.ToDouble(tbY2Dot.Text);

                distance = Math.Sqrt(Math.Pow(x2Dot-x1Dot,2) + Math.Pow(y2Dot-y1Dot,2));
                lblEchoDistance.Text = distance.ToString();

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
