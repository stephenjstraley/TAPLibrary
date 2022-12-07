namespace TAPLibrary.Logging
{
    public class AstuteLoggingModel
    {
        public string EventId { get; set; } = string.Empty;
        public string OriginalMessage { get; set; } = string.Empty;
        public string ProcessName { get; set; } = string.Empty;
        public string LoggingType { get; set; } = string.Empty;
        public string CallingNamespace { get; set; } = string.Empty;
        public string CallingProcudure { get; set; } = string.Empty;
        public string CallingClient { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string Exception { get; set; } = string.Empty;
        public string ClientIP { get; set; } = string.Empty;
        public LogDetail Detail { get; set; } = new LogDetail();

        // upon reading
        public string MessageTemplate { get; set; }
        public string Level { get; set; }
    }
}
