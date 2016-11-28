using System;

namespace Apollo.Services.Bluemoon
{
    public abstract class ConfigConstants 
    {
        public static readonly ConfigConstantsLocal Instance = new ConfigConstantsLocal();

        public abstract string SerialNumber { get; }

        public abstract string UserId { get; }

        public abstract string Password { get; }
    }
}
