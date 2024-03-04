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
    public partial class EquipControl : UserControl
    {
        private string _state;
        
        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public string State
        {
            get { return txbState.Text; }
            /*set
            {
                SetState(value);
                SetStateText();
                SetStateColor();
            }*/
        }

        public EquipControl()
        {
            InitializeComponent();
            _state = string.Empty;
        }

        public virtual void SetState(string input)
        {
            //if ((input == "on")||(input == "off"))
            //{
            //    _state = String.Empty;
            //    return;
            //}

            _state += String.Format(",{0} ", input);
            txbState.Text = _state;
        }

        protected virtual void SetStateText()
        {
            txbState.Text = _state;
        }

        protected virtual void SetStateColor()
        {
            txbState.BackColor = Color.White;
        }

        public void Clear()
        {
            _state = string.Empty;
            txbState.Text = String.Empty;
        }
    }
}
