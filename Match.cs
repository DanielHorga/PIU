using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIU
{
    class Match
    {
        private string _homeTeam;
        private string _awayTeam;
        private DateTime _date;
        public string HomeTeam { get => _homeTeam; set => _homeTeam = value; }
        public string AwayTeam { get => _awayTeam; set => _awayTeam = value; }

        public Match(string homeTeam, string awayTeam, DateTime date)
        {
            _homeTeam = homeTeam;
            _awayTeam = awayTeam;
            _date = date;
        }
    }
}
