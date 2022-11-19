using Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {
        LoginCommon login;
        List<LoginCommon> users;


        private string source = ConfigurationManager.ConnectionStrings["AccEntities"].ConnectionString;

        SqlConnection con;

       

        SqlCommand cmd;
        SqlDataReader dr;
        SqlTransaction VTran;

        public int GetMaximumID()
        {
            try
            {
                int VID = 0;
                con = new SqlConnection(source);
                con.Open();
                cmd = new SqlCommand("Select IsNull(Max(UserID),0) +1 From tbl_login", con);
                VID = (int)cmd.ExecuteScalar();

                return VID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SaveUser(LoginCommon u)
        {
            try
            {
                int VID = 0;
                con = new SqlConnection(source);
                con.Open();
                VTran = con.BeginTransaction();

                if (u.UserID == 0)
                {
                    cmd = new SqlCommand("Select IsNull(Max(UserID),0) +1 From tbl_login", con);
                    cmd.Transaction = VTran;
                    VID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                else
                {
                    VID = u.UserID;
                }

                

                


                cmd = new SqlCommand("if exists(select * from tbl_login where UserID=" + VID + ")Begin Update tbl_login set UserID=" + VID + ",UserName='" + u.UserName + "',Password='" + u.Password + "',IsAdmin=" + Convert.ToInt16(u.IsAdmin) + " where UserID=" + VID + " End Else Begin Insert into tbl_login(UserID,UserName,Password,IsAdmin) Values(" + VID + ",'" + u.UserName + "','" + u.Password + "'," + Convert.ToInt16(u.IsAdmin) + ")End", con);
               
                cmd.Transaction = VTran;
                cmd.ExecuteNonQuery();
                VTran.Commit();

                return true;
            }
            catch (Exception ex)
            {
                VTran.Rollback();
                throw ex;
            }
            finally
            { con.Close(); }
        }



        public LoginCommon VerifyUser(LoginCommon u)
        {
            try
            {
                string select = "Select * from tbl_login where  UserName='" + u.UserName + "' and Password='" + u.Password + "'";

                con = new SqlConnection(source);
                con.Open();
                cmd = new SqlCommand(select, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    login = new LoginCommon(Convert.ToInt32(dr["UserID"]), Convert.ToString(dr["UserName"]), Convert.ToString(dr["Password"]), Convert.ToBoolean(dr["IsAdmin"]));
                }

                return login;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<LoginCommon> GetUsers(int id)
        {
            if (users == null) users = new List<LoginCommon>();
            try
            {
                string where = "";
                if (id > 0)
                {
                    where = " Where UserID = " + id;
                }
                string select = "Select * from tbl_login " + where;

                con = new SqlConnection(source);
                con.Open();
                cmd = new SqlCommand(select, con);

                dr = cmd.ExecuteReader();


                //Add Users to Collection
                AddUsers(id);

                con.Close();
                return users;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }


        public void AddUsers(int userid)
        {
            try
            {
                LoginCommon newUser;


                while ((!dr.IsClosed) && dr.Read())
                {
                    newUser = new LoginCommon(Convert.ToInt32(dr["UserID"]), Convert.ToString(dr["UserName"]), Convert.ToString(dr["Password"]), Convert.ToBoolean(dr["IsAdmin"]));
                   // newUser.Signatures = dr["Signature"].ToString().Length == 0 ? new byte[0] : (byte[])(dr["Signature"]);

                    
                    users.Add(newUser);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex) { throw ex; }

            finally { dr.Close(); }

        }


        public bool DeleteUser(LoginCommon u)
        {

            try
            {

                con = new SqlConnection(source);
                con.Open();

                

                string delete = "Delete From tbl_login where UserID=" + u.UserID;
                cmd = new SqlCommand(delete, con);
               
                cmd.ExecuteNonQuery();

               

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
