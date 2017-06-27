Get-iOS-Model
=============

Get the iOS model using the hw.machine string
*******
Will keep this updated as new devices are available.

Updates:<br/>
06/27/2017 - Added iPad Pro (12.9-inch 2nd generation) and iPad Pro (10.5-inch)<br/>
03/21/2017 - Added new iPad 5th generation<br/>
10/26/2016 - corrected/added missing iPad6,4<br/>
09/12/2016 - added iPhone 7 and 7 Plus<br/>
03/30/2016 - added iPad Pro (9.7-inch) and iPhone SE<br/>
01/19/2016 - added iPad Pro<br/>
09/28/2015 - added iPhone 6s & iPhone 6s Plus<br/>
07/15/2015 - added iPod 6th Generation<br/>
10/20/2014 - added iPad Air 2 & iPad mini 3<br/>
09/17/2014 - added iPhone 6 and 6 Plus<br/>
01/08/2014 - added iPad Mini Retina and iPad Air<br/>
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
