using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ShopClientUI.Pages;

[AllowAnonymous]
public class SignedOutModel : PageModel
{
    public void OnGet()
    {
    }
}