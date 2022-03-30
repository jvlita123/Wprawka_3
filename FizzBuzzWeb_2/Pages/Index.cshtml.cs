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
        public Member Member { get; set; }
        public List<Member> members = new();

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
                    members =
                    JsonConvert.DeserializeObject<List<Member>>(data);

                members.Add(Member);

                HttpContext.Session.SetString("data",
                JsonConvert.SerializeObject(members));
             
                return Page();
            }
            return Page();
        }
    }
}
