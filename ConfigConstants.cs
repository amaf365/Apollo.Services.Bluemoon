using System;

namespace Apollo.Services.Bluemoon
{
    public sealed class ConfigConstantsLocal : ConfigConstants
    {
        public override string SerialNumber { get { return "gatest"; } }

        public override string UserId { get { return "developer"; } }

        public override string Password { get { return "import"; } }
    }
}
