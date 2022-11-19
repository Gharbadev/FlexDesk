using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonController
{
   public class LoginCommonControllor
    {
        public int GetMaximumID()
        {
            return new DAL.LoginDAL().GetMaximumID();
        }
        public bool SaveUser(LoginCommon u)
        {
            return new DAL.LoginDAL().SaveUser(u);
        }
            public LoginCommon VerifyUser(LoginCommon u)
        {
            return new DAL.LoginDAL().VerifyUser(u);
        }

        public List<LoginCommon> GetUsers(int id)
        {
            return new DAL.LoginDAL().GetUsers(id);
        }
        public bool DeleteUser(LoginCommon u)
        {
            try
            {
                return new DAL.LoginDAL().DeleteUser(u);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
