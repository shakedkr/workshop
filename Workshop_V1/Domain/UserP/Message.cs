using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UserP
{
    public class Message
    {
        string head;
        string content;
        string data;
        string sender;

        public Message(string _head, string _content, string _data, string _sender)
        {
            head = _head;
            content = _content;
            data = _data;
            sender = _sender;
        }
    }
}
