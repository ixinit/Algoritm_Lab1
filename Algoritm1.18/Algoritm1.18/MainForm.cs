using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm1._18
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double x1, x2, x3, y1, y2, y3, perimetr, area;
            try
            {
                x1 = Convert.ToDouble(tbX1.Text);
                x2 = Convert.ToDouble(tbX2.Text);
                x3 = Convert.ToDouble(tbX3.Text);
                y1 = Convert.ToDouble(tbY1.Text);
                y2 = Convert.ToDouble(tbY2.Text);
                y3 = Convert.ToDouble(tbY3.Text);

                area = 0.5 * Math.Abs((x1 - x3) * (y2 - y3) - (x2 - x3) * (y1 - y3));
                perimetr = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)) + Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)) + Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
                lblEchoPerimetr.Text = Convert.ToString(perimetr);
                lblEchoArea.Text = Convert.ToString(area);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
