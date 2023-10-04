using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bank_Presentation_Layer_Web_App.Pages.Start
{
    public class CreateAccountModel : PageModel
    {
        public void OnGet()
        {
        }

        public void post_Sign_Up()
        {
            RedirectToPage("Login");
        }
    }
}
