using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ForumManagement
{
    class ForumManagement
    {

        public bool defineProperties(String forumName, String[] prop) {
            return true;
        } 

        public bool addSubForum (String forumName, String guideToBe, String subForumName){
            return true;
        }

        /* return threadId */
       public int addThread(String forumName,String subForumName,String headline,String content){
           return 0;
       }

            
       public bool addForumGuide (String forumName, String subForumName , String guideName){
           return true;
       }

       public bool registerForumAdmin(string forumname, string username)
       {
           return true;
       }

       public bool deleteSubForum(string forumname, string subForumName)
       {
           return true;           
       }


        /* return comment id */
       public String addComment(string forumname, string subforumname, int threadID, string userName, string headline, string content)
       {
           return "";
       }

       



       


    }
}
