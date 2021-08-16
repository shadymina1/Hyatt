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
    public class BookingDoneModel : PageModel

    {

   
        [BindProperty(SupportsGet = true)]
        public Rooms rooms { set; get; }
        
        [BindProperty(SupportsGet = true)]
        public string tier { get; set; }
        [BindProperty(SupportsGet = true)]
        public string nights { get; set; }
        [BindProperty(SupportsGet = true)]
        public string total { get; set; }
        [BindProperty(SupportsGet = true)]
        public string perNight { get; set; }
        [BindProperty(SupportsGet = true)]
        public Client client { set; get; }
        public String password { get; set; }
        [BindProperty(SupportsGet = true)]
        public String firstName { get; set; }
        [BindProperty(SupportsGet = true)]
        public String lastName { get; set; }
        [BindProperty(SupportsGet = true)]
        public String email { get; set; }


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            //check
           
                SqlConnection conb = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LearnApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                String sql = "INSERT INTO [Hyatt].[dbo].[Client]([fname],[lname],[email],[pass])VALUES ('" + client.firstName + " ','"
                    + client.lastName
                    + " ','" + client.email
                    + " ','" + client.password
                    + " ' )";
                SqlCommand cmdb = new SqlCommand(sql, conb);
                conb.Open();
                cmdb.ExecuteNonQuery();
                conb.Close();
            
                return RedirectToPage("/Profile");

            }


        }
}
