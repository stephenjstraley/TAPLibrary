using System.Collections.Generic;
using TAPLibrary.Enums;

namespace TAPLibrary.Model.Response
{
    public class EmailResponse
    {
        //
        // Summary:
        //     The result of the send request.
        public EmailSendResult Result { get; set; }

        //
        // Summary:
        //     A unique key generated by the Injection API if an unexpected error occurs during
        //     the SocketLabsClient send request. This unique key can be used by SocketLabs
        //     support to troubleshoot the issue.
        public string TransactionReceipt { get; set; }

        //
        // Summary:
        //     An array of AddressResult objects that contain the status of each address that
        //     failed. If no messages failed this array is empty.
        public List<EmailAddressResponse> AddressResults { get; set; } = new List<EmailAddressResponse>();

        //
        // Summary:
        //     A message detailing why the SocketLabsClient send request failed.
        public string ResponseMessage { get; set;  }
    }

}
