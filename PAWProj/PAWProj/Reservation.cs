using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAWProj
{
    class Reservation
    {
        private string reservationDate;
        private string reservationTime;
        private int noPerson;

        Reservation() { }

        public Reservation(string reservationDate, string reservationTime, int noPerson)
        {
            this.reservationDate = reservationDate;
            this.reservationTime = reservationTime;
            this.noPerson = noPerson;
        }

        public string ReservationDate
        {
            get { return reservationDate; }
            set { reservationDate = value; }
        }

        public string ReservationTime
        {
            get { return reservationTime; }
            set { reservationTime = value; }
        }

        public int NoPerson
        {
            get { return noPerson; }
            set { noPerson = value; }
        }

        public override string ToString()
        {
            string toPrint = null;
            toPrint += "Reservation Dare: " + this.reservationDate + ", Reservation Time: " + this.reservationTime + ", Number of persons: " + this.noPerson;
            return toPrint;
        }
    }
}
