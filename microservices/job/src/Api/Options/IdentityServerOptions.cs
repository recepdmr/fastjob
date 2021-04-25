using System;
using System.Collections.Generic;

namespace Api.Options
{
    public class IdentityServerOptions
    {
        public Uri Host { get; set; }
        public string ResourceName { get; set; }
        public Dictionary<string, string> Scopes { get; set; }
        public string AuthorizationPath { get; set; }
        public string TokenPath { get; set; }
        public string ClientId { get; set; }

    }
}
