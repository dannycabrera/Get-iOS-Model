Get-iOS-Model
=============

Get the iOS model using the hw.machine string
*******
Will keep this updated as new devices are available.

Updated on 9/17/2014 to include iPhone 6 and 6 Plus

Updated on 1/8/2014 to include iPad Mini Retina and iPad Air.
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
Console.WriteLine(new iOSHardware().GetModel(Xamarin.iOS.DeviceHardware.Version));
```

*******
####Run Sample:
http://executify.com/10027/
