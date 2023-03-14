using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIU
{
    class Program
    {
        static void Main(string[] args)
        {
            var matchTime = new DateTime(2023, 09, 02, 21, 30, 0);
            Match myMatch = new Match("TeamA", "TeamB", matchTime);

            string homeTeam = myMatch.HomeTeam; 
            myMatch.AwayTeam = "TeamC"; 


        }
    }
}
