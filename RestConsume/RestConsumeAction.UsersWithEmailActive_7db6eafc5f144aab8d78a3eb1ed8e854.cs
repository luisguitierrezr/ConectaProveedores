using OutSystems.Application.RestConsume;

namespace ssConectaProveedores;

public static partial class CcNotifications {
    private static readonly Guid Key_588dd3e9ffc14591bd4e2f57e6c30828_7ea4ce4c8aca46f68b5a6cb34190f167 = Guid.Parse("7ea4ce4c-8aca-46f6-8b5a-6cb34190f167");
private static readonly Guid Key_588dd3e9ffc14591bd4e2f57e6c30828_6474665b3ce04220b19e90aaabf01332 = Guid.Parse("6474665b-3ce0-4220-b19e-90aaabf01332");

    
    /// <summary>
/// Action: UsersWithEmailActive
/// </summary>

public static async Task<ST_8509a484f6b6eac99c83feddd35d5004Structure> ActionUsersWithEmailActive(IRequestContext requestContext,ST_06cbd1286b150e2e79c91e9d1ed3d811Structure inParamusers,CancellationToken cancellationToken) {
ST_8509a484f6b6eac99c83feddd35d5004Structure outParamResponse = default;
outParamResponse = new ST_8509a484f6b6eac99c83feddd35d5004Structure();

var restService = ServiceLocator.GetService<IRestConsumeService>();
await restService.SendRequestAsync<UsersWithEmailActive_7db6eafc5f144aab8d78a3eb1ed8e854>(requestContext, key => {
if (key == Key_588dd3e9ffc14591bd4e2f57e6c30828_7ea4ce4c8aca46f68b5a6cb34190f167) {
return RestConsumeStructure_users2_06cbd1286b150e2e79c91e9d1ed3d811.FromStructure(inParamusers);
}
throw new Exception("Input key not found.");
}, restConsumeResult => {{
var responseHolder = default(RestConsumeStructure_APIOutput2_8509a484f6b6eac99c83feddd35d5004);
restConsumeResult.TryReadBodyParameter(ref responseHolder);
if (responseHolder != null) {
    outParamResponse = RestConsumeStructure_APIOutput2_8509a484f6b6eac99c83feddd35d5004.ToStructure(responseHolder);
}
}
}, cancellationToken);
return outParamResponse;
}
 
}