// Proxy for reference eSpace with name GetIP and key eoAc0hcoW0KDBqudKdN4Tw
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RsseSpaceGetIP
/// </summary>
public partial class RsseSpaceGetIP {
private static readonly ActivitySource source = new("ssConectaProveedores.RsseSpaceGetIP");
   public static ObjectKey eSpaceId {
       get {
           return ObjectKey.Parse("89c28a1d-fe69-4c2b-8b83-4fcec0f541e1");
       }
   }
public static async Task<(string,string)> MssGetIP(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamClientIP = default;
string outParamAdditionalIP = default;
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("89c28a1d-fe69-4c2b-8b83-4fcec0f541e1");
(outParamClientIP,outParamAdditionalIP) = await ssGetIP.Actions.ActionGetIP(requestContext,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return (outParamClientIP,outParamAdditionalIP);
}



public class DefaultValues {
}
}
}
