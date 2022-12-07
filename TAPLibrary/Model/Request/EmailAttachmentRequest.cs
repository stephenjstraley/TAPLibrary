namespace TAPLibrary.Model.Request
{
    public class EmailAttachmentRequest
    {
        public string Name { get; set; }
        public string MimeType { get; set; }
        public byte[] Content { get; set; }
    }
}
