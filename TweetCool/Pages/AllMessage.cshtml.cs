using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TweetCool
{
    public class AllMessageModel : PageModel
    {
        public static Dictionary<string, List<Message>> Messages { get; set; } = new Dictionary<string, List<Message>>();
        public void OnGet()
        {

        }
    }
}