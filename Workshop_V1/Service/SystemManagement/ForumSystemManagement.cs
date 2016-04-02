using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Query;

namespace Service.SystemManagement
{
    class ForumSystemManagement
    {
        ForumQuery forumQuery;
        UserQuery userQuery;
        public ForumSystemManagement(ForumQuery f,UserQuery u )
        {
            forumQuery = f;
            userQuery = u;
        }

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

        public bool notify(string userName, int commentId)
        {
            return true;
        }


        


    }
}
