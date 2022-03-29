using FizzBuzzWeb_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FizzBuzzWeb_2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }
        public List<FizzBuzz> lista { get; set; }
        public validation users = new();

        [BindProperty(SupportsGet = true)]

        public string Name { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
  
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var data = HttpContext.Session.GetString("data");
                if (data != null)
                    users.Users =
                    JsonConvert.DeserializeObject<List<FizzBuzz>>(data);

                users.Users.Add(FizzBuzz);

                HttpContext.Session.SetString("data",
                JsonConvert.SerializeObject(users.Users));
             

                return Page();
              //  return RedirectToPage("./SavedInSession");
            }
            return Page();
        }
    }
}
