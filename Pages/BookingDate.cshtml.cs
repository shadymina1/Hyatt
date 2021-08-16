using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using final_hotel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace final_hotel.Pages
{
    public class BookingDateModel : PageModel
    {
        [BindProperty]
        public Booking booking { get; set; }
        public Rooms rooms { set; get; }

        public int duration => Int16.Parse((booking.chkout - booking.chkin).TotalDays.ToString());


       // public string sss => booking.chkin.ToString("MM/dd/yyy");

        public IActionResult OnPost()
        {
            return RedirectToPage("/BookingRoom", new { duration });


           /*
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LearnApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "SELECT * FROM [Hyatt].[dbo].[Booking] INNER JOIN [Hyatt].[dbo].[Rooms] ON [Hyatt].[dbo].[Rooms].[BId]   WHERE RId NOT EXISTS (SELECT RId FROM [Hyatt].[dbo].[Booking] WHERE( chkin >'"
                + booking.chkin +"'AND chkout< '"
                + booking.chkin+"') OR (chkout> '"
                + booking.chkin+"'AND chkout<'" 
                + booking.chkout+"') OR( chkin< '"
                + booking.chkin +"' AND chkout> '" 
                + booking.chkout +"') )";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return RedirectToPage("/Index");
            }
            else
            {
                return RedirectToPage("/About");
            }

            */





              
        }
    }
}
