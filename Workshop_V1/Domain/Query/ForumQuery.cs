using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ForumP;
using Domain.SystemP;
namespace Domain.Query
{
    public class ForumQuery
    {
        ForumSystem forumSystem;
        public ForumQuery(ForumSystem fs)
        {
            forumSystem = fs;
        }
        
        public bool doesForumExist (string forumName){
            string fName;
            List<Forum> forums = forumSystem.getForums();
            foreach (Forum f in forums){
                fName = f.getForumName();
                if (fName.Equals(forumName))
                    return true;
            }
            return false;
        }

        public bool doesSubForumExist(string forumName, string subForumName)
        {
            return true;
        }

        public bool doesSubForumExist(string subForumName)
        {
            return true;
        }


        public void addSubForumToForum (string forumName, string subForum){
            string fName;
            Forum ans=null;
            List<Forum> forums = forumSystem.getForums();
            foreach (Forum f in forums)
            {
                fName = f.getForumName();
                if (fName.Equals(forumName))
                    ans = f;
            }
            ans.addSubForumToForum(subForum);
        }

        /* TO-DO - complete */
        public void setGuide (string subForum, string guide){
            string fName;
            Forum tmp= null;
            SubForum ans = null;
            List<SubForum> subForums = null;
            List<Forum> forums = forumSystem.getForums();
            foreach (Forum f in forums)
            {
               subForums = f.getSubForum();
                         
            }
        }

        public int addThread(string forumName, string subForumName, string headline, string content)
        {

            return -1;
        }

        public void deleteSubForum(string forumName, string subForumName){
            
        }

        public string addComment(string forumname, string subforumname,
           int threadID, string userName, string headline, string content)
        {
            return "";
            
        }

    }
}
