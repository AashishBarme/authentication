// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication;
namespace Authentication.Pages.Claims
{
    public class ClaimModel : PageModel
    {
       
        private readonly ILogger<ClaimModel> _logger;
        public AuthenticateResult ClaimsData {get; set;}
        public ClaimModel(ILogger<ClaimModel> logger)
        {
            _logger = logger;
        }
        public async Task OnGetAsync()
        {
            ClaimsData = await HttpContext.AuthenticateAsync();
            System.Console.WriteLine(ClaimsData);
        }


    }
}
