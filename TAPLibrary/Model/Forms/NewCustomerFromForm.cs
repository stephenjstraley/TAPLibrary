using System;
using System.Collections.Generic;
using System.Text;

namespace TAPLibrary.Model.Forms
{
    public class NewCustomerFromForm
    {
        public NewCustomerFromForm()
        {
            Users = new List<NewCustomerUserFromForm>();
//            CosmosDbCollections = new List<string>();
        }

        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
        public string CompanyUrl { get; set; }
        public string CompanyAdminUserName { get; set; }
        public string CompanySecret { get; set; }
        public string Webhook { get; set; }
        public string DataGuardian { get; set; }
        public string TeleGuardian { get; set; }
        public string ClientId { get; set; }
        public string CreateJira { get; set; }
        public string CreateAzureRepo { get; set; }
        public string CurrentRepository { get; set; } = string.Empty;
        public string CurrentDocDbEndpointUrl { get; set; }
        public string CurrentDocDbAuthKey { get; set; }
        public string CurrentDocDbDatabase { get; set; } = "ahc";
        public string CurrentDocDbCollection { get; set; } = "ahcreadings";
        public string CurrentDocDbArchive { get; set; } = "archived";
        public string CurrentDocDbManualEntries { get; set; } = "";
        public string OnboardQA { get; set; }
        public string LocationName { get; set; }
        public string LocationCode { get; set; }
        public string TimeZone { get; set; }
        public string ManagerFirstName { get; set; }
        public string ManagerLastName { get; set; }
        public string ManagerTitle { get; set; }
        public string PhoneNumber { get; set; }
        public string Extension { get; set; }
        public string Email { get; set; }
        public string LocationType { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Province { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public List<NewCustomerUserFromForm> Users { get; set; }
//        public string CosmosDBName { get; set; }
//        public string CosmosDBPrimaryKey { get; set; }
//        public List<string> CosmosDbCollections { get; set; }
//        public string CosmosDbEndpoint { get; set; }

    }
}
