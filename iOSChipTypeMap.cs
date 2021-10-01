using System.Collections.Generic;
using Foundation;

namespace Xamarin.iOS
{
    [Preserve(AllMembers = true)]
    internal class iOSChipTypeMap : Dictionary<string, iOSChipType>
    {
        private readonly Dictionary<string, iOSChipType> modelChipMap;

        public iOSChipTypeMap()
        {
            modelChipMap = new Dictionary<string, iOSChipType>
            {
                { "iPhone1,1", iOSChipType.A4 }, // iPhone
                { "iPhone1,2", iOSChipType.A4 }, // iPhone 3G
                { "iPhone2,1", iOSChipType.A4 }, // iPhone 3GS
                { "iPhone3,1", iOSChipType.A4 }, // iPhone 4 GSM
                { "iPhone3,2", iOSChipType.A4 }, // iPhone 4 GSM
                { "iPhone3,3", iOSChipType.A4 }, // iPhone 4 CDMA
                { "iPhone4,1", iOSChipType.A5 }, // iPhone 4S
                { "iPhone5,1", iOSChipType.A6 }, // iPhone 5 GSM
                { "iPhone5,2", iOSChipType.A6 }, // iPhone 5 Global
                { "iPhone5,3", iOSChipType.A6 }, // iPhone 5C GSM
                { "iPhone5,4", iOSChipType.A6 }, // iPhone 5C Global,
                { "iPhone6,1", iOSChipType.A7 }, // iPhone 5S GSM
                { "iPhone6,2", iOSChipType.A7 }, // iPhone 5S Global
                { "iPhone7,1", iOSChipType.A8 }, // iPhone 6 Plus
                { "iPhone7,2", iOSChipType.A8 }, // iPhone 6
                { "iPhone8,1", iOSChipType.A9 }, // iPhone 6S,
                { "iPhone8,2", iOSChipType.A9 }, // iPhone 6S Plus,
                { "iPhone8,4", iOSChipType.A9 }, // iPhone SE,
				{ "iPhone12,8", iOSChipType.A13Bionic }, // iPhone SE (2nd),
                { "iPhone9,1", iOSChipType.A10Fusion }, // iPhone 7
                { "iPhone9,2", iOSChipType.A10Fusion }, // iPhone 7 Plus
                { "iPhone9,3", iOSChipType.A10Fusion }, // iPhone 7
                { "iPhone9,4", iOSChipType.A10Fusion }, // iPhone 7 Plus
                { "iPhone10,1", iOSChipType.A11Bionic }, // iPhone 8
                { "iPhone10,2", iOSChipType.A11Bionic }, // iPhone 8 Plus
                { "iPhone10,3", iOSChipType.A11Bionic }, // iPhone X
                { "iPhone10,4", iOSChipType.A11Bionic }, // iPhone 8
                { "iPhone10,5", iOSChipType.A11Bionic }, // iPhone 8 Plus
                { "iPhone10,6", iOSChipType.A11Bionic }, // iPhone X
                { "iPhone11,2", iOSChipType.A12Bionic }, // iPhone XS
                { "iPhone11,4", iOSChipType.A12Bionic }, // iPhone XS Max
                { "iPhone11,6", iOSChipType.A12Bionic }, // iPhone XS Max
                { "iPhone11,8", iOSChipType.A12Bionic }, // iPhone XR
                { "iPhone12,1", iOSChipType.A13Bionic }, // iPhone 11
                { "iPhone12,3", iOSChipType.A13Bionic }, // iPhone 11 Pro
                { "iPhone12,5", iOSChipType.A13Bionic }, // iPhone 11 Pro Max
                { "iPhone13,1", iOSChipType.A14Bionic }, // iPhone 12 mini
                { "iPhone13,2", iOSChipType.A14Bionic }, // iPhone 12
                { "iPhone13,3", iOSChipType.A14Bionic }, // iPhone 12 Pro
                { "iPhone13,4", iOSChipType.A14Bionic }, // iPhone 12 Pro Max
                { "iPhone14,2", iOSChipType.A15Bionic }, // iPhone 13 Pro
                { "iPhone14,3", iOSChipType.A15Bionic }, // iPhone 13 Pro Max
                { "iPhone14,4", iOSChipType.A15Bionic }, // iPhone 13 mini
                { "iPhone14,5", iOSChipType.A15Bionic }, // iPhone 13
                { "iPad1,1", iOSChipType.A4 }, // iPad
                { "iPad2,1", iOSChipType.A5 }, // iPad 2 Wi-Fi
                { "iPad2,2", iOSChipType.A5 }, // iPad 2 GSM
                { "iPad2,3", iOSChipType.A5 }, // iPad 2 CDMA
                { "iPad2,4", iOSChipType.A5 }, // iPad 2 Wi-Fi
                { "iPad2,5", iOSChipType.A5 }, // iPad mini Wi-Fi
                { "iPad2,6", iOSChipType.A5 }, // iPad mini Wi-Fi + Cellular
                { "iPad2,7", iOSChipType.A5 }, // iPad mini Wi-Fi + Cellular (MM)
                { "iPad3,1", iOSChipType.A5 }, // iPad 3 Wi-Fi
                { "iPad3,2", iOSChipType.A5 }, // iPad 3 Wi-Fi + Cellular (VZ)
                { "iPad3,3", iOSChipType.A5X }, // iPad 3 Wi-Fi + Cellular
                { "iPad3,4", iOSChipType.A6X }, // iPad 4 Wi-Fi
                { "iPad3,5", iOSChipType.A6X }, // iPad 4 Wi-Fi + Cellular
                { "iPad3,6", iOSChipType.A6X }, // iPad 4 Wi-Fi + Cellular (MM)
                { "iPad4,1", iOSChipType.A7 }, // iPad Air Wi-Fi
                { "iPad4,2", iOSChipType.A7 }, // iPad Air Wi-Fi + Cellular
                { "iPad4,3", iOSChipType.A7 }, // iPad Air Wi-Fi + Cellular (TD-LTE)
                { "iPad4,4", iOSChipType.A7 }, // iPad mini 2 Wi-Fi
                { "iPad4,5", iOSChipType.A7 }, // iPad mini 2 Wi-Fi + Cellular
                { "iPad4,6", iOSChipType.A7 }, // iPad mini 2 Wi-Fi + Cellular (TD-LTE)
                { "iPad4,7", iOSChipType.A7 }, // iPad mini 3 Wi-Fi
                { "iPad4,8", iOSChipType.A7 }, // iPad mini 3 Wi-Fi + Cellular
                { "iPad4,9", iOSChipType.A7 }, // iPad mini 3 Wi-Fi + Cellular (TD-LTE)
                { "iPad5,1", iOSChipType.A8 }, // iPad mini 4 Wi-Fi
                { "iPad5,2", iOSChipType.A8 }, // iPad mini 4 Wi-Fi + Cellular
                { "iPad5,3", iOSChipType.A8X }, // iPad Air 2 Wi-Fi
                { "iPad5,4", iOSChipType.A8X }, // iPad Air 2 Wi-Fi + Cellular
                { "iPad6,3", iOSChipType.A9X }, // iPad Pro 9.7" Wi-Fi
                { "iPad6,4", iOSChipType.A9X }, // iPad Pro 9.7" Wi-Fi + Cellular
                { "iPad6,7", iOSChipType.A9X }, // iPad Pro 12.9" Wi-Fi
                { "iPad6,8", iOSChipType.A9X }, // iPad Pro 12.9" Wi-Fi + Cellular
                { "iPad6,11", iOSChipType.A9 }, // iPad 5th gen Wi-Fi
                { "iPad6,12", iOSChipType.A9 }, // iPad 5th gen Wi-Fi + Cellular
                { "iPad7,1", iOSChipType.A10XFusion }, // iPad Pro 12.9" 2nd gen Wi-Fi
                { "iPad7,2", iOSChipType.A10XFusion }, // iPad Pro 12.9" 2nd gen Wi-Fi + Cellular
                { "iPad7,3", iOSChipType.A10XFusion }, // iPad Pro 10.5" Wi-Fi
                { "iPad7,4", iOSChipType.A10XFusion }, // iPad Pro 10.5" Wi-Fi + Cellular
                { "iPad7,5", iOSChipType.A10Fusion }, // iPad 9.7" 6th gen Wi-Fi
                { "iPad7,6", iOSChipType.A10Fusion }, // iPad 9.7" 6th gen Wi-Fi + Cellular
                { "iPad7,11", iOSChipType.A10Fusion }, // iPad 10.2" 7th gen Wi-Fi
                { "iPad7,12", iOSChipType.A10Fusion }, // iPad 10.2" 7th gen Wi-Fi + Cellular
                { "iPad8,1", iOSChipType.A12XBionic }, // iPad Pro 11" Wi-Fi
                { "iPad8,2", iOSChipType.A12XBionic }, // iPad Pro 11" Wi-Fi
                { "iPad8,3", iOSChipType.A12XBionic }, // iPad Pro 11" Wi-Fi + Cellular
                { "iPad8,4", iOSChipType.A12XBionic }, // iPad Pro 11" Wi-Fi + Cellular
                { "iPad8,9", iOSChipType.A12ZBionic }, // iPad Pro 11-inch (2nd generation) Wi-Fi
                { "iPad8,10", iOSChipType.A12ZBionic }, // iPad Pro 11-inch (2nd generation) Wi-Fi + Cellular
                { "iPad8,5", iOSChipType.A12XBionic }, // iPad Pro 12.9" 3nd gen Wi-Fi
                { "iPad8,6", iOSChipType.A12XBionic }, // iPad Pro 12.9" 3nd gen Wi-Fi
                { "iPad8,7", iOSChipType.A12XBionic }, // iPad Pro 12.9" 3nd gen Wi-Fi + Cellular
                { "iPad8,8", iOSChipType.A12XBionic }, // iPad Pro 12.9" 3nd gen Wi-Fi + Cellular
                { "iPad8,11", iOSChipType.A12ZBionic }, // iPad Pro 12.9" 4th gen Wi-Fi
                { "iPad8,12", iOSChipType.A12ZBionic }, // iPad Pro 12.9" 4th gen Wi-Fi + Cellular
                { "iPad11,1", iOSChipType.A12Bionic }, // iPad mini 5 Wi-Fi
                { "iPad11,2", iOSChipType.A12Bionic }, // iPad mini 5 Wi-Fi + Cellular
                { "iPad11,3", iOSChipType.A12Bionic }, // iPad Air 3rd gen Wi-Fi
                { "iPad11,4", iOSChipType.A12Bionic }, // iPad Air 3rd gen Wi-Fi + Cellular
                { "iPad11,6", iOSChipType.A12Bionic }, // iPad (8th Generation) Wi-Fi
                { "iPad11,7", iOSChipType.A12Bionic }, // iPad (8th Generation) Wi-Fi + Cellular
                { "iPad12,1", iOSChipType.A13Bionic }, // iPad (9th Generation) Wi-Fi
                { "iPad12,2", iOSChipType.A13Bionic }, // iPad (9th Generation) Wi-Fi + Cellular
                { "iPad13,1", iOSChipType.A14Bionic }, // iPad Air (4th generation) Wi-Fi
                { "iPad13,2", iOSChipType.A14Bionic }, // iPad Air (4th generation) Wi-Fi + Cellular
                { "iPad13,4", iOSChipType.M1 }, // iPad Pro (11-inch) (3rd generation) Wi-Fi
                { "iPad13,5", iOSChipType.M1 }, // iPad Pro (11-inch) (3rd generation) Wi-Fi
                { "iPad13,6", iOSChipType.M1 }, // iPad Pro (11-inch) (3rd generation) Wi-Fi + Cellular
                { "iPad13,7", iOSChipType.M1 }, // iPad Pro (11-inch) (3rd generation) Wi-Fi + Cellular
                { "iPad13,8", iOSChipType.M1 }, // iPad Pro (12.9-inch) (5th generation) Wi-Fi
                { "iPad13,9", iOSChipType.M1 }, // iPad Pro (12.9-inch) (5th generation) Wi-Fi
                { "iPad13,10", iOSChipType.M1 }, // iPad Pro (12.9-inch) (5th generation) Wi-Fi + Cellular
                { "iPad13,11", iOSChipType.M1 }, // iPad Pro (12.9-inch) (5th generation) Wi-Fi + Cellular
                { "iPad14,1", iOSChipType.A15Bionic }, // iPad mini 5 Wi-Fi
                { "iPad14,2", iOSChipType.A15Bionic }, // iPad mini 5 Wi-Fi + Cellular
                { "iPod1,1", iOSChipType.A4 }, // iPod Touch
                { "iPod2,1", iOSChipType.A4 }, // iPod Touch 2st gen
                { "iPod3,1", iOSChipType.A4 }, // iPod Touch 3rd gen
                { "iPod4,1", iOSChipType.A4 }, // iPod Touch 4th gen
                { "iPod5,1", iOSChipType.A5 }, // iPod Touch 5th gen
                { "iPod7,1", iOSChipType.A8 }, // iPod Touch 6th gen
                { "iPod9,1", iOSChipType.A10Fusion }, // iPod Touch 7th gen
                { "mac", iOSChipType.AppleSiliconMac }, // iOS app running on Apple Silicon Mac
            };
        }

        public iOSChipType GetChipType(string hardware) => modelChipMap.ContainsKey(hardware) ? modelChipMap[hardware] : iOSChipType.Unknown;
    }
}
