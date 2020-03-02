using System;

namespace rules
{
    public class Context
    {
        public bool isPhysicalProduct { get; set; }
        public bool isBook { get; set; }
        public bool isVideo { get; set; }
        public string videoTitle { get; set; }
        public bool isActivateMembership { get; set; }
        public bool isUpgradeMembership { get; set; }
    }
}
