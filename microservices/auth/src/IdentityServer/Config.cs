// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
                   new IdentityResource[]
                   {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                   };

        public static IEnumerable<ApiResource> ApiResources =>
         new List<ApiResource>
        {
            new ApiResource("FastJob"){ Scopes = { "FastJob.Frontend.Write", "FastJob.Frontend.Read" } },
        };


        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("FastJob.Frontend.Write","FastJob Frontend project write scope"),
                new ApiScope("FastJob.Frontend.Read","FastJob Frontend project read scope"),
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                // m2m client credentials flow client
                new Client
                {
                    ClientId = "FastJob.Frontend",
                    ClientName = "FastJob Frontend",

                    AllowedGrantTypes = GrantTypes.Code,
                    RequirePkce = true,
                    RequireClientSecret = false,
                
                    ClientSecrets = { new Secret("FastJob.Frontend".Sha256()) },
                    RedirectUris = {"https://localhost:5001/swagger/oauth2-redirect.html"},
                    AllowedCorsOrigins = {"https://localhost:5001"},
                    AllowedScopes = { "FastJob.Frontend.Write", "FastJob.Frontend.Read" }
                },
            };
    }
}