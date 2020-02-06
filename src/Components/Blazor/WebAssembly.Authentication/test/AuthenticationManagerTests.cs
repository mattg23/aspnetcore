using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.AspNetCore.Components.WebAssembly.Authentication
{
    public class AuthenticationManagerTests
    {
        private const string _action = nameof(AuthenticationManager<RemoteAuthenticationState>.Action);

        [Fact]
        public async Task AuthenticationManager_Throws_ForInvalidAction()
        {
            var manager = new AuthenticationManager<RemoteAuthenticationState>();

            var parameters = ParameterView.FromDictionary(new Dictionary<string, object>
            {
                [_action] = ""
            });

            await Assert.ThrowsAsync<InvalidOperationException>(() => manager.SetParametersAsync(parameters));
        }
    }
}
