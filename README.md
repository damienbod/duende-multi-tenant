# Duende IdentityServer multi-tenant, multi-client setups

[![.NET](https://github.com/damienbod/duende-multi-tenant/actions/workflows/dotnet.yml/badge.svg)](https://github.com/damienbod/duende-multi-tenant/actions/workflows/dotnet.yml)

[Multiple client sign-in customizations using Duende identity provider](https://damienbod.com/2025/02/03/multiple-client-sign-in-customizations-using-duende-identity-provider/)

The solution is setup using three different ASP.NET Core applications. In the example code, the “Admin” application has different federation authentication options compared to the “Shop” client authentication sign-in experience. The client ID from the authentication context is used to customize the look and feel, i.e. the styles, the layout and the options of the client are used to define which federation and authentication options are possible.

![Client customization](https://github.com/damienbod/duende-multi-tenant/blob/main/images/context.png)

[Customizing a single client sign-in using parameters in Duende IdentityServer](https://damienbod.com/2025/02/17/customizing-a-single-client-sign-in-using-parameters-in-duende-identityserver/)

The solution is setup using three different ASP.NET Core applications. In the example code, the "admin" application has different federation authentication options compared to the "shop" client authentication sign-in experience. The client ID from the authentication context is used to customize the look and feel, i.e. the styles, the layout and the options of the client are used to define which federation and authentication options are possible. The shop client can be further customized using authentication parameters sent in the OpenID Connect redirect.

![Client parameters customization](https://github.com/damienbod/duende-multi-tenant/blob/main/images/context-parameters.png)

## Database

```
Add-Migration "init_identity_new" 
```

```
Update-Database
```

## History 

- 2025-08-09 Updated packages
- 2025-05-02 Updated packages
- 2025-02-17 Updated packages, readme
- 2025-02-15 Updated packages
- 2025-02-09 Added client parameter customization
- 2025-01-31 Initial version

## Links

https://docs.duendesoftware.com/identityserver/v7

https://docs.duendesoftware.com/identityserver/v7/ui/federation/

https://learn.microsoft.com/en-us/aspnet/core/razor-pages
