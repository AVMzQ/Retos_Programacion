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
    public partial class LENGUAJE_HACKER : Form
    {
        public LENGUAJE_HACKER()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                LenguajeHacker lh = new LenguajeHacker(textBox1.Text, flpContenedor);
                lh.Hackeado();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
        }
    }
}
