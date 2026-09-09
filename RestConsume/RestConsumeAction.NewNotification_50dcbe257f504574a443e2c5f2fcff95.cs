using OutSystems.Application.RestConsume;

namespace ssConectaProveedores;

public static partial class CcNotifications {
    private static readonly Guid Key_588dd3e9ffc14591bd4e2f57e6c30828_55629202993f407bacea504793de60e8 = Guid.Parse("55629202-993f-407b-acea-504793de60e8");
private static readonly Guid Key_588dd3e9ffc14591bd4e2f57e6c30828_43a3156fbe7a435da87605a9b5785420 = Guid.Parse("43a3156f-be7a-435d-a876-05a9b5785420");

    
    /// <summary>
/// Action: NewNotification
/// </summary>

public static async Task<ST_8509a484f6b6eac99c83feddd35d5004Structure> ActionNewNotification(IRequestContext requestContext,ST_f2b86c6e9a171aacffc6ca49bb5b5aafStructure inParamnotificationinfo,CancellationToken cancellationToken) {
ST_8509a484f6b6eac99c83feddd35d5004Structure outParamResponse = default;
outParamResponse = new ST_8509a484f6b6eac99c83feddd35d5004Structure();

var restService = ServiceLocator.GetService<IRestConsumeService>();
await restService.SendRequestAsync<NewNotification_50dcbe257f504574a443e2c5f2fcff95>(requestContext, key => {
if (key == Key_588dd3e9ffc14591bd4e2f57e6c30828_55629202993f407bacea504793de60e8) {
return RestConsumeStructure_NewNotification2_f2b86c6e9a171aacffc6ca49bb5b5aaf.FromStructure(inParamnotificationinfo);
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