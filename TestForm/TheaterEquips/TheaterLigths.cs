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
    internal class TheaterLigths
    {
        private const string ClassName = "TheaterLigths";
        private TheaterPrint thPrint;

        public TheaterLigths(TheaterPrint thPrint)
        {
            this.thPrint = thPrint;
        }
        public void dim(int value)
        {
            const string MethodName = "dim";

            Dictionary<string, string> methParams = new Dictionary<string, string>();
            methParams.Add(MethodName, value.ToString());

            string methInfo = CMI.MethInfo<string>(ClassName, MethodName, methParams);
            thPrint(ClassName, MethodName);
            Logger.WriteLine(methInfo);
        }

        public void on()
        {
            const string MethodName = "on";
            thPrint(ClassName, MethodName);
            Logger.WriteLine(CMI.MethInfo(ClassName, MethodName));
        }
    }
}
