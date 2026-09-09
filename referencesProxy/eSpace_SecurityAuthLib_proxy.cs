// Proxy for reference eSpace with name SecurityAuthLib and key Nn8Yuzk0wEOxd70PpAtqzw
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RsseSpaceSecurityAuthLib
/// </summary>
public partial class RsseSpaceSecurityAuthLib {
private static readonly ActivitySource source = new("ssConectaProveedores.RsseSpaceSecurityAuthLib");
   public static ObjectKey eSpaceId {
       get {
           return ObjectKey.Parse("97a6fd78-d48f-4c77-b46e-90d7213a849f");
       }
   }
public static async Task MssCreateUserSession(IRequestContext requestContext,CancellationToken cancellationToken) {
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("97a6fd78-d48f-4c77-b46e-90d7213a849f");
await ssSecurityAuthLib.Actions.ActionCreateUserSession(requestContext,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return;
}


public static async Task<bool> MssCheckUserSessionDONOTUSE(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamIsValidSession = default;
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("97a6fd78-d48f-4c77-b46e-90d7213a849f");
outParamIsValidSession = await ssSecurityAuthLib.Actions.ActionCheckUserSession(requestContext,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamIsValidSession;
}



public class DefaultValues {
}
}
}
