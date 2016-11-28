using System;

namespace Apollo.Services.Bluemoon
{
    public class ListFieldsParams
    {
        public string SessionId { get; set; }

        public int? PropertyId { get; set; }

        public svcLease.FormShort[] StandardForms { get; set; }

        public svcLease.FormShort[] CustomForms { get; set; }
    }
}
