using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
  public  class LoginCommon
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }


        public LoginCommon(int userid,string username,string  password,bool isadmin)
        {
            this.UserID = userid;
            this.UserName = username;
            this.Password = password;
            this.IsAdmin = isadmin;

        }
        public LoginCommon(string username, string password)
        {
           
            this.UserName = username;
            this.Password = password;
       

        }

       
    }
}
