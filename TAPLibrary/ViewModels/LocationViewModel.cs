using System;

namespace TAPLibrary.ViewModels
{
    public class LocationViewModel
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int ManagerId { get; set; }
        public int ManagerTitleId { get; set; }
        public int AddressId { get; set; }
        public int GmtId { get; set; }
        public string LocationName { get; set; }
        public string LocationCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
