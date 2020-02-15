using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm1._14
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double rCylinder, hCylinder, surfArea;
            try
            {
                rCylinder = Convert.ToDouble(tbRCylinder.Text);
                hCylinder = Convert.ToDouble(tbHCylinder.Text);

                if (rCylinder <= 0 || hCylinder <= 0)
                {
                    MessageBox.Show("Значение меньше нуля, либо равенo нулю", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    surfArea = 2*Math.PI*rCylinder*hCylinder+2*Math.PI * Math.Pow(rCylinder, 2);
                    lblEchoSurfArea.Text = Convert.ToString(surfArea);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
