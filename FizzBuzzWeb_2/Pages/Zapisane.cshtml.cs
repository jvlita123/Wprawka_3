using FizzBuzzWeb_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FizzBuzzWeb_2
{
    public class Zapisane : PageModel
    {
        public Member Member { get; set; }
        public List<Member> members = new();

        public void OnGet()
        {
            var data = HttpContext.Session.GetString("data");
            if (data != null)
                members =
                JsonConvert.DeserializeObject<List<Member>>(data);

        }
    }
}
