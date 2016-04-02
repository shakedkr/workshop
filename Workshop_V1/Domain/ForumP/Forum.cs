using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ForumP
{
    public class Forum
    {
        string forumName;
        private List<SubForum> mySubForum;

        public string getForumName()
        {
            return forumName;
        }

        public void addSubForumToForum(String subForum)
        {
            SubForum newSub = new SubForum(subForum);
            mySubForum.Add(newSub);
        }

        public List<SubForum> getSubForum()
        {
            return mySubForum;
        }
    
    }
}
