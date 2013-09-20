Get-iOS-Model
=============

Get the iOS model using the hw.machine string
*******
Will keep this updated as new devices are available.
*******

Sample
-------

```
Console.WriteLine(new iOSHardware().GetModel("iPhone5,3"));
```

Result: "iPhone 5C GSM"

*******
Get device hardware string using Xamarin.iOS
-------

```
Console.WriteLine(Xamarin.iOS.DeviceHardware.Version);
```

*******
####Run Sample:
http://executify.com/10027/
