class iOSHardware
{
	public String GetModel(String hardware)
    {
        if (hardware.StartsWith("iPhone"))
        {
            if (hardware == "iPhone1,1")
                return "iPhone 2G";
            if (hardware == "iPhone1,2")
                return "iPhone 3G";
            if (hardware == "iPhone2,1")
                return "iPhone 3GS";
            if (hardware == "iPhone3,1")
                return "iPhone 4 GSM";
            if (hardware == "iPhone3,2")
                return "iPhone 4";
            if (hardware == "iPhone3,3")
                return "iPhone 4 CDMA";
            if (hardware == "iPhone4,1")
                return "iPhone 4S";
            if (hardware == "iPhone5,1")
                return "iPhone 5 GSM";
            if (hardware == "iPhone5,2")
                return "iPhone 5 Global";
            if (hardware == "iPhone5,3")
                return "iPhone 5C GSM";
            if (hardware == "iPhone5,4")
                return "iPhone 5C Global";
            if (hardware == "iPhone6,1")
                return "iPhone 5S GSM";
            if (hardware == "iPhone6,2")
                return "iPhone 5S Global";
            if (hardware == "iPhone7,2")
                return "iPhone 6";
            if (hardware == "iPhone7,1")
                return "iPhone 6 Plus";
        }

        if (hardware.StartsWith("iPod"))
        {
            if (hardware == "iPod1,1")
                return "iPod Touch 1G";
            if (hardware == "iPod2,1")
                return "iPod Touch 2G";
            if (hardware == "iPod3,1")
                return "iPod Touch 3G";
            if (hardware == "iPod4,1")
                return "iPod Touch 4G";
            if (hardware == "iPod5,1")
                return "iPod Touch 5G";
        }

        if (hardware.StartsWith("iPad"))
        {
            // iPad
            if (hardware == "iPad1,1")
                return "iPad";

            // iPad 2
            if (hardware == "iPad2,1")
                return "iPad 2 WiFi";
            if (hardware == "iPad2,2")
                return "iPad 2 GSM";
            if (hardware == "iPad2,3")
                return "iPad 2 CDMA";
            if (hardware == "iPad2,4")
                return "iPad 2 Wifi";

            // iPad 3
            if (hardware == "iPad3,1")
                return "iPad 3 WiFi";
            if (hardware == "iPad3,2")
                return "iPad 3 CDMA";
            if (hardware == "iPad3,3")
                return "iPad 3 GSM";

            // iPad 4
            if (hardware == "iPad3,4")
                return "iPad 4 Wifi";
            if (hardware == "iPad3,5")
                return "iPad 4 GSM";
            if (hardware == "iPad3,6")
                return "iPad 4 CDMA";

            // iPad Air
            if (hardware == "iPad4,1")
                return "iPad Air Wifi";
            if (hardware == "iPad4,2")
                return "iPad Air Cellular";

            // iPad Mini
            if (hardware == "iPad2,5")
                return "iPad Mini Wifi";
            if (hardware == "iPad2,6")
                return "iPad Mini GSM";
            if (hardware == "iPad2,7")
                return "iPad Mini CDMA";

            // iPad Mini 2nd Gen model
            if (hardware == "iPad4,4")
                return "iPad Mini Retina Wifi";
            if (hardware == "iPad4,5")
                return "iPad Mini Retina Cellular";
        }

        if (hardware == "i386" || hardware == "x86_64")
            return "Simulator";
            
        return (hardware == "" ? "Unknown": hardware);        
    }
}
