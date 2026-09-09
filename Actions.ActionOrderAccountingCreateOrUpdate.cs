namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderAccountingCreateOrUpdate : VarsBag {
public EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord inParamSource;
public long resCreateOrUpdateOrderAccounting_outParamId = 0L;

public lcvOrderAccountingCreateOrUpdate(EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderAccountingCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoOrderAccountingCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>OrderAccountingCreateOrUpdate</code> that represents the Service Studio action
///  <code>OrderAccountingCreateOrUpdate</code> <p> Description: Create Or Update OrderAccounting</p>
/// </summary>
public static async Task<long> ActionOrderAccountingCreateOrUpdate(IRequestContext requestContext,EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoOrderAccountingCreateOrUpdate result = new lcoOrderAccountingCreateOrUpdate();
lcvOrderAccountingCreateOrUpdate localVars = new lcvOrderAccountingCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderAccountingCreateOrUpdate", "b3e723b4-8d74-4ff8-ac2a-b40363093f24"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderAccountingCreateOrUpdate", "b3e723b4-8d74-4ff8-ac2a-b40363093f24", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateOrderAccounting
localVars.resCreateOrUpdateOrderAccounting_outParamId = await ExtendedActions.CreateOrUpdateOrderAccounting(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_2dc2cf38bcc16a8b338dc5ea9a5c6446)localVars.inParamSource)),cancellationToken);

// Id = CreateOrUpdateOrderAccounting.Id
result.outParamId=localVars.resCreateOrUpdateOrderAccounting_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionOrderAccountingCreateOrUpdate {



}


}
