using System;

namespace Apollo.Services.Bluemoon
{
    public class ListFormsParams
    {
        public string SessionId { get; set; }

        public int? PropertyId { get; set; }

        public int? LeaseId { get; set; }

        public bool? ExcludeEsignatureRestrictedForms { get; set; }

    }
}
