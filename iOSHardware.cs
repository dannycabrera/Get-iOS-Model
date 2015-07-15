class iOSHardware
{
	public String GetModel(String hardware)
    {
        // http://support.apple.com/kb/HT3939
        if (hardware.StartsWith("iPhone"))
        {
            // ************
            // iPhone
            // ************
            // Model(s): A1203
            // Apple Tech specs: http://support.apple.com/kb/SP2
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=268052&fcc_id=%27BCGA1203%27
            if (hardware == "iPhone1,1")
                return "iPhone";

            // ************
            // iPhone 3G
            // ************
            // Model(s): A1241 & A1324
            // Apple Tech specs: http://support.apple.com/kb/SP495
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=227268&fcc_id=%27BCGA1241%27
            if (hardware == "iPhone1,2")
                return "iPhone 3G";

            // ************
            // iPhone 3GS
            // ************
            // Model(s): A1303 & A1325
            // Apple Tech specs: http://support.apple.com/kb/SP565
            // FCC Doc(s): 
            //      https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=270938&fcc_id=%27BCGA1303A%27
            //      https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=228576&fcc_id=%27BCGA1303B%27
            if (hardware == "iPhone2,1")
                return "iPhone 3GS";

            // ************
            // iPhone 4
            // ************
            // Model(s): A1332
            // Apple Tech specs: http://support.apple.com/kb/SP587
            // FCC Doc(s): 
            //      https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=573413&fcc_id=%27BCG-E2380A%27
            //      https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=357396&fcc_id=%27BCG-E2380B%27
            if (hardware == "iPhone3,1" || hardware == "iPhone3,2")
                return "iPhone 4 GSM";
            // Model(s): A1349
            // FCC Doc(s): 
            //      https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=161026&fcc_id=%27BCG-E2422A%27
            //      https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=461251&fcc_id=%27BCG-E2422B%27
            if (hardware == "iPhone3,3") 
                return "iPhone 4 CDMA";

            // ************
            // iPhone 4S
            // ************
            // Model(s): A1387 & A1431
            // Apple Tech specs: http://support.apple.com/kb/SP643
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=134990&fcc_id=%27BCG-E2430A%27
            if (hardware == "iPhone4,1")
                return "iPhone 4S";

            // ************
            // iPhone 5
            // ************
            // Model(s): A1428
            // Apple Tech specs: http://support.apple.com/kb/SP655
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=661877&fcc_id=%27BCG-E2599A%27
            if (hardware == "iPhone5,1") 
                return "iPhone 5 GSM";

            // Model(s): A1429 & A1442
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=661877&fcc_id=%27BCG-E2599A%27
            if (hardware == "iPhone5,2")
                return "iPhone 5 Global";

            // ************
            // iPhone 5C
            // ************
            // Model(s): A1456 & A1532
            // Apple Tech specs: http://support.apple.com/kb/SP684
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=638224&fcc_id=%27BCG-E2644A%27
            if (hardware == "iPhone5,3") 
                return "iPhone 5C GSM";

            // Model(s): A1507, A1516, A1526 & A1529
            // FCC Doc(s): 
            //      https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=661269&fcc_id=%27BCG-E2694A%27
            //      https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=372967&fcc_id=%27BCG-E2694B%27
            if (hardware == "iPhone5,4") 
                return "iPhone 5C Global";

            // ************
            // iPhone 5S
            // ************
            // Model(s): A1453 & A1533
            // Apple Tech specs: http://support.apple.com/kb/SP685
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=603437&fcc_id=%27BCG-E2642A%27
            if (hardware == "iPhone6,1")
                return "iPhone 5S GSM";

            // Model(s): A1457, A1518, A1528 & A1530	
            // FCC Doc(s): 
            //      https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=274603&fcc_id=%27BCG-E2643A%27
            //      https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=253062&fcc_id=%27BCG-E2643B%27
            if (hardware == "iPhone6,2")
                return "iPhone 5S Global";

            // ************
            // iPhone 6
            // ************
            // Model(s): A1549 & A1586
            // Apple Tech specs: http://support.apple.com/kb/SP705
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=839691&fcc_id=%27BCG-E2816A%27
            if (hardware == "iPhone7,2")
                return "iPhone 6";

            // ************
            // iPhone 6 Plus
            // ************
            // Model(s): A1522 & A1524	
            // Apple Tech specs: http://support.apple.com/kb/SP706
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=664225&fcc_id=%27BCG-E2817A%27
            if (hardware == "iPhone7,1")
                return "iPhone 6 Plus";
        }

        if (hardware.StartsWith("iPod"))
        {
            // ************
            // iPod touch
            // ************
            // Model(s): A1213
            // Apple Tech specs: http://support.apple.com/kb/SP3
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=693627&fcc_id=%27BCGA1213%27
            if (hardware == "iPod1,1") 
                return "iPod touch";

            // ************
            // iPod touch 2G
            // ************
            // Model(s): A1288
            // Apple Tech specs: http://support.apple.com/kb/SP496
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=128461&fcc_id=%27BCGA1288%27
            if (hardware == "iPod2,1")
                return "iPod touch 2G";

            // ************
            // iPod touch 3G
            // ************
            // Model(s): A1318
            // Apple Tech specs: http://support.apple.com/kb/SP570
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=156063&fcc_id=%27BCG-2310%27
            if (hardware == "iPod3,1")
                return "iPod touch 3G";

            // ************
            // iPod touch 4G
            // ************
            // Model(s): A1367
            // Apple Tech specs: http://support.apple.com/kb/SP594
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=338019&fcc_id=%27BCG-E2407%27
            if (hardware == "iPod4,1")
                return "iPod touch 4G";

            // ************
            // iPod touch 5G
            // ************
            // Model(s): A1421 & A1509
            // Apple Tech specs: (A1421) http://support.apple.com/kb/SP657 & (A1509) http://support.apple.com/kb/SP675
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=141880&fcc_id=%27BCG-A1421%27
            if (hardware == "iPod5,1")
                return "iPod touch 5G";
				
			// ************
            // iPod touch 6G
            // ************
            // Model(s): A1574
            // Apple Tech specs: (A1574) 
            // FCC Doc(s): 
            if (hardware == "iPod7,1")
                return "iPod touch 6G";
        }

        if (hardware.StartsWith("iPad"))
        {
            // ************
            // iPad
            // ************
            // Model(s): A1219 (WiFi) & A1337 (GSM)
            // Apple Tech specs: http://support.apple.com/kb/SP580
            // FCC Doc(s): 
            //      https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=258686&fcc_id=%27BCG%E2%80%91E2381A%27
            //      https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=751625&fcc_id=%27BCG%E2%80%91E2328A%27
            if (hardware == "iPad1,1")
                return "iPad";

            // ************
            // iPad 2
            // ************
            // Apple Tech specs: http://support.apple.com/kb/SP622
            // Model(s): A1395
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=917520&fcc_id=%27BCGA1395%27
            if (hardware == "iPad2,1")
                return "iPad 2 WiFi";
            // Model(s): A1396
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=172019&fcc_id=%27BCGA1396%27
            if (hardware == "iPad2,2")
                return "iPad 2 GSM";
            // Model(s): A1397
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=227368&fcc_id=%27BCGA1397%27
            if (hardware == "iPad2,3")
                return "iPad 2 CDMA";
            // Model(s): A1395
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=917520&fcc_id=%27BCGA1395%27
            if (hardware == "iPad2,4") 
                return "iPad 2 Wifi";

            // ************
            // iPad 3
            // ************
            // Apple Tech specs: http://support.apple.com/kb/SP647
            // Model(s): A1416
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=154309&fcc_id=%27BCGA1416%27
            if (hardware == "iPad3,1")
                return "iPad 3 WiFi";
            // Model(s): A1403
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=154309&fcc_id=%27BCGA1403%27
            if (hardware == "iPad3,2")
                return "iPad 3 Wi-Fi + Cellular (VZ)";
            // Model(s): A1430
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=205511&fcc_id=%27BCGA1430%27
            if (hardware == "iPad3,3") 
                return "iPad 3 Wi-Fi + Cellular";

            // ************
            // iPad 4
            // ************
            // Apple Tech specs: http://support.apple.com/kb/SP662
            // Model(s): A1458
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=212054&fcc_id=%27BCGA1458%27
            if (hardware == "iPad3,4")
                return "iPad 4 Wifi";
            // Model(s): A1459
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=823586&fcc_id=%27BCGA1459%27
            if (hardware == "iPad3,5")
                return "iPad 4 Wi-Fi + Cellular";
            // Model(s): A1460
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=181383&fcc_id=%27BCGA1460%27
            if (hardware == "iPad3,6") 
                return "iPad 4 Wi-Fi + Cellular (MM)";

            // ************
            // iPad Air
            // ************
            // Apple Tech specs: http://support.apple.com/kb/SP692
            // Model(s): A1474
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=367867&fcc_id=BCGA1474
            if (hardware == "iPad4,1")
                return "iPad Air Wifi";
            // Model(s): A1475
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=719473&fcc_id=BCGA1475
            if (hardware == "iPad4,2") 
                return "iPad Air Wi-Fi + Cellular";
            // Model(s): A1476
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=439011&fcc_id=BCGA1476
            if (hardware == "iPad4,3")
                return "iPad Air Wi-Fi + Cellular (TD-LTE)";

            // ************
            // iPad Air 2
            // ************
            // Apple Tech specs: 
            // Model(s): A1566
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=538717&fcc_id=BCGA1566
            if (hardware == "iPad5,3") 
                return "iPad Air 2";
            // Model(s): A1567
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=691573&fcc_id=BCGA1567
            if (hardware == "iPad5,4")
                return "iPad Air 2";

            // ************
            // iPad mini
            // ************
            // Apple Tech specs: http://support.apple.com/kb/SP661
            // Model(s): A1432
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=239862&fcc_id=BCGA1432
            if (hardware == "iPad2,5")
                return "iPad mini Wifi";
            // Model(s): A1454
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=518722&fcc_id=BCGA1454
            if (hardware == "iPad2,6")
                return "iPad mini Wi-Fi + Cellular";
            // Model(s): A1455
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=317335&fcc_id=BCGA1455
            if (hardware == "iPad2,7")
                return "iPad mini Wi-Fi + Cellular (MM)";

            // ************
            // iPad mini 2
            // ************
            // Apple Tech specs: http://support.apple.com/kb/SP693
            // Model(s): A1489
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=632289&fcc_id=BCGA1489
            if (hardware == "iPad4,4")
                return "iPad mini 2 Wifi";
            // Model(s): A1490
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=622019&fcc_id=BCGA1490
            if (hardware == "iPad4,5")
                return "iPad mini 2 Wi-Fi + Cellular";
            // Model(s): A1491
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=194907&fcc_id=BCGA1491
            if (hardware == "iPad4,6")
                return "iPad mini 2 Wi-Fi + Cellular (TD-LTE)";

            // ************
            // iPad mini 3
            // ************
            // Apple Tech specs: 
            // Model(s): A1599
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=331916&fcc_id=BCGA1599
            if (hardware == "iPad4,7")
                return "iPad mini 3 Wifi";
            // Model(s): A1600
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=552649&fcc_id=BCGA1600
            if (hardware == "iPad4,8")
                return "iPad mini 3 Wi-Fi + Cellular";
            // Model(s): A1601
            // FCC Doc(s): https://apps.fcc.gov/oetcf/eas/reports/ViewExhibitReport.cfm?mode=Exhibits&calledFromFrame=N&application_id=482341&fcc_id=BCGA1601
            if (hardware == "iPad4,9")
                return "iPad mini 3 Wi-Fi + Cellular (TD-LTE)";
        }

        if (hardware == "i386" || hardware == "x86_64")
            return "Simulator";
            
        return (hardware == "" ? "Unknown": hardware);        
    }
}
