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
    internal class Screen
    {
        private const string ClassName = "Screen";
        private TheaterPrint thPrint;

        public Screen(TheaterPrint thPrint)
        {
            this.thPrint = thPrint;
        }
        public void down()
        {
            const string MethodName = "down";

            string methInfo = CMI.MethInfo(ClassName, MethodName);
            thPrint(ClassName, MethodName);
            Logger.WriteLine(methInfo);
        }

        public void up()
        {
            const string MethodName = "up";
            thPrint(ClassName, MethodName);
            Logger.WriteLine(CMI.MethInfo(ClassName, MethodName));
        }
    }
}
