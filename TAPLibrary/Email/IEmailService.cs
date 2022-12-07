using System.Collections.Generic;
using System.Threading.Tasks;
using TAPLibrary.Model.Request;
using TAPLibrary.Model.Response;

namespace TAPLibrary.Email
{
    public interface IEmailService
    {
        Task<EmailResponse> SendEmailAsync( List<KeyValuePair<string, string>> settings, EmailRequest request );
    }
}
