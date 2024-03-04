using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger = FormLogger.Logger;
using CMI = ClassMethLogger.ClassMethInfo;

namespace Facade.TheaterEquip
{
    internal class CDPLayer
    {
        private const string ClassName = "CDPLayer";
        private TheaterPrint thPrint;

        public CDPLayer(TheaterPrint thPrint)
        {
            this.thPrint = thPrint;
        }
    }
}
