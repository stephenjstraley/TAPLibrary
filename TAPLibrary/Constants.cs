using System.Collections.Generic;

namespace TAPLibrary
{
    public static class Constants
    {
        public const string DEVICE_TYPE_GLUCOSE = "GLUCOSE";
        public const string DEVICE_TYPE_OXIMETER = "OXIMETER";
        public const string DEVICE_TYPE_BP = "BP";
        public const string DEVICE_TYPE_WEIGHTSCALE = "WEIGHTSCALE";

        public const string IMAGE_NAME_PREFIX = "astute-image";
        public const string IMAGE_PLACEHOLDER = "img-placeholder.png";

        public const int OFFSET_WEIGHT_MIN = 10;
        public const int OFFSET_WEIGHT_MAX = 10;
        public const int OFFSET_OXIMETER_SPO2_MIN = 5;
        public const int OFFSET_GLUCOSE_MIN = 20;
        public const int OFFSET_GLUCOSE_MAX = 20;
        public const int OFFSET_OXIMETER_PULSE_MIN = 10;
        public const int OFFSET_OXIMETER_PULSE_MAX = 10;
        public const int OFFSET_BP_DIA_MIN = 15;
        public const int OFFSET_BP_DIA_MAX = 15;
        public const int OFFSET_BP_SYS_MIN = 15;
        public const int OFFSET_BP_SYS_MAX = 15;
        public const int OFFSET_BP_PULSE_MIN = 10;
        public const int OFFSET_BP_PULSE_MAX = 10;

        public const string HEADER_CLIENT_ID = "X-TAP-CLID";
        public const string HEADER_SECRET_KEY = "X-TAP-SK";

        public const int PASSWORD_ID_NOCHANGE = -999;

        public const string IMAGES_CACHE_FOLDER = "images-cache";

        public const string USER_TYPE_COMPANY = "COMPANY";
        public const string USER_TYPE_PATIENT = "PATIENT";
        public const string USER_TYPE_CAREGIVER = "CAREGIVER";
        public const string USER_TYPE_ADVOCATE = "ADVOCATE";

        public const int ROLE_ID_MASTER = 1000;
        public const int ROLE_ID_ADMIN = 1001;
        public const int ROLE_ID_PHYSICIAN = 1002;
        public const int ROLE_ID_SR_NURSE = 1003;
        public const int ROLE_ID_NURSE = 1004;
        public const int ROLE_ID_PATIENT = 1005;
        public const int ROLE_ID_ADVOCATE = 1006;
        public const int ROLE_ID_WAREHOUSE_ADMIN = 1007;
        public const int ROLE_ID_DG_ADMIN = 1008;

        public const string SECURITY_CODE_TPL_GLUCOMETER = "nvs,set,tmg={{\"PIN\":\"{0}\"}}";
        public const string SECURITY_CODE_TPL_BP = "nvs,set,bpm9210={{\"PIN\":\"{0}\"}}";
        public const string SECURITY_CODE_TPL_WEIGHTSCALE = "nvs,set,ws290={{\"PIN\":\"{0}\"}}";
        public const string SECURITY_CODE_TPL_OXIMETER = "nvs,set,tmg={{\"PIN\":\"{0}\"}}";

        public static List<string> IMAGE_CONTENT_TYPES => new List<string> { "image/png", "image/gif", "image/jpg", "image/jpeg" };
    }

    public static class SortColumns
    {
        public const string SORT_DEVICE_TYPE = "devicetype";
        public const string SORT_TIMESTAMP = "timestamp";
        public const string SORT_HUB_ID = "hubid";
        public const string SORT_REAL_TIME = "realtime";
    }

    public static class SortDirections
    {
        public const string SORT_DIRECTION_ASC = "asc";
        public const string SORT_DIRECTION_DESC = "desc";
    }

    public class DeviceTypes
    {
        public const string OX = "OXIMETER";
        public const string BP = "BP";
        public const string WEIGHT = "WEIGHTSCALE";
        public const string GLUCOSE = "GLUCOSE";
        public const string MPERS = "MPERS";
    }

    public class DeviceTypeIds
    {
        public const int OX = 1;
        public const int BP = 2;
        public const int WEIGHT = 3;
        public const int GLUCOSE = 4;
        public const int MPERS = 5;

    }
    public class ReadingTypes
    {
        public const string OX = "PULSEOXIMETERREADING";
        public const string BP = "BPREADING";
        public const string WEIGHT = "WEIGHTSCALEREADING";
        public const string GLUCOSE = "GLUCOMETERREADINGS";
        public const string MPERS = "MERSReading";
    }
    public class ParsingReadingTypes
    {
        public const string OX = "PULSEOXIMETERDEVICEREADING";
        public const string BP = "BPDEVICEREADING";
        public const string WEIGHT = "WEIGHTSCALEDEVICEREADING";
        public const string GLUCOSE = "GLUCOMETERDEVICEREADINGS";
        public const string MPERS = "MERSDEVICEREADING";
    }
    public class Environments
    {
        public const string PRODUCTION = "PRODUCTION";
        public const string QA = "QA";
        public const string LOCAL = "LOCAL";
    }

    public static class EmailSettingsKeys
    {
        public const string SERVER_ID = "ServerId";
        public const string INJECTION_API_KEY = "InjectionApiKey";
    }

    public static class MimeTypes
    {
        public const string BMP = "image/bmp";
        public const string CSV = "text/csv";
        public const string DOC = "application/msword";
        public const string DOCX = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
        public const string GIF = "image/gif";
        public const string HTML = "text/html";
        public const string JPEG = "image/jpeg";
        public const string PDF = "application/pdf";
        public const string PNG = "image/png";
        public const string PPT = "application/vnd.ms-powerpoint";
        public const string PPTX = "application/vnd.openxmlformats-officedocument.presentationml.presentation";
        public const string TEXT = "text/plain";
        public const string XLS = "application/vnd.ms-excel";
        public const string XLSX = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        public const string XML = "application/xml";
        public const string ZIP = "application/zip";
    }

}
