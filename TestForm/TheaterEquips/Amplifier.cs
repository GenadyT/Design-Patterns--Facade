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
    internal class Amplifier
    {
        private const string ClassName = "Amplifier";
        private TheaterPrint thPrint;

        public Amplifier(TheaterPrint thPrint)
        {
            this.thPrint = thPrint;  
        }

        public void on()
        {
            const string MethodName = "on";

            thPrint(ClassName, MethodName);
            string methInfo = CMI.MethInfo(ClassName, MethodName);            
            Logger.WriteLine(methInfo);
        }

        public void setDvd(DVDPlayer player)
        {
            const string MethodName = "setDvd";

            Dictionary<string, string> methParams = new Dictionary<string, string>();
            methParams.Add(MethodName, player.ToString());

            thPrint(ClassName, "setDvd");
            string methInfo = CMI.MethInfo<string>(ClassName, MethodName, methParams);
            thPrint(ClassName, "'set Dvd'");
            Logger.WriteLine(methInfo);
        }

        public void setSurroundSound()
        {
            const string MethodName = "setSurroundSound";

            thPrint(ClassName, "'set Surround Sound'");
            string methInfo = CMI.MethInfo(ClassName, MethodName);
            Logger.WriteLine(methInfo);
        }

        public void setVolume(int value)
        {
            const string MethodName = "'set Volume'";

            Dictionary<string, string> methParams = new Dictionary<string, string>();
            methParams.Add(MethodName, value.ToString());

            thPrint(ClassName, MethodName);
            string methInfo = CMI.MethInfo<string>(ClassName, MethodName, methParams);
            Logger.WriteLine(methInfo);
        }

        public void off()
        {
            const string MethodName = "off";

            thPrint(ClassName, MethodName);
            string methInfo = CMI.MethInfo(ClassName, MethodName);
            Logger.WriteLine(methInfo);
        }
    }
}
