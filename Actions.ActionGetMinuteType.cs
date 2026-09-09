namespace ssConectaProveedores;

public partial class Actions {
public class lcoGetMinuteType : VarsBag {
public RL_a579a1a05eaaba551100ea61f4cb3f6b outParamList = new RL_a579a1a05eaaba551100ea61f4cb3f6b();

public lcoGetMinuteType() {
}
}
/// <summary>
/// Action <code>GetMinuteType</code> that represents the Service Studio action
///  <code>GetMinuteType</code> <p> Description: </p>
/// </summary>
public static async Task<RL_a579a1a05eaaba551100ea61f4cb3f6b> ActionGetMinuteType(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_a579a1a05eaaba551100ea61f4cb3f6b outParamList = default;
lcoGetMinuteType result = new lcoGetMinuteType();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetMinuteType", "1718c0fb-bc20-4860-be4e-628a3e049e50"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetMinuteType", "1718c0fb-bc20-4860-be4e-628a3e049e50", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ListClear
await ExtendedActions.ListClear(requestContext,result.outParamList,cancellationToken);

// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_714c559a98f1e1080cbf60de3228e843Structure(){ ssKey = 1, ssValue = "Estimación" },cancellationToken);

// ListAppend2
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_714c559a98f1e1080cbf60de3228e843Structure(){ ssKey = 2, ssValue = "Finiquito" },cancellationToken);

// ListAppend3
await ExtendedActions.ListAppend(requestContext,result.outParamList,new ST_714c559a98f1e1080cbf60de3228e843Structure(){ ssKey = 3, ssValue = "Pago al 100%" },cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
} // inner-finally
RETURN_STATEMENT:
return outParamList;
}

public static class FuncActionGetMinuteType {



}


}
