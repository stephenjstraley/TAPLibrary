using System.Collections.Generic;

namespace TAPLibrary.Model.Request
{
    public class EmailRequest
    {
        public string Subject { get; set; }
        public string HtmlBody { get; set; }
        public string TextBody { get; set; }
        public string FromEmail { get; set; }
        public List<string> ToEmails { get; set; } = new List<string>();
        public List<EmailAttachmentRequest> Attachments { get; set; }
    }
}
