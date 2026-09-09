using System.Collections.ObjectModel;
using OutSystems.RESTService.Runtime.Core;
using OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions;

using ssConectaProveedores.ReferencesProxy;

namespace ssConectaProveedores {
    public partial class RsseSpaceCommon {
        public class CommonServiceAPIClients : AbstractServiceApiClient {
            private static readonly CommonServiceAPIClients Instance = new();
            private CommonServiceAPIClients() : base(
                ObjectKey.Parse("4067e3bf-602b-47d4-ac39-3fb42a4cfde1"),
                "Common",
                "ssConectaProveedores.CommonServiceAPIClients",
                ReadOnlyDictionary<string, Func<string, Exception>>.Empty
            ) { }

            public class S4PIServiceGetUploadContractDateLimitInput {
public S4PIServiceGetUploadContractDateLimitInput() {
}

}

public class S4PIServiceGetUploadContractDateLimitOutput {
[JsonProperty("o_Value")]
public int outParamo_Value;
public S4PIServiceGetUploadContractDateLimitOutput(int outParamo_Value) {
this.outParamo_Value = outParamo_Value;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceGetUploadContractDateLimit
/// </summary>
public static async Task<int> ServiceGetUploadContractDateLimit(IRequestContext requestContext,CancellationToken cancellationToken) {
int outParamo_Value = default;
outParamo_Value = 0;

var serviceActionName = "ServiceGetUploadContractDateLimit";
var serviceActionKey = "9eaeeee2-f026-4718-9d7e-537a683ed51f";
var inputs = new S4PIServiceGetUploadContractDateLimitInput();
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceGetUploadContractDateLimitInput, S4PIServiceGetUploadContractDateLimitOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamo_Value = outputs.outParamo_Value;
await Task.Yield();

return outParamo_Value;
}

        }
    }
}
