using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYF_BLOG.Utility
{
    
    public struct DEFAULT_ROLE 
    {
        //public const string ADMINISTRATOR = "administrator";
        public struct ADMINISTRATOR 
        {
            public const string ROLENAME = "administrator";
            public const string DESCRIPTIOIN = "Application user who has all right of execution";
        }
        public struct MEMBER
        {
            public const string ROLENAME = "member";
            public const string DESCRIPTIOIN = "Application registered user who is allowed to perform basic configuration";
        }
        public struct GUEST
        {
            public const string ROLENAME = "guest";
            public const string DESCRIPTIOIN = "Application not registered user who are not allowed to work on any functional configuration";
        }
        public struct MODERATOR
        {
            public const string ROLENAME = "moderator";
            public const string DESCRIPTIOIN = "Application user who has basiclly all permissions as administrator has except for core configuration";
        }
    }

}
