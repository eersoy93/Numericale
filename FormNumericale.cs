using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numericale
{
    public partial class FormNumericale : Form
    {
        public FormNumericale()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x08000000; // WS_DISABLED
                return cp;
            }
        }

        private void ButtonKeyAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Numericale 0.1\n" +
                            "Copyright (c) 2022 Erdem Ersoy (eersoy93)\n" +
                            "Licensed with GPLv3.\n" +
                            "See LICENSE file for license text.",
                            "About Numericale",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void ButtonKey1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("1");
        }

        private void ButtonKey2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("2");
        }

        private void ButtonKey3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("3");
        }

        private void ButtonKey4_Click(object sender, EventArgs e)
        {
            SendKeys.Send("4");
        }

        private void ButtonKey5_Click(object sender, EventArgs e)
        {
            SendKeys.Send("5");
        }

        private void ButtonKey6_Click(object sender, EventArgs e)
        {
            SendKeys.Send("6");
        }

        private void ButtonKey7_Click(object sender, EventArgs e)
        {
            SendKeys.Send("7");
        }

        private void ButtonKey8_Click(object sender, EventArgs e)
        {
            SendKeys.Send("8");
        }

        private void ButtonKey9_Click(object sender, EventArgs e)
        {
            SendKeys.Send("9");
        }

        private void ButtonKey0_Click(object sender, EventArgs e)
        {
            SendKeys.Send("0");
        }

        private void ButtonKeyEnter_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }
    }
}
