# Duende IdentityServer multi-tenant, multi-client setups

[![.NET](https://github.com/damienbod/duende-multi-tenant/actions/workflows/dotnet.yml/badge.svg)](https://github.com/damienbod/duende-multi-tenant/actions/workflows/dotnet.yml)

[Multiple client sign-in customizations using Duende identity provider](https://damienbod.com/2025/02/03/multiple-client-sign-in-customizations-using-duende-identity-provider/)

![Client customization](https://github.com/damienbod/duende-multi-tenant/blob/main/images/context.png)

[Customizing a single client sign-in using parameters in Duende IdentityServer](https://damienbod.com)

![Client parameters customization](https://github.com/damienbod/duende-multi-tenant/blob/main/images/context-parameters.png)

## Database

```
Add-Migration "init_identity_new" 
```

```
Update-Database
```

## History 

- 2025-02-09 Added client parameter customization
- 2025-01-31 Initial version

## Links

https://docs.duendesoftware.com/identityserver/v7

https://docs.duendesoftware.com/identityserver/v7/ui/federation/

https://learn.microsoft.com/en-us/aspnet/core/razor-pages
