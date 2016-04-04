using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UserP
{
    public class User
    {
        string memberName;
        string memberPassword;
        List<User> friendsList;

        List<Message> myMessages;

        public void addFriend(User f)
        {
            friendsList.Add(f);
        }

        public void addMessage(Message newMessage)
        {
            myMessages.Add(newMessage);
        }

        public string getUserName()
        {
            return memberName;
        }

        public void setPassword(string newPass)
        {
            memberPassword = newPass;
        }

        public string getPassword()
        {
            return memberPassword;
        }
    }
}
