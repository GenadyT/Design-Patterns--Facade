using System;
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
    public partial class CDPLayerControl : EquipControl
    {
        public CDPLayerControl()
        {
            InitializeComponent();
            lblTitle.Text = "CDP Layer";
        }
    }
}
