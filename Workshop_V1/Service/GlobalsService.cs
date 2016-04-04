using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Query;

namespace Service
{
    class GlobalsService
    {
        public static ForumQuery forumQuery = new ForumQuery();
        public static UserQuery userQuery = new UserQuery();

    }
}
