﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerGmap.Model;

namespace TallerGmap
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
            new Earth();
        }
    }
}
