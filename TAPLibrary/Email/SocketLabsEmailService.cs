using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocketLabs.InjectionApi;
using SocketLabs.InjectionApi.Message;
using TAPLibrary.Enums;
using TAPLibrary.Model.Request;
using TAPLibrary.Model.Response;

namespace TAPLibrary.Email
{
    public class SocketLabsEmailService : IEmailService
    {

        public async Task<EmailResponse> SendEmailAsync( List<KeyValuePair<string, string>> settings, EmailRequest request )
        {
            try
            {
                if( settings.Where( x => x.Key == EmailSettingsKeys.SERVER_ID ).Any() &&
                    settings.Where( x => x.Key == EmailSettingsKeys.INJECTION_API_KEY ).Any() )
                {
                    int serverId = Convert.ToInt32( settings.Where( x => x.Key == EmailSettingsKeys.SERVER_ID ).Select( x => x.Value ).SingleOrDefault() );
                    string injectionApiKey = settings.Where( x => x.Key == EmailSettingsKeys.INJECTION_API_KEY ).Select( x => x.Value ).SingleOrDefault();

                    using( SocketLabsClient client = new SocketLabsClient( serverId, injectionApiKey ) )
                    {
                        BasicMessage message = new BasicMessage
                        {
                            Subject = request.Subject,
                            HtmlBody = request.HtmlBody,
                            PlainTextBody = request.TextBody
                        };
                        message.From.Email = request.FromEmail;
                        foreach( string emailTo in request.ToEmails )
                        {
                            message.To.Add( emailTo );
                        }

                        if( ( request.Attachments?.Count ?? 0 ) > 0 )
                        {
                            foreach( EmailAttachmentRequest attachmentRequest in request.Attachments )
                            {
                                message.Attachments.Add( attachmentRequest.Name, attachmentRequest.MimeType, attachmentRequest.Content );
                            }
                        }

                        SendResponse response = await client.SendAsync( message, new System.Threading.CancellationToken() );
                        if( response != null )
                        {
                            EmailResponse emailResponse = new EmailResponse
                            {
                                Result = ( EmailSendResult )( int )response.Result,
                                ResponseMessage = response.ResponseMessage,
                                TransactionReceipt = response.TransactionReceipt
                            };
                            if( ( response?.AddressResults?.Length ?? 0 ) > 0 )
                            {
                                foreach( AddressResult addressResult in response.AddressResults )
                                {
                                    emailResponse.AddressResults.Add( new EmailAddressResponse
                                    {
                                        Accepted = addressResult.Accepted,
                                        EmailAddress = addressResult.EmailAddress,
                                        ErrorCode = addressResult.ErrorCode
                                    } );
                                }
                            }
                            return emailResponse;
                        }
                        else
                        {
                            throw new Exception( "Failed to get response from provider" );
                        }
                    }
                }
                else
                {
                    throw new NullReferenceException( "Email settings are incorrect. Need both server ID and injection API key" );
                }
            }
            catch 
            {
                throw;
            }
        }
    }
}
