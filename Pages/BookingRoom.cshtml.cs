using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using final_hotel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace final_hotel.Pages
{
    public class BookingRoomModel : PageModel
    {

        [BindProperty]
        public Rooms rooms { set; get; }

        public Client client { set; get; }

        [BindProperty(SupportsGet = true)]

        public int duration { set; get; }
        [BindProperty(SupportsGet = true)]

        public string tier { get; set; }
        [BindProperty(SupportsGet = true)]

        public string nights { get; set; }
        [BindProperty(SupportsGet = true)]

        public string total { get; set; }
        [BindProperty(SupportsGet = true)]

        public string perNight { get; set; }


        public int totalNightsA => duration * 1000;
        public int totalNightsB => duration * 200;
        public int totalNightsC => duration * 120;

        public void OnGet()
        {
        }
    }
}
