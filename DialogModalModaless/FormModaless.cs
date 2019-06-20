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

    public partial class FormModaless : Form
    {
        private double o = 0.0;
        public string SetTitle
        {
            set { this.Text = value; }
        }
        public FormModaless()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (o < 100)
            {
                o = o + 3.6;
                float c = Convert.ToSingle(o);
                float f = c / 100;
                this.Opacity = f;
            }
            else
            {
                this.Opacity = Convert.ToSingle(100 / 100);
                o = 0.0;
                this.Timer.Enabled = false;
            }
        }

        private void FormModaless_Load(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }
    }
}
