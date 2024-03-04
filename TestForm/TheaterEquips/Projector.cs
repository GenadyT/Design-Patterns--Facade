using FormLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger = FormLogger.Logger;
using CMI = ClassMethLogger.ClassMethInfo;

namespace Facade.TheaterEquip
{
    internal class Projector
    {
        private const string ClassName = "Projector";
        private TheaterPrint thPrint;

        public Projector(TheaterPrint thPrint)
        {
            this.thPrint = thPrint;
        }
        public void on()
        {
            const string MethodName = "on";

            string methInfo = CMI.MethInfo(ClassName, MethodName);
            thPrint(ClassName, MethodName);
            Logger.WriteLine(methInfo);
        }

        public void wideScreenMode()
        {
            const string MethodName = "wideScreenMode";

            string methInfo = CMI.MethInfo(ClassName, MethodName);
            thPrint(ClassName, "'wide Screen Mode'");
            Logger.WriteLine(methInfo);
        }

        public void off()
        {
            const string MethodName = "off";

            string methInfo = CMI.MethInfo(ClassName, MethodName);
            thPrint(ClassName, MethodName);
            Logger.WriteLine(methInfo);
        }
    }
}
