﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplisantewelcome
{
    public partial class FORMULAIRE_SERVICE_HOSPITALISATION : Form
    {
        public FORMULAIRE_SERVICE_HOSPITALISATION()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            noo.ResetText();
            nama.ResetText();
        }
    }
}
