using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Basketball_Club
{
    public class User
    {
        private int user_id;
        private string username;
        private string password;
        private string fName;
        private string lName;
        private string gender;
        private string email;
        private string phone_no;
        private string address;
        private string picture;
        private bool role;
        private bool status;
    }
    public class Admin : User
    {
        private string admin_id;
    }
    public class Members : User
    {
        private string member_id;
    }

}