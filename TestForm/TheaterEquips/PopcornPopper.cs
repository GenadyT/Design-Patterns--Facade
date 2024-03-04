using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger = FormLogger.Logger;
using CMI = ClassMethLogger.ClassMethInfo;

namespace Facade.TheaterEquip
{
    internal class PopcornPopper
    {
        private const string ClassName = "PopcornPopper";
        private string frmStr = "class: {0}, method: {1}";
        private TheaterPrint thPrint;

        public PopcornPopper(TheaterPrint thPrint)
        {
            this.thPrint = thPrint;
        }

        public void on()
        {
            const string MethodName = "on";
            thPrint(ClassName, MethodName);
            Logger.WriteLine(CMI.MethInfo(ClassName, MethodName));
        }

        public void pop()
        {
            const string MethodName = "pop";
            thPrint(ClassName, MethodName);
            Logger.WriteLine(CMI.MethInfo(ClassName, MethodName));
        }

        public void off()
        {
            const string MethodName = "off";
            thPrint(ClassName, MethodName);
            Logger.WriteLine(CMI.MethInfo(ClassName, MethodName));
        }
    }
}
