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
    public partial class frForm1 : Form
    {
        public frForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frForm2 frmForm2 = new frForm2();
            frmForm2.Show();
        }
    }
}
