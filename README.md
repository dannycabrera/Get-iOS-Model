![GetiOSModel Logo](https://github.com/dannycabrera/Get-iOS-Model/raw/master/Icons/GetiOSModel.png)

Get-iOS-Model
=============

Get the iOS model using the hw.machine string

|  Package  |
|:----------|
|[![NuGet Badge GetiOSModel](https://buildstats.info/nuget/dannycabrera.GetiOSModel)](https://www.nuget.org/packages/dannycabrera.GetiOSModel)|

*******
Will keep repository updated as new devices become available.

If you need an Android library check out my other repo https://github.com/dannycabrera/GetDroidModel.

Updates:<br/>
20200404 - Added iPhone SE (2nd generation)<br/>
20200327 - Added new iPad models iPad Pro 11-inch (2nd generation) and iPad Pro 12.9-inch (4th generation)<br/>
20190919 - Added hardware strings and chip types for new iPhone 11 models and iPad (7th generation) models<br/>
20190905 - Added Apple Chip Type property<br/>
20190601 - Added iPod touch 7th generation<br/>
20190327 - Added 2019 iPad models: iPad mini 5 and iPad Air 3<br/>
20181107 - iPad Pro 11-inch whitespace character fix thanks to @adamzucchi<br/>
20181106 - Added new iPad models: iPad Pro 12.9-inch (3rd generation) and iPad Pro 11-inch<br/>
20180921 - Added new iPhone models: iPhone XR, iPhone Xs and iPhone Xs Max<br/>
20180330 - Added Apple Tech specs link for iPad 6th generation<br/>
20180328 - Added new iPad 6th generation (2018 9.7-inch model)<br/>
20170929 - Model info now returned on simulators & updated Nuget to v1.3.<br/>
20170919 - Added iPhone 8, 8 Plus and X. Also updating NuGet to v1.2.<br/>
20170914 - NuGet updated to v1.1<br/>
20170706 - Adding NuGet<br/>
20170627 - Added iPad Pro (12.9-inch 2nd generation) and iPad Pro (10.5-inch)<br/>
20170321 - Added new iPad 5th generation<br/>
20161026 - corrected/added missing iPad6,4<br/>
20160912 - added iPhone 7 and 7 Plus<br/>
20160330 - added iPad Pro (9.7-inch) and iPhone SE<br/>
20160119 - added iPad Pro<br/>
20150928 - added iPhone 6s & iPhone 6s Plus<br/>
20150715 - added iPod 6th Generation<br/>
20141020 - added iPad Air 2 & iPad mini 3<br/>
20140917 - added iPhone 6 and 6 Plus<br/>
20140108 - added iPad Mini Retina and iPad Air<br/>
*******

## Install

#### [NuGet Gallery](https://www.nuget.org/packages/dannycabrera.GetiOSModel)
```
Install-Package dannycabrera.GetiOSModel
```

Sample
-------

```
Console.WriteLine(Xamarin.iOS.DeviceHardware.Version);
```

Result: "iPhone5,3"


```
Console.WriteLine(Xamarin.iOS.DeviceHardware.Model);
```

Result: "iPhone 5C GSM"

```
Console.WriteLine(Xamarin.iOS.DeviceHardware.ChipType);
```

Result: "A6"

*******
Thanks to:
-------
@sven-s, @manishkungwani, @jimbobbennett, @adamzucchi and @follesoe for their pull requests.
