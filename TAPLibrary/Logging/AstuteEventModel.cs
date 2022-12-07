using System;
using System.Collections.Generic;
using System.Text;

namespace TAPLibrary.Logging
{
    public class AstuteEventModel
    {
        public int CompanyId { get; set; } = 0;

        public int PatientId { get; set; } = 0;
        public string Event { get; set; } = "";
        public string CallingNamespace { get; set; } = string.Empty;
        public string CallingProcudure { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;

    }
}
