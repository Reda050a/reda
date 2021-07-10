using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : Form
    {
        string op = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void quitterLeProgrammeCtrlxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void versionStandardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculatrice c1 = new Calculatrice();
            c1.Show();
        }
    }
}
