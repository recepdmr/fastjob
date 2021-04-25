// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using IdentityModel;
using IdentityServer.Data;
using IdentityServer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer
{
    public class SeedData
    {
        public SeedData(ApplicationDbContext context, UserManager<ApplicationUser> userMgr)
        {
            DbContext = context;
            UserManager = userMgr;
        }

        private ApplicationDbContext DbContext { get; }
        private UserManager<ApplicationUser> UserManager { get; }

        public async Task SeedDataAsync()
        {
            await DbContext.Database.MigrateAsync();

            var recepdmr = await UserManager.FindByNameAsync("recepdmr");
            if (recepdmr == null)
            {
                recepdmr = new ApplicationUser
                {
                    UserName = "recepdmr",
                    Email = "recepdemir3438@gmail.com",
                    EmailConfirmed = true,
                };
                var result = await UserManager.CreateAsync(recepdmr, "Pass123$");
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }

                result = await UserManager.AddClaimsAsync(recepdmr, new Claim[]{
                            new Claim(JwtClaimTypes.Name, "Recep Demir"),
                            new Claim(JwtClaimTypes.GivenName, "Recep"),
                            new Claim(JwtClaimTypes.FamilyName, "Demir"),
                            new Claim(JwtClaimTypes.WebSite, "https://recepdmr.com"),
                        });
                if (!result.Succeeded)
                {
                    throw new Exception(result.Errors.First().Description);
                }
                Log.Debug("recepdmr created");
            }
            else
            {
                Log.Debug("recepdmr already exists");
            }
        }
    }
}
