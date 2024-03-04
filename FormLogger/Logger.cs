using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLogger
{
    public delegate void TimerDelegate();

    public class Logger
    {
        public Logger() { }

        public static void Write(string? value)
        {
            LogForm.Write(value);
        }

        public static void WriteLine(string? value)
        {
            LogForm.WriteLine(value);
        }
    }
}
