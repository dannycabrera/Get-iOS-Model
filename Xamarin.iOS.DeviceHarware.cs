using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Xamarin.iOS
{
    public static class DeviceHardware
    {
        public const string HardwareProperty = "hw.machine";

        [DllImport(Constants.SystemLibrary)]
        internal static extern int sysctlbyname([MarshalAs(UnmanagedType.LPStr)] string property, // name of the property
                                                IntPtr output, // output
                                                IntPtr oldLen, // IntPtr.Zero
                                                IntPtr newp, // IntPtr.Zero
                                                uint newlen // 0
                                                );
        public static string Version
        {
            get
            {
                try 
                {
                    // get the length of the string that will be returned
                    var pLen = Marshal.AllocHGlobal(sizeof(int));
                    sysctlbyname(HardwareProperty, IntPtr.Zero, pLen, IntPtr.Zero, 0);
                                        
                    var length = Marshal.ReadInt32(pLen);
                                        
                    // check to see if we got a length
                    if (length == 0)
                    {
                            Marshal.FreeHGlobal(pLen);
                            return "Unknown";
                    }
                                        
                    // get the hardware string
                    var pStr = Marshal.AllocHGlobal(length);
                    sysctlbyname(HardwareProperty, pStr, pLen, IntPtr.Zero, 0);
                                        
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
        }
    }
}
