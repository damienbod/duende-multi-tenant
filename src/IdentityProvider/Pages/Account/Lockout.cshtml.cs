﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityProvider.Pages.Account;

[AllowAnonymous]
public class LockoutModel : PageModel
{
    public void OnGet()
    {

    }
}
