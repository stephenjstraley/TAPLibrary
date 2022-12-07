namespace TAPLibrary.Azure
{
    public static class Connections
    {
        public const string SERVICE_BUS_QA = "Endpoint=sb://tapeventmessagingservicebus.servicebus.windows.net/;SharedAccessKeyName=send;SharedAccessKey=gTYsC7MviZI3Y26SQ9hPQDp7qb5/oTVryrz0D+TL6WE=";
        public const string SERVICE_BUS_QA_LISTEN = "Endpoint=sb://tapeventmessagingservicebus.servicebus.windows.net/;SharedAccessKeyName=listen;SharedAccessKey=dXWhA2VYzqlISqE00CPpgYQyS4+uRxz8Zjvgux74GQw=";

        public const string SERVICE_BUS = "Endpoint=sb://tapeventmessagingservicebus.servicebus.windows.net/;SharedAccessKeyName=send;SharedAccessKey=xWnwOlqypOk5QzWocjUi84BsqXjj67AgtY4cowHXKzA=";
        public const string SERVICE_BUS_LISTEN = "Endpoint=sb://tapeventmessagingservicebus.servicebus.windows.net/;SharedAccessKeyName=listen;SharedAccessKey=BNxhGg0OV7avsWoQnSRADQXziyKwNyeBZfzEC/Q5UcE=";

        public const string SQL_QA = "Server=tcp:tapsqlserverqa.database.windows.net,1433;Initial Catalog={CATALOG};Persist Security Info=False;User ID=astuteadmin;Password={PASSWORD};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public const string SQL = "Server=tcp:tapsqlserver.database.windows.net,1433;Initial Catalog={CATALOG};Persist Security Info=False;User ID=astuteadmin;Password={PASSWORD};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public const string STOPWATCHQUEUE = "DefaultEndpointsProtocol=https;AccountName=tapstopwatchqueue;AccountKey=KmI/DQxOC83I1S+F62eQsv3nIGyA8v4S3C/C0s3mUmgKThXMAkZa/WO6dCs80O2Vd960K75mHGKGvtlGtHuLwA==;EndpointSuffix=core.windows.net";
    }

    public static class LoggingTopics
    {
        public const string QA = "taploggingqa";
        public const string PROD = "taplogging";
    }
    public static class StopwatchTopics
    {
        public const string QA = "tapstopwatchqa";
        public const string PROD = "tapstopwatch";
    }
    public static class LoggingSubscriptions
    {
        public const string QA = "taploggingqasubscription";
        public const string PROD = "taploggingsubscription";
    }
    public static class StopwatchSubscriptions
    {
        public const string QA = "tapstopwatchqasubscription";
        public const string PROD = "tapstopwatchsubscription";
    }
    public static class StopwatchQueue
    {
        public const string QA = "stopwatchqa";
        public const string PROD = "stopwatch";
    }
    public static class LoggingApps
    {
        public const string PARSEHUB = "TAPFunctionIoTReadHubMessage";
        public const string SAVEDEVICE = "TAPFunctionIoTSaveReading";
        public const string ADDUPDATELASTREADING = "TAPFunctionIoTSaveLastReading";
        public const string BROADCAST = "TAPFunctionIoTBroadcastReading";
        public const string SQLDATA = "TAPHcMain";
        public const string DATASERVICE = "TAPDataService";
        public const string TELEGUARDIAN = "TAPTeleGuardian";
        public const string DATAGUARDIAN = "TAPDataGuardian";
        public const string KITTINGFORM = "TAPKittingProcess";
        public const string CUSTOMERFORM = "TAPCustomerProcess";
        public const string DATAGUARDIANPORTAL = "TAPDataGuardianPortal";
        public const string ALERTONHUB = "TAPFunctionIoTAlertOnHub";
        public const string ALERTONHUBDATA = "TAPFunctionIoTAlertOnHubData";
        public const string BROADCASTLATESTREADING = "TAPFunctionIoTBroadcastLatestReading";
    }
    public static class LoggingTableStorage
    {
        //public const string CONNECTION = "DefaultEndpointsProtocol=https;AccountName=tapsbsaveloggingstorage;AccountKey=8T9WKZVFJcj/UgRgPUauAaS067tMhrX6Hqb7wTMG+a0Cv+lwBLUEBuiea1o8QbuQGdwlil/iJncnJ+6twiSOMw==;EndpointSuffix=core.windows.net";
        public const string CONNECTION = "DefaultEndpointsProtocol=https;AccountName=taplogging;AccountKey=K733DjYIHy64KOeiTeHHXLJhfnbuTTuDEngy6novecBkTK8ranYjDb6hGePEZtzp1zGUg2MObvFUcH+LcnlRMA==;EndpointSuffix=core.windows.net";
        public const string CONNECTION_QA = "DefaultEndpointsProtocol=https;AccountName=taploggingqa;AccountKey=htIHrMik5ZRUNpFgQlrox9Dm1ONy2Sen7bRmUBgTm27skc+0q8NBHb6CH1CYfyEuROBIkBXOEX7mHssDGrIIBw==;EndpointSuffix=core.windows.net";
        public const string PARSEHUB = "taplogsreadhubmessage";
        public const string SAVEDEVICE = "taplogssavedevicedata";
        public const string ADDUPDATELASTREADING = "taplogsaddupdatelastreading";
        public const string BROADCAST = "taplogsbroadcasereading";
        public const string SQLDATA = "taplogssqlhcmain";
        public const string TELEGUARDIAN = "taplogteleguardian";
        public const string DATAGUARDIAN = "taplogdataguardian";
        public const string KITTINGFORM = "taplogkittingform";
        public const string CUSTOMERFORM = "taplogcustomerform";
        public const string DATAGUARDIANPORTAL = "taplogdataguardianportal";
        public const string ALERTONHUB = "taplogalertonhub";
        public const string ALERTONHUBDATA = "taplogalertonhubdata";
        public const string BROADCASTLATESTREADING = "taplogsbroadcastlatestreading";
    }
    public static class LoggingFileStorage
    {
        public const string KITTING = "kittingforms";
        public const string CUSTOMER = "customerforms";
        public const string ROOT = "root";
    }

}
