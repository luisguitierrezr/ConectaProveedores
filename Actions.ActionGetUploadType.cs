namespace ssConectaProveedores;

public partial class Actions {
public class lcoGetUploadType : VarsBag {
public RL_a579a1a05eaaba551100ea61f4cb3f6b outParamKeyvaluelist = new RL_a579a1a05eaaba551100ea61f4cb3f6b();

public lcoGetUploadType() {
}
}
/// <summary>
/// Action <code>GetUploadType</code> that represents the Service Studio action
///  <code>GetUploadType</code> <p> Description: </p>
/// </summary>
public static async Task<RL_a579a1a05eaaba551100ea61f4cb3f6b> ActionGetUploadType(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_a579a1a05eaaba551100ea61f4cb3f6b outParamKeyvaluelist = default;
lcoGetUploadType result = new lcoGetUploadType();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetUploadType", "d57f29de-4e41-4b0f-bfb8-a24af5d7f1b6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetUploadType", "d57f29de-4e41-4b0f-bfb8-a24af5d7f1b6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ListClear
await ExtendedActions.ListClear(requestContext,result.outParamKeyvaluelist,cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamKeyvaluelist,new ST_714c559a98f1e1080cbf60de3228e843Structure(){ ssKey = 1, ssValue = "Manual" },cancellationToken);

// ListAppend2
await ExtendedActions.ListAppend(requestContext,result.outParamKeyvaluelist,new ST_714c559a98f1e1080cbf60de3228e843Structure(){ ssKey = 2, ssValue = "Carga de API" },cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
outParamKeyvaluelist = result.outParamKeyvaluelist;
} // inner-finally
RETURN_STATEMENT:
return outParamKeyvaluelist;
}

public static class FuncActionGetUploadType {



}


}
