using System;

namespace TAPLibrary.Logging
{
    public class LogDetail
    {
        public DateTime DateTimeUTC { get; set; }
        public string Message { get; set; }
        public string Url { get; set; }
        public string Hub { get; set; }
        public string ContextId { get; set; }
        public string DocId { get; set; }
        public string RawPayload { get; set; }
        public string Result { get; set; }
        public string ExceptionMessage { get; set; }
        public string InnerExceptionMessage { get; set; }
        public string StackTrace { get; set; }
        public string Source { get; set; }
        public int StatusCode { get; set; } = 0;
        public int CompanyId { get; set; } = 0;
    }
}
