namespace TAPLibrary.Enums
{
    public enum EmailSendResult
    {
        //
        // Summary:
        //     An error has occured that was unforeseen
        UnknownError = 0,
        //
        // Summary:
        //     A timeout occurred sending the message
        Timeout = 1,
        //
        // Summary:
        //     Successful send of message
        Success = 2,
        //
        // Summary:
        //     Warnings were found while sending the message
        Warning = 3,
        //
        // Summary:
        //     Internal server error
        InternalError = 4,
        //
        // Summary:
        //     Message size has exceeded the size limit
        MessageTooLarge = 5,
        //
        // Summary:
        //     Message exceeded maximum recipient count in the message
        TooManyRecipients = 6,
        //
        // Summary:
        //     Invalid data was found on the message
        InvalidData = 7,
        //
        // Summary:
        //     The account is over the send quota, rate limit exceeded
        OverQuota = 8,
        //
        // Summary:
        //     Too many errors occurred sending the message
        TooManyErrors = 9,
        //
        // Summary:
        //     The ServerId/ApiKey combination is invalid
        InvalidAuthentication = 10,
        //
        // Summary:
        //     The account has been disabled
        AccountDisabled = 11,
        //
        // Summary:
        //     Too many messages were found in the request
        TooManyMessages = 12,
        //
        // Summary:
        //     No valid recipients were found in the message
        NoValidRecipients = 13,
        //
        // Summary:
        //     An invalid recipient were found on the message
        InvalidAddress = 14,
        //
        // Summary:
        //     An invalid attachment were found on the message
        InvalidAttachment = 15,
        //
        // Summary:
        //     No message body was found in the message
        NoMessages = 16,
        //
        // Summary:
        //     No message body was found in the message
        EmptyMessage = 17,
        //
        // Summary:
        //     No subject was found in the message
        EmptySubject = 18,
        //
        // Summary:
        //     An invalid from address was found on the message
        InvalidFrom = 19,
        //
        // Summary:
        //     No To addresses were found in the message
        EmptyToAddress = 20,
        //
        // Summary:
        //     No valid message body was found in the message
        NoValidBodyParts = 21,
        //
        // Summary:
        //     An invalid TemplateId was found in the message
        InvalidTemplateId = 22,
        //
        // Summary:
        //     The specified TemplateId has no content for the message
        TemplateHasNoContent = 23,
        //
        // Summary:
        //     A conflict occurred on the message body of the message
        MessageBodyConflict = 24,
        //
        // Summary:
        //     Invalid MergeData was found on the message
        InvalidMergeData = 25,
        //
        // Summary:
        //     Authentication Error, Missing or invalid ServerId or ApiKey
        AuthenticationValidationFailed = 26,
        //
        // Summary:
        //     From email address is missing in the message
        EmailAddressValidationMissingFrom = 27,
        //
        // Summary:
        //     From email address in the message in invalid
        EmailAddressValidationInvalidFrom = 28,
        //
        // Summary:
        //     Message exceeded maximum recipient count in the message
        RecipientValidationMaxExceeded = 29,
        //
        // Summary:
        //     No recipients were found in the message
        RecipientValidationNoneInMessage = 30,
        //
        // Summary:
        //     To addresses are missing in the message
        RecipientValidationMissingTo = 31,
        //
        // Summary:
        //     Invalid ReplyTo address found
        RecipientValidationInvalidReplyTo = 32,
        //
        // Summary:
        //     Invalid recipients found
        RecipientValidationInvalidRecipients = 33,
        //
        // Summary:
        //     No subject was found in the message
        MessageValidationEmptySubject = 34,
        //
        // Summary:
        //     No message body was found in the message
        MessageValidationEmptyMessage = 35,
        //
        // Summary:
        //     Invalid custom headers found
        MessageValidationInvalidCustomHeaders = 36
    }
}
