using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Xamarin.iOS
{
	public static class DeviceHardware
    {
        private const string HardwareProperty = "hw.machine";

        [DllImport(Constants.SystemLibrary)]
        private static extern int Sysctlbyname([MarshalAs(UnmanagedType.LPStr)] string property,
                                                IntPtr output,
                                                IntPtr oldLen,
                                                IntPtr newp,
                                                uint newlen);

        private static readonly iOSHardware _hardwareMapper = new iOSHardware();
        private static readonly Lazy<string> _version = new Lazy<string>(FindVersion);

        private static string FindVersion()
        {
            try
            {
                // get the length of the string that will be returned
                var pLen = Marshal.AllocHGlobal(sizeof(int));
                Sysctlbyname(HardwareProperty, IntPtr.Zero, pLen, IntPtr.Zero, 0);

                var length = Marshal.ReadInt32(pLen);

                // check to see if we got a length
                if (length == 0)
                {
                    Marshal.FreeHGlobal(pLen);
                    return "Unknown";
                }

                // get the hardware string
                var pStr = Marshal.AllocHGlobal(length);
                Sysctlbyname(HardwareProperty, pStr, pLen, IntPtr.Zero, 0);

                // convert the native string into a C# string
                var hardwareStr = Marshal.PtrToStringAnsi(pStr);

                // cleanup
                Marshal.FreeHGlobal(pLen);
                Marshal.FreeHGlobal(pStr);

                return hardwareStr;
            }
            catch (Exception ex)
            {
                Console.WriteLine("DeviceHardware.Version Ex: " + ex.Message);
            }

            return "Unknown";
		}

        public static string Version => FindVersion();
        public static string Model => _hardwareMapper.GetModel(Version);
    }
}
