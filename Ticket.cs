using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIU
{
     class Ticket
    {
        private int _seatNumber;
        private decimal _price;
        private bool _isSold;

        public Ticket(int seatNumber, decimal price)
        {
            _seatNumber = seatNumber;
            _price = price;
            _isSold = false;
        }
    }

}
