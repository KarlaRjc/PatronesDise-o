using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8._2_MetodoFabricacion
{
    public class DeviceFactory
    {

        
        
            public static IDevice CreateDevice(Device d)
            {
                switch (d)
                {
                    case Device.AM: return new AmMeter();
                    case Device.VOLT: return new VolMeter();
                    case Device.OHM: return new OhmMeter();
                    default: return new AmMeter();
                }
            
        }



    }

    public enum Device
    {
        AM,
        VOLT,
        OHM
    }
}
