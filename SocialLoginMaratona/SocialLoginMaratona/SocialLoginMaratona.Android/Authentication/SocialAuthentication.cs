﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using SocialLoginMaratona.Authentication;
using SocialLoginMaratona.Droid.Authentication;
using SocialLoginMaratona.Helpers;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(SocialAuthentication))]
namespace SocialLoginMaratona.Droid.Authentication
{
    public class SocialAuthentication : IAuthentication
    {
        public async Task<MobileServiceUser> LoginAsync(MobileServiceClient client, MobileServiceAuthenticationProvider provider,
            IDictionary<string, string > paramameters = null)
        {
            try
            {
                var user = await client.LoginAsync(Forms.Context, provider);
                Settings.AuthToken = user?.MobileServiceAuthenticationToken ?? string.Empty;
                Settings.UserId = user?.UserId;

                return user;
            }catch(Exception ex)
            {
                throw;
            }
        }

        
    }
}