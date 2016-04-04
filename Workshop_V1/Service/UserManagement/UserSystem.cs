using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Query;
namespace Service.UserManagement
{
    public class UserSystem
    {
        UserQuery userQuery;
        
        public UserSystem(UserQuery uq){
            userQuery = uq;
        }

        public bool updateUserRole(string userName, string role)
        {
            return true;
        }

        public bool setPassword(string userName, string oldPass, string newPass)
        {
            if (!userQuery.doesFriendExist(userName) || !userQuery.checkPassword(userName, oldPass))
             return false;
            userQuery.changePassword(userName, newPass);
            return true;
        }

        public bool addFriend (string friend1 , string friend2){
            if (!userQuery.doesFriendExist(friend1) || !userQuery.doesFriendExist(friend2))
                return false;

            userQuery.addFriend(friend1, friend2);
            return true;
        }

        public bool sendMessage(string username, string toUserName,
            string headline, string content)
        {
            if (!userQuery.doesFriendExist(username) || !userQuery.doesFriendExist(toUserName))
                return false;
            userQuery.sendMessage(username, toUserName, headline, content);
            return true;
        }

        
    }
}
