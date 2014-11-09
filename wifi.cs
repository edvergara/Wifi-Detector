using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NativeWiFiApi
{
    public class wifi
    {
        isaNativeWiFiApi wifiAPI;
        public wifi()
        {
            wifiAPI = new isaNativeWiFiApi();
        }

        public void EnumerateNICs()
        {
            wifiAPI.EnumerateNICs();
        }
    }
}
