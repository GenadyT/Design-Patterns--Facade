using Facade.TheaterEquipControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;

namespace Facade
{
    public partial class TheaterForm : Form
    {
        private Test.FacadeClient _test;

        public TheaterForm()
        {
            InitializeComponent();

            btnTheaterOn.Enabled = true;
            btnTheaterOff.Enabled = false;

            _test = new Test.FacadeClient(SetEquipStatus, txbMovieName.Text);
        }

        public void SetEquipStatus(string equipNameChunk, string equipStatus)
        {
            EquipControl uc = (EquipControl)Controls.Find("eqc" + equipNameChunk + "Control", false).First();
            uc.SetState(equipStatus);
        }

        private void txbMovieName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTheaterOn_Click(object sender, EventArgs e)
        {
            ClearControls();
            _test.TheaterOn();
            btnTheaterOn.Enabled = false;
            btnTheaterOff.Enabled = true;            
        }

        private void btnTheaterOff_Click(object sender, EventArgs e)
        {
            ClearControls();
            _test.TheaterOff();
            btnTheaterOn.Enabled = true;
            btnTheaterOff.Enabled = false;            
        }

        private void ClearControls()
        {
            var formControls = this.Controls;

            /*foreach (var control in formControls)
            {
                if (control is EquipControl)
                {
                    EquipControl uc = (EquipControl)control;
                    uc.Clear();
                }
            }*/

            eqcAmplifierControl.Clear();
            eqcDvdPlayerControl.Clear();
            eqcPopcornPopperControl.Clear();
            eqcProjectorControl.Clear();
            eqcScreenControl.Clear();
            eqcTheaterLigthsControl.Clear();
            eqcCDPLayerControl.Clear();
            eqcTunerControl.Clear();
        }
    }
}
