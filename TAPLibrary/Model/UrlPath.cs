namespace TAPLibrary.Model
{
    public static class UrlPath
    {
        static readonly string IOTHUBMESSAGE_BASE = "api/iothubmessages";
        public static string CAN_SAVE_IOTHUB = IOTHUBMESSAGE_BASE + "/cansave";

        static readonly string ADDRESS_BASE = "api/addresses";
        public static string ADDRESS_ADD = ADDRESS_BASE;
        public static string ADDRESS_ADD_GET = ADDRESS_BASE + "/AddAndGet";
        public static string ADDRESS_GET = ADDRESS_BASE + "/{0}";
        public static string ADDRESS_UPDATE = ADDRESS_BASE;
        public static string ADDRESS_FIND = ADDRESS_BASE + "/find";

        static readonly string BOARD_INVENTORY_BASE = "api/board-inventories";
        public static string BOARD_INVENTORY_GET = BOARD_INVENTORY_BASE + "/{0}";
        public static string BOARD_INVENTORY_FOR_COMPANY_GET = BOARD_INVENTORY_BASE + "/company/{0}";
        public static string BOARD_INVETORY_IMEI_GET = BOARD_INVENTORY_BASE + "/imeis/{0}";
        public static string BOARD_INVENTORY_ASSIGNED_COMPANY_GET = BOARD_INVENTORY_BASE + "/imeis/{0}/company";
        public static string BOARD_INVENTORY_EXTENDED_GET = BOARD_INVENTORY_BASE + "/extended";
        public static string BOARD_INVENTORY_ADD = BOARD_INVENTORY_BASE;
        public static string BOARD_INVENTORY_UPDATE = BOARD_INVENTORY_BASE;
        public static string BOARD_INVENTORY_PAGED_POST = BOARD_INVENTORY_BASE + "/paged";

        static readonly string CAREGIVER_BASE = "api/caregivers";
        public static string CAREGIVER_ALL_IN_COMPANY = CAREGIVER_BASE + "/companies/{0}";
        public static string CAREGIVER_ALL_IN_COMPANY_EXTENDED = CAREGIVER_BASE + "companies/{0}/extended";
        public static string CAREGIVER_GET = CAREGIVER_BASE + "/{0}";
        public static string CAREGIVER_ALL_IN_LOCATION = CAREGIVER_BASE + "/locations/{0}";
        public static string CAREGIVER_PATIENTS = CAREGIVER_BASE + "/{0}/patients";
        public static string CAREGIVER_ADD = CAREGIVER_BASE;
        public static string CAREGIVER_UPDATE = CAREGIVER_BASE;
        public static string CAREGIVER_EXTENDED_ADD = CAREGIVER_BASE + "/extended";

        static readonly string CODETYPE_BASE = "api/codetypes";
        public static string CODE_TYPES_GET_ALL = CODETYPE_BASE;
        public static string CODE_TYPES_GET = CODETYPE_BASE + "/{0}";
        public static string CODE_TYPES_VALUES = CODETYPE_BASE + "/{0}/values";
        public static string CODE_VALUES_GET_ALL = CODETYPE_BASE + "/values";
        public static string CODE_VALUES_GET = CODETYPE_BASE + "/{0}/values/{1}";
        public static string CODE_VALUES_ONLY_GET = CODETYPE_BASE + "/codevalue/{0}";
        public static string CODE_VALUES_GET_BY_DESC = CODETYPE_BASE + "/{0}/values/find";
        public static string CODE_VALUE_EXISTS = CODETYPE_BASE + "/{0}/values/exists/{1}";
        public static string CODE_VALUE_ADD = CODETYPE_BASE + "/value";
        public static string CODE_VALUE_FIND = CODETYPE_BASE + "/find";

        static readonly string COMPANY_BASE = "api/companies";
        public static string COMPANY_GET_ALL = COMPANY_BASE;
        public static string COMPANY_GET_ALL_EXTENDED = COMPANY_BASE + "/extended";
        public static string COMPANY_GET = COMPANY_BASE + "/{0}";
        public static string COMPANY_GET_SUBSIDIARIES = COMPANY_BASE + "/{0}/subsidiaries";
        public static string COMPANY_GET_BY_CLIENTID = COMPANY_BASE + "/{0}/onclientid";
        public static string COMPANY_FIND = COMPANY_BASE + "/find";
        public static string COMPANY_GET_LOCATIONS = COMPANY_BASE + "/{0}/locations";
        public static string COMPANY_GET_EVENT_TYPES = COMPANY_BASE + "/{0}/event-types";
        public static string COMPANY_GET_COMPLETE = COMPANY_BASE + "/{0}/complete";
        public static string COMPANY_GET_BY_USERNAME = COMPANY_BASE + "/users/find/{0}";
        public static string COMPANY_UPDATE_LAST_READING_DATE = COMPANY_BASE + "/reading-last-date";
        //public static string COMPANY_UPDATE_LAST_READING_DATE_WITH_DATE = COMPANY_BASE + "/{0}/lastdate/{1}";
        public static string COMPANY_GET_IMEI_COMPLETE = COMPANY_BASE + "/complete/{0}";
        public static string COMPANY_GET_USERS = COMPANY_BASE + "/{0}/users";
        public static string COMPANY_GET_USERS_COMPLETE = COMPANY_BASE + "/{0}/users/extended";
        public static string COMPANY_CUSTOMER_LOGIN = COMPANY_BASE + "/customer-login";
        public static string COMPANY_GET_CAREGIVERS_COMPLETE = COMPANY_BASE + "/{0}/caregivers/extended";
        public static string COMPANY_GET_PATIENTS_EXTENDED = COMPANY_BASE + "/{0}/patients";
        public static string COMPANY_GET_USER = COMPANY_BASE + "/users/{0}";
        public static string COMPANY_GET_REPOSITORY = COMPANY_BASE + "/{0}/repository";
        public static string COMPANY_USER_LOGON = COMPANY_BASE + "/users/onlogon";
        public static string COMPANY_USER_FIND = COMPANY_BASE + "/users/find";
        public static string COMPANY_USER_EXTENDED_FIND = COMPANY_BASE + "/user-extended/find";
        public static string COMPANY_GET_RESTAPI = COMPANY_BASE + "/{0}/restapi";
        public static string COMPANY_GET_ON_HUB_IMEI = COMPANY_BASE + "/hubimeis/{0}/single";
        public static string COMPANY_GET_LIST_ON_HUB_IMEI = COMPANY_BASE + "/hubimeis/{0}/list";
        public static string COMPANY_GET_HUBS = COMPANY_BASE + "/{0}/hubs";
        public static string COMPANY_GET_WEBHOOK = COMPANY_BASE + "/{0}/webhook";
        public static string COMPANY_GET_ARCHIVE = COMPANY_BASE + "/collections/{0}/{1}/{2}/{3}";
        public static string COMPANY_ADD = COMPANY_BASE;
        public static string COMPANY_ADD_FROM_FORM = COMPANY_BASE + "/addfromform";
        public static string COMPANY_ADD_AND_GET = COMPANY_BASE + "/addandget";
        public static string COMPANY_ADD_REPOSITORY = COMPANY_BASE + "/{0}/repository";
        public static string COMPANY_ADD_RESTAPI = COMPANY_BASE + "/{0}/restapi";
        public static string COMPANY_ADD_USER = COMPANY_BASE + "/{0}/users";
        public static string COMPANY_ADD_AND_GET_USER = COMPANY_BASE + "/addandget/{0}/users";
        public static string COMPANY_ADD_USER_COM = COMPANY_BASE + "/{0}/user-comm";
        public static string COMPANY_ADD_USER_EXTENDED = COMPANY_BASE + "/{0}/user-extended";
        public static string COMPANY_FIND_HUB = COMPANY_BASE + "/{0}/hub/{1}";
        public static string COMPANY_ADD_HUB = COMPANY_BASE + "/{0}/companyhub";
        public static string COMPANY_AUTHENTICATE = COMPANY_BASE + "/authenticate";
        public static string COMPANY_UPDATE_USER_LOGGEDON = "/userlastloggedon";
        public static string COMPANY_ADD_USER_AND_MEANS = "/{0}/users/{1}/communication-means";

        static readonly string HUB_BASE = "api/hubs";
        public static string HUB_GET = HUB_BASE + "/{0}";
        public static string HUB_GET_ON_IMEI = HUB_BASE + "/imeis/{0}";
        public static string HUB_GET_FOR_COMPANY = HUB_BASE + "/company/{0}";
        public static string HUB_IS_ASSIGNED = HUB_BASE + "/imeis/{0}/is-hub-assigned";
        public static string HUB_CAN_SAVE_DATA = HUB_BASE + "/imeis/{0}/can-save-data";
        public static string HUB_CAN_SAVE_HUB_DATA = HUB_BASE + "/imeis/{0}/can-save-hub-data";
        public static string HUB_ADD = HUB_BASE;
        public static string HUB_UPDATE = HUB_BASE;
        public static string HUB_REMOVE = HUB_BASE + "/{0}";
        public static string HUB_LAST_READING = HUB_BASE + "/last-reading";
        public static string HUB_WITH_COMPANY_API = HUB_BASE + "/company-api/{0}";
        public static string HUB_WITH_GLUCOMETER_SECURITY_CODE = HUB_BASE + "/{id}/glucometer-security-code";
        public static string HUB_WITH_WEIGHTSCALE_SECURITY_CODE = HUB_BASE + "/{id}/weightscale-security-code";
        public static string HUB_WITH_BP_SECURITY_CODE = HUB_BASE + "/{id}/bp-security-code";

        static readonly string SECURITY_BASE = "api/security";
        public static string ROLE_ADD = SECURITY_BASE + "/roles";
        public static string ROLE_GET = SECURITY_BASE + "/roles/{0}";
        public static string ROLE_CLAIM_ADD = SECURITY_BASE + "/roles/claims";
        public static string ROLE_CLAIM_GET = SECURITY_BASE + "/roles/claims/{0}";
        public static string ROLE_CLAIM_GET_WITH_VALUE = SECURITY_BASE + "/roles/{0}/claims/{1}";
        public static string ROLE_CLAIMS_GET = SECURITY_BASE + "/roles/{0}/claims";

        static readonly string LOCATION_BASE = "api/locations";
        public static string LOCATION_GET = LOCATION_BASE + "/{0}";
        public static string LOCATION_FIND = LOCATION_BASE + "/find";
        public static string LOCATION_ADD = LOCATION_BASE;
        public static string LOCATION_UPDATE = LOCATION_BASE;
        public static string LOCATION_EXTENDED_GET_FOR_COMPANY = LOCATION_BASE + "/extended/company/{0}";
        public static string LOCATION_EXTENDED_GET = LOCATION_BASE + "/extended/{0}";

        static readonly string PASSWORDS_BASE = "api/passwords";
        public static string SECRET_QUESTIONS_GET = PASSWORDS_BASE + "/secret-questions";
        public static string PASSWORD_GET = PASSWORDS_BASE + "/{0}";
        public static string PASSWORD_FIND = PASSWORDS_BASE + "/find";
        public static string PASSWORD_REQUIRES_CHANGING = PASSWORDS_BASE + "/{0}/requires-changing";
        public static string PASSWORD_ADD = PASSWORDS_BASE;
        public static string PASSWORD_ADD_AND_GET = PASSWORDS_BASE + "/addandget";
        public static string PASSWORD_UPDATE = PASSWORDS_BASE;

        static readonly string PATIENTS_BASE = "api/patients";
        public static string PATIENT = PATIENTS_BASE + "/{0}";
        public static string PATIENT_ADVOCATE_GET = PATIENTS_BASE + "/{0}/advocates/single";
        public static string PATIENT_VITAL_SETTINGS = PATIENTS_BASE + "/{0}/vital-settings";
        public static string PATIENT_CAREGIVERS_COMPLETE = PATIENTS_BASE + "/{0}/caregivers/extended";
        public static string PATIENT_ADVOCATES_GET = PATIENTS_BASE + "/{0}/advocates";
        public static string PATIENT_ADVOCATE_ADD = PATIENT_ADVOCATES_GET;
        public static string PATIENT_ADVOCATE_UPDATE = PATIENT_ADVOCATES_GET;
        public static string PATIENT_CAREGIVERS_GET = PATIENTS_BASE + "/{id}/caregivers";
        public static string PATIENT_CAREGIVER_ADD = PATIENT_CAREGIVERS_GET;
        public static string PATIENT_CAREGIVER_COMMS_GET = PATIENTS_BASE + "/{0}/caregivers/communications";
        public static string PATIENTS_FOR_COMPANY_COMPLETE_GET = PATIENTS_BASE + "/extended/companies/{0}";
        public static string PATIENT_LOCATIONS_EXTENDED_GET = PATIENTS_BASE + "/extended/locations/{0}";
        public static string PATIENT_HUBS_GET = PATIENTS_BASE + "/{0}/hubs";
        public static string PATIENT_HUBS_ASSIGNED = PATIENTS_BASE = "/{0}/hubs/assigned/{1}";
        public static string PATIENT_HUBS_REMOVE = "/{0}/hubs/{1}";
        public static string PATIENT_DEVICES_GET = PATIENTS_BASE + "/{0}/devices";
        public static string PATIENT_ACTIVE_CAREGIVERS_GET = PATIENTS_BASE + "/{0}/caregivers/active";
        public static string PATIENT_COMMS_GET = PATIENTS_BASE + "/{0}/communications";
        public static string PATIENT_VALUE_ALERTS_GET = PATIENTS_BASE + "/{0}/value-alerts";
        public static string PATIENT_AND_ADVOCATE_FULL_EXTENDED_ADD = PATIENTS_BASE + "/patient-advocate-full-extended";
        public static string PATIENT_GET_ON_HUB = PATIENTS_BASE + "/{0}/hub";

        static readonly string VALUE_BASE = "api/values";
        public static string ENVIRONMENT_GET = VALUE_BASE + "/environment";
        public static string VALUE_GET = VALUE_BASE;

        static readonly string ENTITY_BASE = "api/entity";
        public static string ENTITY_ADD = ENTITY_BASE;

        static readonly string PERSON_IDENTITY_BASE = "api/person-identity";
        public static string PERSON_IDENTITY_ADD = PERSON_IDENTITY_BASE;
        public static string PERSON_IDENTITY_COMPANY_USER_ADD_AND_GET = PERSON_IDENTITY_BASE + "/addandgetcompanyuser";
        public static string PERSON_IDENTITY_LOCATION_MANAGER_ADD_AND_GET = PERSON_IDENTITY_BASE + "/addandgetlocationmanager";

        static readonly string COMMUNICATION_MEAN_BASE = "api/communication-means";
        public static string COMM_MEAN_ADD = COMMUNICATION_MEAN_BASE;
        public static string COMM_MEAN_ADD_AND_GET = COMMUNICATION_MEAN_BASE + "/addandget";

        static readonly string WEATHERAQ_BASE = "api/weatheraq";
        public static string WEATHERAQ_ZIPCODES = WEATHERAQ_BASE + "/getzipcodes";
        public static string WEATHERAQ_GET = WEATHERAQ_BASE + "/{0}";
        public static string WEATHERAQ_UPDATE = WEATHERAQ_BASE;

        static readonly string ALERT_BASE = "api/alert";
        public static string ON_HUB_GET = ALERT_BASE + "/getonhub/{0}";
        public static string ON_HUB_UPDATE = ALERT_BASE + "/updateonhub";

        static readonly string LOGS_BASE = "api/logs";
        public static string BAD_RESPONSES = $"{LOGS_BASE}/badresponses/{0}";
        public static string LAST_SAVED_READINGS = $"{LOGS_BASE}/lastsavedreadings/{0}/{1}";
        public static string NOT_SAVED_READINGS = $"{LOGS_BASE}/notsavedreadings";
    }
}
