namespace TAPLibrary.Model.Request
{
    public class CompanyUserExistsRequest
    {
        public int CompanyId { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
    }
}
