namespace TAPLibrary.Model.Response
{
    public class EmailAddressResponse
    {
        //
        // Summary:
        //     The recipient's email address.
        public string EmailAddress { get; set; }
        //
        // Summary:
        //     Whether the recipient was accepted for delivery.
        public bool Accepted { get; set; }
        //
        // Summary:
        //     An error code detailing why the recipient was not accepted.
        public string ErrorCode { get; set; }
    }
}
