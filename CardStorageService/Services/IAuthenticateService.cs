using CardStorageService.Models.Requests;
using NuGet.Protocol.Core.Types;

namespace CardStorageService.Services
{
    public interface IAuthenticateService
    {
        AuthenticationResponse Login(AuthenticationRequest authenticationRequest);

        public SessionInfo GetSessionInfo(string sessionToken);
    }
}
