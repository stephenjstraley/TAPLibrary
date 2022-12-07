using System;
using System.Collections.Generic;
using System.Text;

namespace TAPLibrary.Logging
{
    public static class EventType
    {
        public static string NEW_DEVICE_DATA = "NewDeviceReading";
        public static string VALUE_ALERT_DATA = "NewAlertInformation";
        public static string VALUE_ALERT_DATA_TRIGGERED = "ValueAlertTriggered";
        public static string CRON_JOB_EXECUTED = "CronJobExecuted";
    }
}
