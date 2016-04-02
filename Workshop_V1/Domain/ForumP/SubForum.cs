using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ForumP
{
    public class SubForum
    {
        string subForumName;
        private List<Thread> subForumThread;

        public SubForum(string name)
        {
            subForumName = name;
        }


        public string getSubForumName()
        {
            return subForumName;
        }

    }
}
