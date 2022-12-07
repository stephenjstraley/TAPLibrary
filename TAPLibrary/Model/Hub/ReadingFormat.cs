using System;
using System.Collections.Generic;
using System.Text;

namespace TAPLibrary.Model.Hub
{
    public static class ReadingFormat
    {
        public static readonly int BrandName = 0;
        public static readonly int HubVersion = 1;
        public static readonly int TimeStamp = 2;
        public static readonly int HubType = 3;
        public static readonly int HubId = 4;
        public static readonly int BLEMacAddress = 5;
        public static readonly int BLEDeviceClass = 6;
        public static readonly int BLEManufacturer = 7;
        public static readonly int BLEModelNumber = 8;
        public static readonly int BLESerialNumber = 9;
        public static readonly int BLEHardwareVersion = 10;
        public static readonly int BLEFirmwareVersion = 11;
        public static readonly int BLEReading = 12;


        public static readonly int MacAddressLength = 12;
        public static readonly int Count = 13;
        public static readonly int PackageIndex = 12;
    }

}
