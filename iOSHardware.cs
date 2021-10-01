using Foundation;

namespace Xamarin.iOS
{
    [Preserve(AllMembers = true)]
    class iOSHardware
    {
        private readonly iOSChipTypeMap _chipTypeMap;

        public iOSHardware()
        {
            _chipTypeMap = new iOSChipTypeMap();
        }

        public iOSChipType GetChipType(string hardware) => _chipTypeMap.GetChipType(hardware);

        public string GetModel(string hardware)
        {
            if (hardware.StartsWith("iPhone"))
            {
                switch (hardware)
                {
                    case "iPhone14,2":
                        return "iPhone 13 Pro";
                    case "iPhone14,3":
                        return "iPhone 13 Pro Max";
                    case "iPhone14,4":
                        return "iPhone 13 mini";
                    case "iPhone14,5":
                        return "iPhone 13";
                    case "iPhone13,1":
                        return "iPhone 12 mini";
                    case "iPhone13,2":
                        return "iPhone 12";
                    case "iPhone13,3":
                        return "iPhone 12 Pro";
                    case "iPhone13,4":
                        return "iPhone 12 Pro Max";
                    case "iPhone12,8":
                        return "iPhone SE (2nd generation)";
                    case "iPhone12,5":
                        return "iPhone 11 Pro Max";
                    case "iPhone12,3":
                        return "iPhone 11 Pro";
                    case "iPhone12,1":
                        return "iPhone 11";
                    case "iPhone11,2":
                        return "iPhone XS";
                    case "iPhone11,4":
                    case "iPhone11,6":
                        return "iPhone XS Max";
                    case "iPhone11,8":
                        return "iPhone XR";
                    case "iPhone10,3":
                    case "iPhone10,6":
                        return "iPhone X";
                    case "iPhone10,2":
                    case "iPhone10,5":
                        return "iPhone 8 Plus";
                    case "iPhone10,1":
                    case "iPhone10,4":
                        return "iPhone 8";
                    case "iPhone9,2":
                    case "iPhone9,4":
                        return "iPhone 7 Plus";
                    case "iPhone9,1":
                    case "iPhone9,3":
                        return "iPhone 7";
                    case "iPhone8,4":
                        return "iPhone SE";
                    case "iPhone8,2":
                        return "iPhone 6S Plus";
                    case "iPhone8,1":
                        return "iPhone 6S";
                    case "iPhone7,1":
                        return "iPhone 6 Plus";
                    case "iPhone7,2":
                        return "iPhone 6";
                    case "iPhone6,2":
                        return "iPhone 5S Global";
                    case "iPhone6,1":
                        return "iPhone 5S GSM";
                    case "iPhone5,4":
                        return "iPhone 5C Global";
                    case "iPhone5,3":
                        return "iPhone 5C GSM";
                    case "iPhone5,2":
                        return "iPhone 5 Global";
                    case "iPhone5,1":
                        return "iPhone 5 GSM";
                    case "iPhone4,1":
                        return "iPhone 4S";
                    case "iPhone3,3":
                        return "iPhone 4 CDMA";
                    case "iPhone3,1":
                    case "iPhone3,2":
                        return "iPhone 4 GSM";
                    case "iPhone2,1":
                        return "iPhone 3GS";
                    case "iPhone1,2":
                        return "iPhone 3G";
                    case "iPhone1,1":
                        return "iPhone";       
                }
            }

            if (hardware.StartsWith("iPod"))
            {
                switch (hardware)
                {
                    case "iPod9,1":
                        return "iPod touch 7G";
                    case "iPod7,1":
                        return "iPod touch 6G";
                    case "iPod5,1":
                        return "iPod touch 5G";
                    case "iPod4,1":
                        return "iPod touch 4G";
                    case "iPod3,1":
                        return "iPod touch 3G";
                    case "iPod2,1":
                        return "iPod touch 2G";
                    case "iPod1,1":
                        return "iPod touch";
                }
            }

            if (hardware.StartsWith("iPad"))
            {
                switch (hardware)
                {
                    case "iPad14,2":
                        return "iPad mini (6th generation) Wi-FI + Cellular";
                    case "iPad14,1":
                        return "iPad mini (6th generation) Wi-FI";
                    case "iPad13,11":
                        return "iPad Pro (12.9-inch) (5th generation) Wi-Fi + Cellular";
                    case "iPad13,10":
                        return "iPad Pro (12.9-inch) (5th generation) Wi-Fi + Cellular";
                    case "iPad13,9":
                        return "iPad Pro (12.9-inch) (5th generation) Wi-Fi";
                    case "iPad13,8":
                        return "iPad Pro (12.9-inch) (5th generation) Wi-Fi";
                    case "iPad13,7":
                        return "iPad Pro (11-inch) (3rd generation) Wi-Fi + Cellular";
                    case "iPad13,6":
                        return "iPad Pro (11-inch) (3rd generation) Wi-Fi + Cellular";
                    case "iPad13,5":
                        return "iPad Pro (11-inch) (3rd generation) Wi-Fi";
                    case "iPad13,4":
                        return "iPad Pro (11-inch) (3rd generation) Wi-Fi";
                    case "iPad13,2":
                        return "iPad Air (4th generation) Wi-Fi + Cellular";
                    case "iPad13,1":
                        return "iPad Air (4th generation) Wi-Fi";
                    case "iPad12,2":
                        return "iPad (9th Generation) Wi-Fi + Cellular";
                    case "iPad12,1":
                        return "iPad (9th generation) Wi-Fi";
                    case "iPad11,7":
                        return "iPad (8th Generation) Wi-Fi + Cellular";
                    case "iPad11,6":
                        return "iPad (8th Generation) Wi-Fi";
                    case "iPad11,4":
                        return "iPad Air (3rd generation) Wi-Fi + Cellular";
                    case "iPad11,3":
                        return "iPad Air (3rd generation) Wi-Fi";
                    case "iPad11,2":
                        return "iPad mini (5th generation) Wi-Fi + Cellular";
                    case "iPad11,1":
                        return "iPad mini (5th generation) Wi-Fi";
                    case "iPad8,12":
                        return "iPad Pro (12.9-inch) (4th generation) Wi-Fi + Cellular";
                    case "iPad8,11":
                        return "iPad Pro (12.9-inch) (4th generation) Wi-Fi";
                    case "iPad8,10":
                        return "iPad Pro (11-inch) (2nd generation) Wi-Fi + Cellular";
                    case "iPad8,9":
                        return "iPad Pro (11-inch) (2nd generation) Wi-Fi";
                    case "iPad8,8":
                        return "iPad Pro 12.9-inch (3rd Generation)";
                    case "iPad8,7":
                        return "iPad Pro 12.9-inch (3rd generation) Wi-Fi + Cellular";
                    case "iPad8,6":
                        return "iPad Pro 12.9-inch (3rd Generation)";
                    case "iPad8,5":
                        return "iPad Pro 12.9-inch (3rd Generation)";
                    case "iPad8,4":
                        return "iPad Pro 11-inch";
                    case "iPad8,3":
                        return "iPad Pro 11-inch Wi-Fi + Cellular";
                    case "iPad8,2":
                        return "iPad Pro 11-inch";
                    case "iPad8,1":
                        return "iPad Pro 11-inch Wi-Fi";
                    case "iPad7,12":
                        return "iPad (7th generation) Wi-Fi + Cellular";
                    case "iPad7,11":
                        return "iPad (7th generation) Wi-Fi";
                    case "iPad7,6":
                        return "iPad (6th generation) Wi-Fi + Cellular";
                    case "iPad7,5":
                        return "iPad (6th generation) Wi-Fi";
                    case "iPad7,4":
                        return "iPad Pro (10.5-inch) Wi-Fi + Cellular";
                    case "iPad7,3":
                        return "iPad Pro (10.5-inch) Wi-Fi";
                    case "iPad7,2":
                        return "iPad Pro 12.9-inch (2nd generation) Wi-Fi + Cellular";
                    case "iPad7,1":
                        return "iPad Pro 12.9-inch (2nd generation) Wi-Fi";
                    case "iPad6,12":
                        return "iPad (5th generation) Wi-Fi + Cellular";
                    case "iPad6,11":
                        return "iPad (5th generation) Wi-Fi";
                    case "iPad6,8":
                        return "iPad Pro 12.9-inch Wi-Fi + Cellular";
                    case "iPad6,7":
                        return "iPad Pro 12.9-inch Wi-Fi";
                    case "iPad6,4":
                        return "iPad Pro (9.7-inch) Wi-Fi + Cellular";
                    case "iPad6,3":
                        return "iPad Pro (9.7-inch) Wi-Fi";
                    case "iPad5,4":
                        return "iPad Air 2 Wi-Fi + Cellular";
                    case "iPad5,3":
                        return "iPad Air 2 Wi-Fi";
                    case "iPad5,2":
                        return "iPad mini 4 Wi-Fi + Cellular";
                    case "iPad5,1":
                        return "iPad mini 4 Wi-Fi";
                    case "iPad4,9":
                        return "iPad mini 3 Wi-Fi + Cellular (TD-LTE)";
                    case "iPad4,8":
                        return "iPad mini 3 Wi-Fi + Cellular";
                    case "iPad4,7":
                        return "iPad mini 3 Wi-Fi";
                    case "iPad4,6":
                        return "iPad mini 2 Wi-Fi + Cellular (TD-LTE)";
                    case "iPad4,5":
                        return "iPad mini 2 Wi-Fi + Cellular";
                    case "iPad4,4":
                        return "iPad mini 2 Wi-Fi";
                    case "iPad4,3":
                        return "iPad Air Wi-Fi + Cellular (TD-LTE)";
                    case "iPad4,2":
                        return "iPad Air Wi-Fi + Cellular";
                    case "iPad4,1":
                        return "iPad Air Wi-Fi";
                    case "iPad3,6":
                        return "iPad (4th generation) Wi-Fi + Cellular (MM)";
                    case "iPad3,5":
                        return "iPad (4th generation) Wi-Fi + Cellular";
                    case "iPad3,4":
                        return "iPad (4th generation) Wi-Fi";
                    case "iPad3,3":
                        return "iPad 3 Wi-Fi + Cellular (CDMA)";
                    case "iPad3,2":
                        return "iPad 3 Wi-Fi + Cellular (GSM)";
                    case "iPad3,1":
                        return "iPad 3 Wi-Fi";
                    case "iPad2,7":
                        return "iPad mini Wi-Fi + Cellular (MM)";
                    case "iPad2,6":
                        return "iPad mini Wi-Fi + Cellular";
                    case "iPad2,5":
                        return "iPad mini Wi-Fi";
                    case "iPad2,4":
                        return "iPad 2 Wi-Fi";
                    case "iPad2,3":
                        return "iPad 2 CDMA";
                    case "iPad2,2":
                        return "iPad 2 GSM";
                    case "iPad2,1":
                        return "iPad 2 Wi-Fi";
                    case "iPad1,1":
                        return "iPad";
                }
            }

            if (hardware == "i386" || hardware == "x86_64")
                return "Simulator";

            if (hardware == "mac")
                return "Mac";

            return (hardware == "" ? "Unknown" : hardware);
        }
    }
}
