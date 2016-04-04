using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.SystemP
{
    public class ForumSystem
    {
        private List<ForumP.Forum> myForums;
        private List<UserP.User> myUser;
        private UserP.User superAdmin;


        public ForumSystem()
        {
            myForums = new List<ForumP.Forum>();
            myUser = new List<UserP.User>();
            superAdmin = new UserP.User();
        }

        public List<ForumP.Forum> getForums (){
            return myForums;
        }

        public List<UserP.User> getUsers()
        {
            return myUser;
        }

    }
}
