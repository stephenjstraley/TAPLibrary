using System.Collections.Generic;
using TAPLibrary.Model;

namespace TAPLibrary.Types
{
    public class WebAppSettings
    {
        public string TAPClientId { get; set; }
        public string TAPSecretKey { get; set; }
        public string Secret { get; set; }
        public string AdminSecret { get; set; }
        public string DbConnection { get; set; }
        public string DBLogConnection { get; set; }
        public string Environment { get; set; }
        public string DataServicesApiBaseUrl { get; set; }
        public string BlobStorageConnectionString { get; set; }
        public string ImageRootPath { get; set; }
        public string ImagesContainer { get; set; }
        public string SignalRFunctionConnectionString { get; set; }
        public List<int> CodeTypesSortedAsc { get; set; }
        public List<int> CodeTypesSortedDesc { get; set; }
        public List<CodeValueFilter> CodeValueFilters { get; set; }
    }
}
