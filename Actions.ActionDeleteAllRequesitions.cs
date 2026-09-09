namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>DeleteAllRequesitions</code> that represents the Service Studio action
///  <code>DeleteAllRequesitions</code> <p> Description: </p>
/// </summary>
public static async Task ActionDeleteAllRequesitions(IRequestContext requestContext,CancellationToken cancellationToken) {
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("DeleteAllRequesitions", "7be2b22b-f89d-4353-9b9d-8a1e9fe52892"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DeleteAllRequesitions", "7be2b22b-f89d-4353-9b9d-8a1e9fe52892", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// DeleteAllRequisition
await ExtendedActions.DeleteAllRequisition(requestContext,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionDeleteAllRequesitions {



}


}
