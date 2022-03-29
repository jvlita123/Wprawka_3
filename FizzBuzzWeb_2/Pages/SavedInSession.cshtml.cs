using FizzBuzzWeb_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FizzBuzzWeb_2
{
    public class SavedInSessionModel : PageModel
    {
        public FizzBuzz FizzBuzz { get; set; }
        public validation users = new();

        public void OnGet()
        {
            var data = HttpContext.Session.GetString("data");
            if (data != null)
                users.Users =
                JsonConvert.DeserializeObject<List<FizzBuzz>>(data);

        }
    }
}
