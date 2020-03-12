using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TweetCool
{
    public class NewMessageModel : PageModel
    {
        public static Message Message { get; set; }
        public void OnGet()
        {
            List<Message> messages;
            if (AllMessageModel.Messages.ContainsKey(Message.Username))
            {
                messages = AllMessageModel.Messages[Message.Username];
            }

            else
            {
                messages = new List<Message>();
                AllMessageModel.Messages[Message.Username] = messages;
            }
            messages.Add(Message);
        }


    }
}