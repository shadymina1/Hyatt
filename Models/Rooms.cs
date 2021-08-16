using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final_hotel.Models
{
    public class Rooms
    {
        public string type { get; set; }

        public decimal price { get; set; }

        public string tier { get; set; }
        public string nights { get; set; }
        public string total { get; set; }
        public string perNight { get; set; }
    }
}
