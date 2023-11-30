using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resolucao.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document){
            Console.WriteLine("ComboDevice print " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Combodevice processing " + document);
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}