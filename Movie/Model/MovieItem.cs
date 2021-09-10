using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Model
{
    public class MovieItem
    {   
        public long Id { get; set; }
        public string Date { get; set; }

        public string Time { get; set; }
        public string Venue { get; set; }
        public long Ticket { get; set; }
        public string Currency { get; set; }
        public long Amount { get; set; }
        public bool IsComplete { get; set; }
    }
}
