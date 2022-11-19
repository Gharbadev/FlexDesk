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
  public   class CitiesDAL
    {
        List<CitiesCommon> cities = new List<CitiesCommon>();
        List<SeatCommon> li;
        List<Reserve> lir;
        private string source = ConfigurationManager.ConnectionStrings["AccEntities"].ConnectionString;


        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlTransaction VTran;


        public int GetMaximumID()
        {
            int VID = 0;
            con = new SqlConnection(source);
            con.Open();
            cmd = new SqlCommand("Select IsNull(Max(SeatID),0) +1 From tbl_Seat", con);
            VID = (int)cmd.ExecuteScalar();

            return VID;

        }

        public void DeleteSeat(int id)
        {
            try
            {
                string delete = "Delete From tbl_Seat where SeatID=" + id;
                con = new SqlConnection(source);
                con.Open();

                cmd = new SqlCommand(delete, con);

                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            { con.Close(); }
        }

        public void DeleteRSeat(int id, string sdate, int userid)
        {
            try
            {
                string delete = "Delete From Reservation where SeatID=" + id+" and date='"+sdate+"' and userid="+userid+"";
                con = new SqlConnection(source);
                con.Open();

                cmd = new SqlCommand(delete, con);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            { con.Close(); }
        }

        public void UpdateRSeat(int id, string sdate, int userid, string update)
        {
            try
            {
                string delete = "Update Reservation set date='"+update+"' where SeatID=" + id + " and date='" + sdate + "' and userid=" + userid + "";
                con = new SqlConnection(source);
                con.Open();

                cmd = new SqlCommand(delete, con);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            { con.Close(); }
        }

        public List<Reserve> GetReserve(int userid,int seatid,string date)
        {
            if (lir == null) lir = new List<Reserve>();
            try
            {

                string select = "";

                if (seatid>0 && date!="")
                {
                   // select = "Select ''as UserName,''as SeatNo,''as SeatName,Date,SeatID from Reservation where UserID=" + userid + " and date='"+date+"' and seatid="+seatid+"";
                    select = "Select ''as UserName,ts.SeatNo,ts.SeatName,r.Date,r.SeatID from Reservation r  inner join tbl_Seat ts on r.SeatID=ts.SeatID  where r.date='"+date+"' ";

                }
                else
                {
                    select = "Select TL.UserName,ts.SeatNo,ts.SeatName,r.Date,r.SeatID from Reservation r  inner join tbl_Seat ts on r.SeatID=ts.SeatID inner join tbl_login tl on r.UserID=tl.UserID where tl.UserID=" + userid + "";

                }

                con = new SqlConnection(source);
                con.Open();
                cmd = new SqlCommand(select, con);

                dr = cmd.ExecuteReader();

                Reserve newUser;


                while ((!dr.IsClosed) && dr.Read())
                {
                    newUser = new Reserve();
                    newUser.Username = Convert.ToString(dr["UserName"]);
                    newUser.SeatNo = Convert.ToString(dr["SeatNo"]);
                    newUser.SeatName = Convert.ToString(dr["SeatName"]);
                    newUser.Date = Convert.ToDateTime(dr["Date"]);
                    newUser.SeatID = Convert.ToInt32(dr["SeatID"]);


                    lir.Add(newUser);
                }
                dr.Close();
                con.Close();



                con.Close();
                return lir;
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

        public bool GetReservebyUser(int seatID, int userID, DateTime date)
        {
            try
            {
               
                string select = "Select * from Reservation where   date='"+ date + "'";
                con = new SqlConnection(source);
                con.Open();
                cmd = new SqlCommand(select, con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    return true;
                    dr.Close();
                }
                else
                {
                    return false;
                    dr.Close();
                }
              
                
                
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

        public void SaveReserve(Reserve r)
        {
            try
            {
                int VID = 0;
                con = new SqlConnection(source);
                con.Open();
                VTran = con.BeginTransaction();
                //if (c.SeatID == 0)
                //{
                //    cmd = new SqlCommand("Select IsNull(Max(SeatID),0) +1 From tbl_Seat", con);
                //    cmd.Transaction = VTran;
                //    VID = Convert.ToInt32(cmd.ExecuteScalar());
                //}
                //else
                //{
                //    VID = c.SeatID;
                //}
                string insert = "Insert into Reservation (SeatID,UserID,Date) values (" + r.SeatID+","+r.UserID+",'"+r.Date+"') ";
                cmd = new SqlCommand(insert, con);
                cmd.Transaction = VTran;
                cmd.ExecuteNonQuery();
                VTran.Commit();
            }
            catch (Exception ex)
            {
                VTran.Rollback();
                throw ex;
            }
            finally
            { con.Close(); }
        }

        public List<SeatCommon> GetSeat(int id)
        {
            if (li == null) li = new List<SeatCommon>();
            try
            {
                string where = "";
                if (id > 0)
                {
                    where = " Where SeatID = " + id;
                }
                string select = "Select * from tbl_Seat " + where;

                con = new SqlConnection(source);
                con.Open();
                cmd = new SqlCommand(select, con);

                dr = cmd.ExecuteReader();

                SeatCommon newUser;


                while ((!dr.IsClosed) && dr.Read())
                {
                    newUser = new SeatCommon();
                    newUser.SeatID = Convert.ToInt32(dr["SeatID"]);
                    newUser.SeatNo = Convert.ToString(dr["SeatNo"]);
                    newUser.SeatName = Convert.ToString(dr["SeatName"]);


                    li.Add(newUser);
                }
                dr.Close();
                con.Close();



                con.Close();
                return li;
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

        public void SaveCity(SeatCommon c,bool isnew)
        {
            try
            {
                int VID = 0;
                con = new SqlConnection(source);
                con.Open();
                VTran = con.BeginTransaction();
                if (c.SeatID == 0)
                {
                    cmd = new SqlCommand("Select IsNull(Max(SeatID),0) +1 From tbl_Seat", con);
                    cmd.Transaction = VTran;
                    VID = Convert.ToInt32(cmd.ExecuteScalar());
                }
                else
                {
                    VID = c.SeatID;
                }
                string insert = "if exists(select * from tbl_Seat where SeatID=" + VID + ")Begin Update tbl_Seat set SeatID=" + VID + ",SeatNo='" + c.SeatNo + "',SeatName='"+c.SeatName+"' where SeatID=" + VID + " End Else Begin Insert into tbl_Seat(SeatID,SeatNo,SeatName) Values(" + VID + ",\'" + c.SeatNo + "\',\'"+c.SeatName+"\' )End";
                cmd = new SqlCommand(insert, con);
                cmd.Transaction = VTran;
                cmd.ExecuteNonQuery();
                VTran.Commit();
            }
            catch (Exception ex)
            {
                VTran.Rollback();
                throw ex;
            }
            finally
            { con.Close(); }
        }
    }
}
