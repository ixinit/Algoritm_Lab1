using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm111
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void calc_Click(object sender, EventArgs e)
        {
            double a, b, c, d;
            try
            {
                a = Convert.ToDouble(first.Text);
                b = Convert.ToDouble(second.Text);

                c = (a + b) / 2;
                d = Math.Sqrt(a * b);

                lblEchoGeometry.Text = d.ToString();
                lblEchoArifm.Text = c.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message,"Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
