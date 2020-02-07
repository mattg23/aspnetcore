using System.Net;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Xunit;

namespace Microsoft.AspNetCore.Components.WebAssembly.Authentication
{
    public class WebAssemblyAuthenticationServiceCollectionExtensionsTests
    {
        [Fact]
        public void CanResolve_AccessTokenProvider()
        {
            var builder = WebAssemblyHostBuilder.CreateDefault();
            builder.Services.AddApiAuthorization();
            var host = builder.Build();

            host.Services.GetRequiredService<IAccessTokenProvider>();
        }

        [Fact]
        public void CanResolve_IRemoteAuthenticationService()
        {
            var builder = WebAssemblyHostBuilder.CreateDefault();
            builder.Services.AddApiAuthorization();
            var host = builder.Build();

            host.Services.GetRequiredService<IRemoteAuthenticationService<RemoteAuthenticationState>>();
        }

        [Fact]
        public void CanCreate_DefaultAuthenticationManager()
        {
            var builder = WebAssemblyHostBuilder.CreateDefault();
            builder.Services.AddApiAuthorization();
            var host = builder.Build();

            var componentFactory = new ComponentFactory();
            componentFactory.InstantiateComponent(host.Services, typeof(AuthenticationManager<RemoteAuthenticationState>));
        }

        [Fact]
        public void ApiAuthorizationOptions_DefaultToConfigurationEndpoint()
        {
            var builder = WebAssemblyHostBuilder.CreateDefault();
            builder.Services.AddApiAuthorization();
            var host = builder.Build();

            var options = host.Services.GetRequiredService<IOptions<RemoteAuthenticationOptions<ApiAuthorizationProviderOptions>>>();

            Assert.Equal(
                "_configuration/Microsoft.AspNetCore.Components.WebAssembly.Authentication.Tests",
                options.Value.ProviderOptions.ConfigurationEndpoint);
        }

        [Fact]
        public void ApiAuthorizationOptions_ConfigurationDefaultsGetApplied()
        {
            var builder = WebAssemblyHostBuilder.CreateDefault();
            builder.Services.AddApiAuthorization();
            var host = builder.Build();

            var options = host.Services.GetRequiredService<IOptions<RemoteAuthenticationOptions<ApiAuthorizationProviderOptions>>>();

            var paths = options.Value.AuthenticationPaths;

            Assert.Equal("authentication/login", paths.LoginPath);
            Assert.Equal("authentication/login-callback", paths.LoginCallbackPath);
            Assert.Equal("authentication/login-failed", paths.LoginFailedPath);
            Assert.Equal("authentication/register", paths.RemoteRegisterPath);
            Assert.Equal("authentication/profile", paths.RemoteProfilePath);
            Assert.Equal("authentication/logout", paths.LogoutPath);
            Assert.Equal("authentication/logout-callback", paths.LogoutCallbackPath);
            Assert.Equal("authentication/logout-failed", paths.LoginFailedPath);
            Assert.Equal("authentication/logout-succeded", paths.LogoutSucceededPath);

            Assert.Equal(
                "_configuration/Microsoft.AspNetCore.Components.WebAssembly.Authentication.Tests",
                options.Value.ProviderOptions.ConfigurationEndpoint);
        }
    }
}
