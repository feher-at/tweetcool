using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TweetCool
{
    public class Message
    {
        public DateTime PostTime { get; set; }
        public string Text { get; set; }
        public string Username { get; set; }

        public Message(string username, string text)
        {
            Username = username;
            Text = text;
            PostTime = DateTime.Now;
        }
    }
}
