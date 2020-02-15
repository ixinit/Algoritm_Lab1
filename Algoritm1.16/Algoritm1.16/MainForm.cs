using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm1._16
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double sideA, sideB, sideC, area, helfPerimetr;
            try
            {
                sideA = Convert.ToDouble(tbSideA.Text);
                sideB = Convert.ToDouble(tbSideB.Text);
                sideC = Convert.ToDouble(tbSideC.Text);

                if (sideA <= 0 || sideB <= 0 || sideC <=0)
                {
                    MessageBox.Show("Катет меньше нуля, либо равен нулю", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (sideA+sideB <= sideC || sideB + sideC <= sideA || sideC + sideA <= sideB)
                {
                    MessageBox.Show("Нет такого треугольника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    helfPerimetr = (sideA + sideB + sideC)/2;
                    area = Math.Sqrt(helfPerimetr*(helfPerimetr-sideA)*(helfPerimetr - sideB) *(helfPerimetr - sideC));
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
