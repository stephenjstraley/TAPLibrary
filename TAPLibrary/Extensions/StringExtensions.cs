using System;
using Flurl.Http;

namespace TAPLibrary.Extensions
{
    public static class StringExtensions
    {
        public static string ToUrl( this string item, params object[] input )
        {
            return string.Format( item, input );
        }

        public static IFlurlRequest TapHeader( this string item )
        {
            return item.WithHeader( Constants.HEADER_CLIENT_ID, "cl-tap" ).WithHeader( Constants.HEADER_SECRET_KEY, "ygkKTth2v77mqJNCEmCSv2KHvYEmnT2Y" );
        }

        public static IFlurlRequest TapHeader( this string item, string clientId, string secret )
        {
            return item.WithHeader( Constants.HEADER_CLIENT_ID, clientId ).WithHeader( Constants.HEADER_SECRET_KEY, secret );
        }
        
        public static string Left(this string s, int length)
        {
            length = Math.Max(length, 0);

            return (s.Length > length) ? s.Substring(0, length) : s;
        }

        public static int ToInt( this string s, int defaultValue = 0 )
        {
            int rtn = defaultValue;
            if( int.TryParse( s, out int temp ) )
            {
                rtn = temp;
            }
            return rtn;
        }

        public static long ToLong( this string s, long defaultValue = 0 )
        {
            long rtn = defaultValue;
            if( long.TryParse( s, out long temp ) )
            {
                rtn = temp;
            }
            return rtn;
        }

        public static bool ToBool( this string s, bool defaultValue = false )
        {
            bool rtn = defaultValue;
            if( bool.TryParse( s, out bool temp ) )
            {
                rtn = temp;
            }
            return rtn;
        }
    }
}
