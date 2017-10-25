using System;
using System.Collections.Generic;
using System.Text;

namespace Ripisha.Mobile.Constants
{
    public  static class AirtelMoney
    {
        //this is where we hold all contant operations options 
        //of airtel money with the respective key

        //This is the code airtel money use to access to Airtel money on your mobile
        public const int AIRTEL_USSD_CODE = 501;
        public const int USD_ACCOUNT = 1;
        public const int CDF_ACCOUNT = 2;

        //very important for online payment
        public const int SEND_LOCAL = 3;
        public const int SEND_INTERNATIONAL = 4;

        //other useful options
        public const int MONEY_IN = 200;
        public const int MONEY_OUT = 201;



    }
}
