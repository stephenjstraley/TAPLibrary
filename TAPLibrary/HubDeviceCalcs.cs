using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TAPLibrary
{
    public static class HubDeviceCalcs
    {
            public static bool GetBit(uint b, int bitNumber) => (b & (1 << bitNumber)) != 0;

            public static int? SafeHexConvert(string value, List<string> parsingErrors, string fieldName, bool byteSwap = false)
            {
                try
                {
                    if (byteSwap)
                        value = ByteSwap(value, parsingErrors);

                    return int.Parse(value, System.Globalization.NumberStyles.HexNumber);
                }
                catch
                {
                    parsingErrors.Add($"Could not parse value {value} into field {fieldName}");
                    return (int?)null;
                }
            }

            public static uint? SafeHexConvertToUint(string value, List<string> parsingErrors, string fieldName, bool byteSwap = false)
            {
                try
                {
                    if (byteSwap)
                        value = ByteSwap(value, parsingErrors);

                    return uint.Parse(value, System.Globalization.NumberStyles.HexNumber);
                }
                catch
                {
                    parsingErrors.Add($"Could not parse value {value} into field {fieldName}");
                    return (uint?)null;
                }
            }

            public static DateTime ParseStandardReadingTimestamp(/*AstuteLog log,*/ string timestampString, List<string> parsingErrors)
            {
                StackFrame frame = new StackTrace().GetFrame(1);
                try
                {
                    int Year = (int)SafeHexConvert(timestampString.Substring(0, 4), parsingErrors, "Year", byteSwap: true);
                    int Month = (int)SafeHexConvert(timestampString.Substring(4, 2), parsingErrors, "Month");
                    int Day = (int)SafeHexConvert(timestampString.Substring(6, 2), parsingErrors, "Day");
                    int Hour = (int)SafeHexConvert(timestampString.Substring(8, 2), parsingErrors, "Hour");
                    int Minute = (int)SafeHexConvert(timestampString.Substring(10, 2), parsingErrors, "Minute");
                    int Second = (int)SafeHexConvert(timestampString.Substring(12, 2), parsingErrors, "Second");

                    return new DateTime(Year, Month, Day, Hour, Minute, Second);
                }
                catch (Exception ex)
                {
                    parsingErrors.Add($"Parsed Standard Reading Timestamp unable to convert: {ex.Message}");
                    //                log.Error(ex, $"invalid timestamp called from {frame.GetMethod().Name} [{timestampString}]");
                    return new DateTime(1900, 01, 01, 00, 00, 00);
                }
            }


            public static string ByteSwap(string input, List<string> parsingErrors)
            {
                if (input.Length == 4)
                    return input.Substring(2, 2) + input.Substring(0, 2);

                else
                {
                    parsingErrors.Add($"ByteSwap called with string other than 4 bytes long: \"" + input + "\"");
                    return input;
                }
            }

            public static double ReadSFloat(uint int_data)
            {

                const uint MDER_S_POSITIVE_INFINITY = 0x07FE;
                //const uint MDER_S_NaN = 0x07FF;
                //const uint MDER_S_NRes = 0x0800;
                //const uint MDER_S_RESERVED_VALUE = 0x0801;
                const uint MDER_S_NEGATIVE_INFINITY = 0x0802;

                const uint FIRST_RESERVED_VALUE = MDER_S_POSITIVE_INFINITY;

                int mantissa = (int)int_data & 0x0FFF;
                int expoent = (int)int_data >> 12;

                if (expoent >= 0x0008)
                {
                    expoent = -((0x000F + 1) - expoent);
                }

                double output = 0;

                if (mantissa >= FIRST_RESERVED_VALUE && mantissa
                    <= MDER_S_NEGATIVE_INFINITY)
                {
                    if (mantissa == MDER_S_POSITIVE_INFINITY)
                    {
                        output = Single.PositiveInfinity;
                    }
                    else if (mantissa == MDER_S_NEGATIVE_INFINITY)
                    {
                        output = Single.NegativeInfinity;
                    }
                    else
                    {
                        output = Single.NaN;
                    }
                }
                else
                {
                    if (mantissa >= 0x0800)
                    {
                        mantissa = -((0x0FFF + 1) - mantissa);
                    }
                    double magnitude = Math.Pow(10.0f, expoent);
                    output = (mantissa * magnitude);
                }

                return output;
            }

            public static IEnumerable<string> ChunkString(string source, int chunkLength)
            {
                for (int index = 0; index < source.Length; index += chunkLength)
                {
                    yield return source.Substring(index, chunkLength);
                }
            }

    }
}
