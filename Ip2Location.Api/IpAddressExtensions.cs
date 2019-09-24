using System;
using System.Net;

namespace Ip2Location.Api
{
    public static class IpAddressExtensions
    {
        public static uint ParseIpAddress(this string ipAddress)
        {
            var address = IPAddress.Parse(ipAddress);
            var bytes = address.GetAddressBytes();

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return BitConverter.ToUInt32(bytes, 0);
        }
    }
}