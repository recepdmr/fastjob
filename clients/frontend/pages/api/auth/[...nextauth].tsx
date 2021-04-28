import NextAuth from 'next-auth'
import Providers from 'next-auth/providers'

export default NextAuth({
    providers: [
        Providers.IdentityServer4({
            id: "identity-server4",
            name: "IdentityServer4",
            scope: "openid profile email api offline_access",
            domain: "demo.identityserver.io",
            clientId: "interactive.public",
            clientSecret: "secret",
        })
    ]
});