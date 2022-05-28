using System;
using System.Net.NetworkInformation;

namespace ServerMQTT_sensors
{
    internal class CompParam
    {
        public string WIFIMAC;
        public string ETHERNETMAC;
        public string IP;

        public static string ShowNetworkInterfaces()
        {
           // Dane dane = new Dane();
          
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            Console.WriteLine("Interface information for {0}.{1}     ",
                    computerProperties.HostName, computerProperties.DomainName);
            if (nics == null || nics.Length < 1)
            {
                Console.WriteLine("  No network interfaces found.");
                return null;
            }
            
            Console.WriteLine("  Number of interfaces .................... : {0}", nics.Length);
            foreach (NetworkInterface adapter in nics)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties(); //  .GetIPInterfaceProperties();
                Console.WriteLine();
                Console.WriteLine(adapter.Description);
                Console.WriteLine(String.Empty.PadLeft(adapter.Description.Length, '='));
                Console.WriteLine("  Interface type .......................... : {0}", adapter.NetworkInterfaceType);
                Console.Write("  Physical address ........................ : ");
                PhysicalAddress address = adapter.GetPhysicalAddress();
                if (adapter.Name.ToString() == "Wi-Fi")
                {
                    return String.Format("{0}", address);
                }
               
            }
           return null;
        }

    }
    }

