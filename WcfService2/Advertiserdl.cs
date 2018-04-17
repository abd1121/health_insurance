using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService2
{
    public class Advertiserdl
    {
        public static List<Advertiser> advertiserData = new List<Advertiser>();
        bool AddAdvertiser(Advertiser ad);
    }
}