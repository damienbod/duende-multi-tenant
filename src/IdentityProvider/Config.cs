using Duende.IdentityServer.Models;

namespace IdentityProvider;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
    [
        new IdentityResources.OpenId(),
        new IdentityResources.Profile(),
    ];

    public static IEnumerable<ApiScope> ApiScopes =>
    [
        new ApiScope("shopclientscope"),
        new ApiScope("adminclientscope"),
    ];

    public static IEnumerable<Client> Clients(string shopClientUIUrl, string adminClientUIUrl) =>
    [
        // ShopClientUI application interactive client using code flow + pkce
        new Client
        {
            ClientId = "shop-client-ui",
            ClientSecrets = { new Secret("48C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

            AllowedGrantTypes = GrantTypes.Code,

            RedirectUris = { $"{shopClientUIUrl}/signin-oidc" },
            FrontChannelLogoutUri = $"{shopClientUIUrl}/signout-oidc",
            PostLogoutRedirectUris = { $"{shopClientUIUrl}/signout-callback-oidc" },

            AllowOfflineAccess = true,
            AllowedScopes = { "openid", "profile", "shopclientscope" }
        },
        // AdminClientUI application interactive client using code flow + pkce
        new Client
        {
            ClientId = "admin-client-ui",
            ClientSecrets = { new Secret("48C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

            AllowedGrantTypes = GrantTypes.Code,

            RedirectUris = { $"{adminClientUIUrl}/signin-oidc" },
            FrontChannelLogoutUri = $"{adminClientUIUrl}/signout-oidc",
            PostLogoutRedirectUris = { $"{adminClientUIUrl}/signout-callback-oidc" },

            AllowOfflineAccess = true,
            AllowedScopes = { "openid", "profile", "adminclientscope" },

            IdentityProviderRestrictions = ["AdminEntraID"]
        },
    ];
}
