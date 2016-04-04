using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ForumP;
using Domain.SystemP;
using Domain.UserP;
namespace Domain.Query
{
    public class UserQuery
    {

        public bool doesFriendExist(string friendName)
        {
            List<User> users=  GlobalsDomain.forumSystem.getUsers();
            foreach (User u in users)
            {
                if (u.getUserName().Equals(friendName))
                    return true;
            }

            return false;
        }

        public void changePassword(string friendName, string newPass)
        {
            User tmp=null;
            List<User> users = GlobalsDomain.forumSystem.getUsers();
            foreach (User u in users)
            {
                if (u.getUserName().Equals(friendName))
                    tmp = u;
            }
            if (tmp != null)
                tmp.setPassword(newPass);
            
        }

        public bool checkPassword(string userName, string pass)
        {
            User tmp = null;
            List<User> users = GlobalsDomain.forumSystem.getUsers();
            foreach (User u in users)
            {
                if (u.getUserName().Equals(userName))
                    tmp = u;
            }

            if (tmp.getPassword().Equals(pass))
                return true;

            return false;
           
        }

        public void addFriend(string f1, string f2)
        {
            User u1 = findUserByName(f1);
            User u2 = findUserByName(f2);
            u1.addFriend(u2);
            u2.addFriend(u1);
            
        }

        public User findUserByName(string u)
        {

            List<User> users = GlobalsDomain.forumSystem.getUsers();
            foreach (User someUser in users)
            {
                if (someUser.getUserName().Equals(u))
                    return someUser;
            }
            return null;
        }

        public void sendMessage(string username, string toUserName,
            string headline, string content)
        {
            Message newMessage = new Message(headline, content, "", toUserName);
            User u = findUserByName(toUserName);
           u.addMessage(newMessage);
        }

    }
}
