using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonController
{
  public   class CitiesCommonControllor
    {
        public int GetMaximimID()
        {
            return new DAL.CitiesDAL().GetMaximumID();
        }
        public void SaveCity(SeatCommon c,bool isnew)
        {
            try
            {
                 new DAL.CitiesDAL().SaveCity(c, isnew);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<SeatCommon> GetSeat(int id)
        {
            return new DAL.CitiesDAL().GetSeat(id);
        }

        public void DeleteSeat(int id)
        {
             new DAL.CitiesDAL().DeleteSeat(id);
        }

        public void SaveReserve(Reserve r)
        {
            new DAL.CitiesDAL().SaveReserve(r);
        }

        public bool GetReservebyUser(int seatID,int userID,DateTime date)
        {
          return  new DAL.CitiesDAL().GetReservebyUser(seatID,userID, date);
        }

        public List<Reserve> GetReserve(int userid,int seatid,string date)
        {
            return new DAL.CitiesDAL().GetReserve(userid,seatid,date);
        }

        public void DeleteRSeat(int id, string sdate, int userid)
        {
            new DAL.CitiesDAL().DeleteRSeat(id,sdate,userid);
        }

        public void UpdateRSeat(int id, string sdate, int userid, string update)
        {
            new DAL.CitiesDAL().UpdateRSeat(id, sdate, userid, update);
        }
    }
}
