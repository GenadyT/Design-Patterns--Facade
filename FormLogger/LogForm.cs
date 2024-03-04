using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace FormLogger
{
    public partial class LogForm : Form
    {
        private static StringBuilder log;
        public string Log
        {
            get { return log.ToString(); }
            private set { }
        }

        public LogForm()
        {
            InitializeComponent();
            InitializeTimer();
        }

        static LogForm()
        {
            log = new StringBuilder();
        }

        public static void Write(string? value)
        {
            log.Append(value);
        }

        public static void WriteLine(string? value)
        {
            log.AppendLine(value);
        }

        private void screenRefresh()
        {
            if (tbxLogSheet.Text == String.Empty)
            {
                tbxLogSheet.BackColor = Color.MistyRose;
            }
            else
            {
                tbxLogSheet.BackColor = Color.WhiteSmoke;
            }

        }

        private void InitializeTimer()
        {
            // Call this procedure when the application starts.  
            // Set to 1 second.  
            Timer1.Interval = 2500;
            Timer1.Tick += new EventHandler(Timer1_Tick);

            // Enable timer.  
            Timer1.Enabled = true;

            /*Button1.Text = "Stop";
            Button1.Click += new EventHandler(Button1_Click);*/
        }

        private void Timer1_Tick(object Sender, EventArgs e)
        {
            // Set the caption to the current time.  
            tbxLogSheet.Text = log.ToString();
            screenRefresh();
        }
    }
}
