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
    public class ContactModel : PageModel
    {
        [BindProperty]
        public Contact contact { get; set; }

        [BindProperty(SupportsGet = true)]
        public String message { get; set; }


        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LearnApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string sql = "INSERT INTO [Hyatt].[dbo].[Contact]([firstName],[lastName],[email],[subject],[message])VALUES ('" + contact.firstName + " ','"
                    + contact.lastName
                    + " ','" + contact.email
                    + " ','" + contact.subject
                    + " ','" + contact.message + " ' )";

                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                message = "Thank you for contacting us!";
                return RedirectToPage("/Contact", new { message });

            }
        }
    }
}
