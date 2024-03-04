using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger = FormLogger.Logger;
using CMI = ClassMethLogger.ClassMethInfo;

namespace Facade.TheaterEquip
{
    internal class Tuner
    {
        private const string ClassName = "Tuner";
        private TheaterPrint thPrint;

        public Tuner(TheaterPrint thPrint)
        {
            this.thPrint = thPrint;
        }
    }
}
