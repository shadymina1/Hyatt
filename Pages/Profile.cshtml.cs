using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace final_hotel.Pages
{
    public class ProfileModel : PageModel
    {
        public string fName { set; get; }
        public string lName { set; get; }

        public string email { set; get; }
        public string price { set; get; }

        public string duration { set; get; }

        public string total { set; get; }

        public IActionResult OnGet()
        {
            /*
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LearnApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "SELECT * FROM [Hyatt].[dbo].[bookings]";
               
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
               
                fName = string.Format("{0}", reader[1]);
                lName = string.Format("{0}", reader[2]);
                email = string.Format("{0}", reader[3]);
                price = string.Format("{0}", reader[4]);
                duration = string.Format("{0}", reader[5]);
                total = string.Format("{0}", reader[6]);
                return RedirectToPage("/Profile", new { fName, lName, email, price, duration,total });
            }
            else
            {
                return Page();
            }
            */

            return Page();
        }
    }
}
