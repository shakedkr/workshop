using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptanceTests
{
    interface bridgeInterface
    {
        bool registerSuperAdmin(string username, string password, string email);
        bool init(string username, string password);
        bool createNewForum(string adminToBe, string forumName);
        bool registerUser(string username, string password, string email);
        bool userSignIn(string username, string password);
        bool userSignOut(string username);
        bool notify(string username, double commentId);
        bool deleteForum(string forumname);
        bool vanishUser(string userName);
        bool viewMailNotification(string forum_name, string sub_forum_name, int threadid, string email);
        bool validateEmail(string email);

        //User
        bool updateUserRole(string username, string role);
        bool setPassword(string username, string oldPass, string newPass);
        bool addFriend(string username, string friendUserName);
        bool sendMessage(string username, string toUserName, string headline, string content);

        //Forum
        int addThread(string forumName, string subForumName, string headline, string content,string username); //(returns the id of the new thread)
        bool addSubForum(string forumName, string guideToBe, string subForumName);
        bool defineProperties(string forumName, string[] prop);
        bool registerForumAdmin(string forumname, string username);
        bool addForumGuide(string forumname, string subforumname, string guideToBe);
        string AddComment(string forumname, string subforumname, int threadID, string userName, string headline, string content);
        bool deleteSubForum(string forumname, string subForumName);
        string deleteComment(string forumname, string subforumname, double commentID);

        
 
        }
}
