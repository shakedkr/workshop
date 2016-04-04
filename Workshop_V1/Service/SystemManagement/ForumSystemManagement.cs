using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Query;

namespace Service.SystemManagement
{
    public class ForumSystemManagement
    {
        
        public bool registerSuperAdmin(string userName, string password, string email)
        {
            return true;
        }

        public bool init(string userName, string password)
        {
            return true;
        }

        public bool createNewForum(string adminToBe, string forumName)
        {
            return true;
        }

        public bool registerUser(string username, string password, string email)
        {
            return true;
        }

        public bool userSignIn(string userName, string password)
        {
            return true;
        }

        public bool userSignOut(string userName)
        {
            return true;
        }

        public bool notify(string userName, string commentId)
        {
            return true;
        }

        public bool deleteUser(string userName)
        {
            return true;
        }

        public bool viewMailNotification(string forum_name, string sub_forum_name, int threadid, string email) 
        {
            return true;
        }

        public bool validateEmail(string email)
        {
            return true;
        }


        


    }
}
