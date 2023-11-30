using System;

using Resolucao.Devices;

namespace Resolucao {
    class Program {
        static void Main(string[] args) {

            // A herança múltipla pode gerar o problema do diamante: um ambiguidade causada pela existência do mesmo método em mais de uma superclasse.
            // Para resolver isso, podemos implementar mais de uma interface
            Printer p = new Printer(){ SerialNumber = 1080};
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() {SerialNumber = 2003};
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() {SerialNumber = 3921};
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());

        }
    }
}