using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm1._15
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double base1, base2, height, perimetr;
            try
            {
                base1 = Convert.ToDouble(tbBase1.Text);
                base2 = Convert.ToDouble(tbBase2.Text);
                height = Convert.ToDouble(tbHeight.Text);

                if (base1 <= 0 || base2 <= 0 || height <= 0)
                {
                    MessageBox.Show("Значение меньше нуля, либо равено нулю", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    perimetr = Math.Sqrt(Math.Pow((Math.Max(base1,base2)-Math.Min(base1,base2))/2, 2) + Math.Pow(height, 2))*2+base1+base2;
                    lblEchoPerimetr.Text = Convert.ToString(perimetr);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
