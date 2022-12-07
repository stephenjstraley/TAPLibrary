using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TAPLibrary.Utilities
{
    public static class ResponseUtil
    {
        
        public static async Task<T> GetResponseDataObjectAsync<T>( HttpResponseMessage response )
        {
            if( response != null && response.IsSuccessStatusCode )
            {
                var content = await response.Content.ReadAsStringAsync();
                var envelope = JToken.Parse( content );
                if( string.IsNullOrEmpty( envelope?["error"]?.ToString() ) && envelope?["data"] != null )
                {
                    var rawData = envelope["data"];
                    if( rawData.Type == JTokenType.Array )
                    {
                        var data = JArray.FromObject( rawData );
                        return data.ToObject<T>();
                    }
                    else if( rawData.Type == JTokenType.Object )
                    {
                        var data = JObject.FromObject( rawData );
                        return data.ToObject<T>();
                    }
                }
            }
            return default;
        }

        public static async Task<T> GetResponseDataObjectAsync<T>( IFlurlResponse response )
        {
            if( response != null && response.StatusCode < 300 )
            {
                var content = await response.GetStringAsync();
                var envelope = JToken.Parse( content );
                if( string.IsNullOrEmpty( envelope?["error"]?.ToString() ) && envelope?["data"] != null )
                {
                    var rawData = envelope["data"];
                    if( rawData.Type == JTokenType.Array )
                    {
                        var data = JArray.FromObject( rawData );
                        return data.ToObject<T>();
                    }
                    else if( rawData.Type == JTokenType.Object )
                    {
                        var data = JObject.FromObject( rawData );
                        return data.ToObject<T>();
                    }
                }
            }
            return default;
        }

        public static async Task<string> GetResponseErrorAsync( HttpResponseMessage response )
        {
            if( response != null && response.IsSuccessStatusCode )
            {
                var content = await response.Content.ReadAsStringAsync();
                var envelope = JToken.Parse( content );
                if( !string.IsNullOrEmpty( envelope?["error"]?.ToString() ) )
                {
                    return envelope["error"].ToString();
                }
            }
            return string.Empty;
        }

        public static async Task<string> GetResponseErrorAsync( IFlurlResponse response )
        {
            if( response != null && response.StatusCode < 300 )
            {
                var content = await response.GetStringAsync();
                var envelope = JToken.Parse( content );
                if( !string.IsNullOrEmpty( envelope?["error"]?.ToString() ) )
                {
                    return envelope["error"].ToString();
                }
            }
            return string.Empty;
        }

        public static async Task<bool> GetResponseHasDataAsync(HttpResponseMessage response)
        {
            if (response != null && response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var envelope = JToken.Parse(content);
                return !string.IsNullOrEmpty(envelope?["data"]?.ToString());
            }
            return false;
        }

        public static async Task<T> GetObjectFromResponseAsync<T>( HttpResponseMessage response )
        {
            if( response.IsSuccessStatusCode )
            {
                var content = await response.Content.ReadAsStringAsync();
                if( !string.IsNullOrEmpty( content ) )
                {
                    return JsonConvert.DeserializeObject<T>( content );
                }
            }
            return default;
        }

        public static async Task<T> GetObjectFromResponseAsync<T>( IFlurlResponse response )
        {
            if( response.StatusCode < 300 )
            {
                var content = await response.GetStringAsync();
                if( !string.IsNullOrEmpty( content ) )
                {
                    return JsonConvert.DeserializeObject<T>( content );
                }
            }
            return default;
        }
    }
}
