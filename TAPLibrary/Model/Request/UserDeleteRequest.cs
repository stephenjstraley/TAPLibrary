namespace TAPLibrary.Model.Request
{
    public class UserDeleteRequest
    {
        public int CompanyId { get; set; }
        public int UserId { get; set; }
        public string AdminSecret { get; set; }
    }
}
