using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.ForumManagement;
using Service.SystemManagement;
using Service.UserManagement;


namespace AcceptanceTests
{
    class RealBridge : bridgeInterface
    {
        ForumManagement FM = new ForumManagement();
        ForumSystemManagement SM = new ForumSystemManagement();
        UserSystem UM = new UserSystem();

        bool registerSuperAdmin(string username, string password, string email)
        {
            return SM.registerSuperAdmin(username, password, email);
        }

        bool init(string username, string password) 
        {
            return SM.init(username,password);
        }

        bool createNewForum(string adminToBe, string forumName)
        {
            return SM.createNewForum(adminToBe, forumName);
        }

        bool registerUser(string username, string password, string email)
        {
            return SM.registerUser(username, password, email);
        }

        bool userSignIn(string username, string password)
        {
            return SM.userSignIn(username, password);
        }

        bool userSignOut(string username)
        {
            return SM.userSignOut(username);
        }

        bool notify(string username, string commentId)
        {
            return SM.notify(username, commentId);
        }
        bool deleteForum(string forumname)
        {
            return FM.deleteForum(forumname);
        }
        bool vanishUser(string userName)
        {
            return SM.deleteUser(userName);

        }
        bool viewMailNotification(string forum_name, string sub_forum_name, int threadid, string email)
        {
            return SM.viewMailNotification(forum_name, sub_forum_name, threadid, email);
        }

        bool validateEmail(string email)
        {
            return SM.validateEmail(email);
        }


        //user

        bool updateUserRole(string username, string role)
        {
            return UM.updateUserRole(username, role);
        }

        bool setPassword(string username, string oldPass, string newPass)
        {
            return UM.setPassword(username, oldPass, newPass);
        }

        bool addFriend(string username, string friendUserName)
        {
            return UM.addFriend(username, friendUserName);
        }

        bool sendMessage(string username, string toUserName, string headline, string content)
        {
            return UM.sendMessage(username, toUserName, headline, content);
        }

        //Forum
        int addThread(string forumName, string subForumName, string headline, string content, string username)
        //(returns the id of the new thread)
        {
            return FM.addThread(forumName, subForumName, headline, content, username);
        }


        bool addSubForum(string forumName, string guideToBe, string subForumName)
        {
            return FM.addSubForum(forumName, guideToBe, subForumName);
        }

        bool defineProperties(string forumName, string[] prop)
        {
            return FM.defineProperties(forumName, prop);
        }

        bool registerForumAdmin(string forumname, string username)
        {
            return FM.registerForumAdmin(forumname, username);
        }

        bool addForumGuide(string forumname, string subforumname, string guideToBe)
        {
            return FM.addForumGuide(forumname, subforumname, guideToBe);
        }

        string AddComment(string forumname, string subforumname, int threadID, string userName, string headline, string content)
        {
            return FM.addComment(forumname, subforumname, threadID, userName, headline, content);
        }

        bool deleteSubForum(string forumname, string subForumName)
        {
            return FM.deleteSubForum(forumname, subForumName);
        }

        string deleteComment(string forumname, string subforumname, double commentID)
        {
            return FM.deleteComment(forumname, subforumname, commentID);
        }





    }
}
