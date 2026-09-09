// Proxy for reference eSpace with name Telcel_Theme and key gpauSdp7Pke8FawmcFOfKw
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RsseSpaceTelcel_Theme
/// </summary>
public partial class RsseSpaceTelcel_Theme {
private static readonly ActivitySource source = new("ssConectaProveedores.RsseSpaceTelcel_Theme");
   public static ObjectKey eSpaceId {
       get {
           return ObjectKey.Parse("252a30f8-30c1-4666-b801-d7a28c2b79b5");
       }
   }
public static async Task<bool> MssGetSettings2(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamEnableNotifications = default;
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("252a30f8-30c1-4666-b801-d7a28c2b79b5");
outParamEnableNotifications = await ssTelcel_Theme.Actions.ActionGetSettings(requestContext,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamEnableNotifications;
}



public class DefaultValues {
}
}
}
