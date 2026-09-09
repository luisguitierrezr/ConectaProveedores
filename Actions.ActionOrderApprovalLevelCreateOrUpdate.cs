namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderApprovalLevelCreateOrUpdate : VarsBag {
public EN_6b660d05e4c0025dff47119642875ca2EntityRecord inParamSource;
public long resCreateOrUpdateOrderApprovalLevel_outParamId = 0L;

public lcvOrderApprovalLevelCreateOrUpdate(EN_6b660d05e4c0025dff47119642875ca2EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderApprovalLevelCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoOrderApprovalLevelCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>OrderApprovalLevelCreateOrUpdate</code> that represents the Service Studio action
///  <code>OrderApprovalLevelCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionOrderApprovalLevelCreateOrUpdate(IRequestContext requestContext,EN_6b660d05e4c0025dff47119642875ca2EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoOrderApprovalLevelCreateOrUpdate result = new lcoOrderApprovalLevelCreateOrUpdate();
lcvOrderApprovalLevelCreateOrUpdate localVars = new lcvOrderApprovalLevelCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderApprovalLevelCreateOrUpdate", "384663c9-7ff1-482a-8ff4-0f27a8e4a5cf"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderApprovalLevelCreateOrUpdate", "384663c9-7ff1-482a-8ff4-0f27a8e4a5cf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateOrderApprovalLevel
localVars.resCreateOrUpdateOrderApprovalLevel_outParamId = await ExtendedActions.CreateOrUpdateOrderApprovalLevel(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_ff8382bb6fb6cc7d57ecda7bb499922f)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateOrderApprovalLevel.Id
result.outParamId=localVars.resCreateOrUpdateOrderApprovalLevel_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionOrderApprovalLevelCreateOrUpdate {



}


}
