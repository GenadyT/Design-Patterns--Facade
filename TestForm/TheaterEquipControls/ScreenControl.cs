﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facade.TheaterEquipControls
{
    public partial class ScreenControl : EquipControl
    {
        public ScreenControl()
        {
            InitializeComponent();
            lblTitle.Text = "Screen";
        }
    }
}
