using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    public class Message
    {
        public string Topic { get; set; }
        public string Email { get; set; }
        public string PNumber { get; set; }
        public string MessageText { get; set; }

        public Message()
        {
            Topic = "";
            Email = "";
            PNumber = " ";
            MessageText = "";
        }
        public Message(string topic, string email, string pNumber, string message)
        {
            Topic = topic;
            Email = email;
            PNumber = pNumber;
            MessageText = message;
        }
    }
}
