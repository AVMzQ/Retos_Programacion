using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetosProgramacion
{
    public partial class FizzBuzz : Form
    {
        bool custom = false;
        public FizzBuzz()
        {
            InitializeComponent();
        }

        private void FizzBuzz_SizeChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flpFizBuz.Controls.Count > 0)
            {
                flpFizBuz.AutoSize = true;
                flpFizBuz.Controls.Clear();
                FizzBuzz_Class fz = new FizzBuzz_Class(flpFizBuz);
                fz.FizzBuzz();
            }
            else
            {
                flpFizBuz.AutoSize = true;
                FizzBuzz_Class fz = new FizzBuzz_Class(flpFizBuz);
                fz.FizzBuzz();
            }
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            if (!custom)
            {
                btnCustom.BackColor = Color.LightBlue;
                btnStart.Enabled = false;

                label2.Visible = true;
                numeric.Visible = true;
                btnStart2.Visible = true;
                custom = true;
            }
            else
            {
                btnCustom.BackColor = Color.White;
                btnStart.Enabled = true;

                label2.Visible = false;
                numeric.Visible = false;
                btnStart2.Visible = false;
                custom = false;
            }
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            if (flpFizBuz.Controls.Count > 0)
            {
                flpFizBuz.Controls.Clear();
                flpFizBuz.AutoSize = true;
                FizzBuzz_Class fz = new FizzBuzz_Class(flpFizBuz);
                fz.FizzBuzzCustom(Convert.ToInt32(numeric.Value));
            }
            else
            {
                flpFizBuz.AutoSize = true;
                FizzBuzz_Class fz = new FizzBuzz_Class(flpFizBuz);
                fz.FizzBuzzCustom(Convert.ToInt32(numeric.Value));
            }
        }
    }
}
