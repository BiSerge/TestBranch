﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBranch
{
    public partial class fmTestBranch : Form
    {
        public fmTestBranch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frForm1 frmForm1 = new frForm1();
            frmForm1.Show();
        }
    }
}
