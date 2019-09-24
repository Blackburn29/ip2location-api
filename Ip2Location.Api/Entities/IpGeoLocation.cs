using System;
using System.Collections.Generic;

namespace Ip2Location.Api.Entities
{
    public partial class IpGeoLocation
    {
        public int Id { get; set; }
        public double IpFrom { get; set; }
        public double IpTo { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string ZipCode { get; set; }
        public string TimeZone { get; set; }
        public string IspName { get; set; }
        public string DomainName { get; set; }
    }
}
