using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Program;


namespace PIU
{
    class Program
    {
        static void Main(string[] args)
        {
            var timpMeci = new DateTime(2023, 09, 02, 21, 30, 0);
            Meci meciNou = new Meci("TeamA", "TeamB", timpMeci);

            string echipaAcasa = meciNou.EchipaAcasa; 
            meciNou.EchipaDeplasare = "TeamC";
            Console.ReadLine();


        }
    }
}
