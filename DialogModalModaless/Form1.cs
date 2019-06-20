using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DialogModalModaless
{
    public partial class Form1 : Form
    {
        FormModal Modal;
        FormModaless Modaless;

        public Form1()
        {
            InitializeComponent();
            Modal = new FormModal();
            Modaless = new FormModaless();
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {            
            Modal.ShowDialog();
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Modaless.Show();
            Modaless.Focus();
        }

        private void 모달창열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modal.ShowDialog();
        }

        private void 모달리스ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Modaless != null) {
            }
            else
            {

            }
            Modaless.Show();
            Modaless.Focus();
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
