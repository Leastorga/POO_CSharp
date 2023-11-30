using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resolucao.Devices
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }

        public string Scan(){
            return "Scanner scan result";
        }
    }
}