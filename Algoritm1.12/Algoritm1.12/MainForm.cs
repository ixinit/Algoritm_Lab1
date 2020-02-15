using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm1._12
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double catet1, catet2, gipotenuza;
            try 
            {
                catet1 = Convert.ToDouble(tbCatet1.Text);
                catet2 = Convert.ToDouble(tbCatet2.Text);

                if (catet1 <= 0 || catet2 <= 0)
                {
                    MessageBox.Show("Катет меньше нуля, либо равен нулю", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    gipotenuza = Math.Sqrt(Math.Pow(catet1, 2) + Math.Pow(catet2, 2));
                    lblEchoGipotenuza.Text = Convert.ToString(gipotenuza);
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
