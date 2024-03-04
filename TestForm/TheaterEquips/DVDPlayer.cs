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
    internal class DVDPlayer
    {
        private const string ClassName = "DVDPlayer";
        private TheaterPrint thPrint;
        public override string ToString()
        {
            return "I'm DVD player";
        }

        public DVDPlayer(TheaterPrint thPrint)
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

        public void play(string movie)
        {
            const string MethodName = "play";

            Dictionary<string, string> methParams = new Dictionary<string, string>();
            methParams.Add(MethodName, movie.ToString());

            string methInfo = CMI.MethInfo<string>(ClassName, MethodName, methParams);
            thPrint(ClassName, MethodName);
            Logger.WriteLine(methInfo);
        }

        public void stop()
        {
            const string MethodName = "stop";

            string methInfo = CMI.MethInfo(ClassName, MethodName);
            thPrint(ClassName, MethodName);
            Logger.WriteLine(methInfo);
        }

        public void eject()
        {
            const string MethodName = "eject";

            string methInfo = CMI.MethInfo(ClassName, MethodName);
            thPrint(ClassName, MethodName);
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
