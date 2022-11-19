using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
   public class CitiesCommon
    {
        private int cityID;
        private string cityName;

        public static string Condition;
        //Constructors.
        public CitiesCommon()
        { }

        public CitiesCommon(int cityID, string cityName)
        {
            this.cityID = cityID;
            this.cityName = cityName;
        }

        //Properties.
        public int CityID
        {
            get { return cityID; }
            set { cityID = value; }
        }

        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }

        //Methods.

        public override string ToString()
        {
            return this.cityName.ToString();
        }
    }
}
