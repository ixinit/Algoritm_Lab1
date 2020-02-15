using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm1._17
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double side1, side2, angle, area;
            try
            {
                side1 = Convert.ToDouble(tbSide1.Text);
                side2 = Convert.ToDouble(tbSide2.Text);
                angle = Convert.ToDouble(tbAngle.Text);

                if (side1 <= 0 || side2 <= 0 || angle <= 0)
                {
                    MessageBox.Show("Значение меньше нуля, либо равено нулю", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    area = 0.5*side1*side2*Math.Sin(angle*Math.PI/180);
                    lblEchoArea.Text = Convert.ToString(area);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
