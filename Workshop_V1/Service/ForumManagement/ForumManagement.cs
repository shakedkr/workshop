using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Query;



namespace Service.ForumManagement
{  
    public class ForumManagement
    {
        
        /*
         * ForumQuery forumQuery;

        public ForumManagement(ForumQuery f)
        {
            forumQuery = f;
        }*/


        public bool defineProperties(string forumName, string[] prop) {
            return true;
        } 

        public bool addSubForum (string forumName, string guide, string subForumName){
            if (!GlobalsService.forumQuery.doesForumExist(forumName))
               return false;
            GlobalsService.forumQuery.addSubForumToForum(forumName, subForumName);
            GlobalsService.forumQuery.setGuide(subForumName, guide);
            return true;
        }

        /* return threadId */
       public int addThread(string forumName,string subForumName,string headline,string content){
           if (!GlobalsService.forumQuery.doesSubForumExist(forumName, subForumName))
               return -1;
           return GlobalsService.forumQuery.addThread(forumName, subForumName, headline, content);   
           
        }

            
       public bool addForumGuide (string forumName, string subForumName , string guideName){
                    
           return true;
       }

       public bool registerForumAdmin(string forumname, string username)
       {
           return true;
       }

       public bool deleteSubForum(string forumName, string subForumName)
       {
           if (!GlobalsService.forumQuery.doesSubForumExist(forumName, subForumName))
            return false;
           GlobalsService.forumQuery.deleteSubForum(forumName, subForumName);
           return true;
       }


        /* return comment id */
       public string addComment(string forumname, string subforumname, 
           int threadID, string userName, string headline, string content)
       {
           if (!GlobalsService.forumQuery.doesSubForumExist(forumname, subforumname))
               return "";
           return GlobalsService.forumQuery.addComment(forumname, subforumname, threadID,
               userName, headline, content);
                  
           

       }

       



       


    }
}
