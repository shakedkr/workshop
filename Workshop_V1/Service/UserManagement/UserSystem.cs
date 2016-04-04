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
        

        public bool updateUserRole(string userName, string role)
        {
            return true;
        }

        public bool setPassword(string userName, string oldPass, string newPass)
        {
            if (!GlobalsService.userQuery.doesFriendExist(userName) || !GlobalsService.userQuery.checkPassword(userName, oldPass))
             return false;
            GlobalsService.userQuery.changePassword(userName, newPass);
            return true;
        }

        public bool addFriend (string friend1 , string friend2){
            if (!GlobalsService.userQuery.doesFriendExist(friend1) || !GlobalsService.userQuery.doesFriendExist(friend2))
                return false;

            GlobalsService.userQuery.addFriend(friend1, friend2);
            return true;
        }

        public bool sendMessage(string username, string toUserName,
            string headline, string content)
        {
            if (!GlobalsService.userQuery.doesFriendExist(username) || !GlobalsService.userQuery.doesFriendExist(toUserName))
                return false;
            GlobalsService.userQuery.sendMessage(username, toUserName, headline, content);
            return true;
        }

        
    }
}
