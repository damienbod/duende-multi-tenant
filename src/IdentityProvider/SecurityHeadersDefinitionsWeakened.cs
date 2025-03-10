﻿namespace IdentityProvider;

public static class SecurityHeadersDefinitionsWeakened
{
    private static HeaderPolicyCollection? policy;

    public static HeaderPolicyCollection GetHeaderPolicyCollection(bool isDev, string? idpHost,
            string shopClientUI, string adminClientUI)
    {
        ArgumentNullException.ThrowIfNull(idpHost);
        ArgumentNullException.ThrowIfNull(shopClientUI);
        ArgumentNullException.ThrowIfNull(adminClientUI);

        // Avoid building a new HeaderPolicyCollection on every request for performance reasons.
        // Where possible, cache and reuse HeaderPolicyCollection instances.
        if (policy != null) return policy;

        policy = new HeaderPolicyCollection()
            .AddFrameOptionsDeny()
            .AddContentTypeOptionsNoSniff()
            .AddReferrerPolicyStrictOriginWhenCrossOrigin()
            .AddCrossOriginOpenerPolicy(builder => builder.SameOrigin())
            .AddCrossOriginResourcePolicy(builder => builder.SameOrigin())
            .AddCrossOriginEmbedderPolicy(builder => builder.RequireCorp()) // remove for dev if using hot reload
            .AddContentSecurityPolicy(builder =>
            {
                builder.AddObjectSrc().None();
                builder.AddBlockAllMixedContent();
                builder.AddImgSrc().Self().From("data:");
                builder.AddFormAction()
                    .Self()
                    .From(idpHost)
                    .From(shopClientUI)
                    .From(adminClientUI);
                builder.AddFontSrc().Self();
                builder.AddBaseUri().Self();
                builder.AddFrameAncestors().None();

                //if (isDev)
                //{
                //    builder.AddStyleSrc().Self().UnsafeInline();
                //}
                //else
                //{
                //    builder.AddStyleSrc().WithNonce().UnsafeInline();
                //}

                builder.AddStyleSrc().Self().UnsafeInline();
                builder.AddScriptSrc().Self().UnsafeInline();
            })
            .RemoveServerHeader()
            .AddPermissionsPolicyWithDefaultSecureDirectives();

        if (!isDev)
        {
            // maxage = one year in seconds
            policy.AddStrictTransportSecurityMaxAgeIncludeSubDomains(maxAgeInSeconds: 60 * 60 * 24 * 365);
        }

        return policy;
    }
}
