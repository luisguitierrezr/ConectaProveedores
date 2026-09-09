namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderRequestFileApprovalLevelCreateOrUpdate : VarsBag {
public EN_80af67ecab8f43d464cc57955285a024EntityRecord inParamSource;
public long resCreateOrUpdateOrderRequestFileApprovalLevel_outParamId = 0L;

public lcvOrderRequestFileApprovalLevelCreateOrUpdate(EN_80af67ecab8f43d464cc57955285a024EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderRequestFileApprovalLevelCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoOrderRequestFileApprovalLevelCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>OrderRequestFileApprovalLevelCreateOrUpdate</code> that represents the Service Studio
///  action <code>OrderRequestFileApprovalLevelCreateOrUpdate</code> <p> Description: Encapsulates th
/// e CreateOrUpdate entity action, enabling logic to run consistently before and after a record is
///  created or modified.</p>
/// </summary>
public static async Task<long> ActionOrderRequestFileApprovalLevelCreateOrUpdate(IRequestContext requestContext,EN_80af67ecab8f43d464cc57955285a024EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoOrderRequestFileApprovalLevelCreateOrUpdate result = new lcoOrderRequestFileApprovalLevelCreateOrUpdate();
lcvOrderRequestFileApprovalLevelCreateOrUpdate localVars = new lcvOrderRequestFileApprovalLevelCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderRequestFileApprovalLevelCreateOrUpdate", "23a324f6-a565-4b05-9e5f-05fc71cf59f2"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderRequestFileApprovalLevelCreateOrUpdate", "23a324f6-a565-4b05-9e5f-05fc71cf59f2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateOrderRequestFileApprovalLevel
localVars.resCreateOrUpdateOrderRequestFileApprovalLevel_outParamId = await ExtendedActions.CreateOrUpdateOrderRequestFileApprovalLevel(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_daa6040aa65b55c2574e6a4e976766ce)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateOrderRequestFileApprovalLevel.Id
result.outParamId=localVars.resCreateOrUpdateOrderRequestFileApprovalLevel_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionOrderRequestFileApprovalLevelCreateOrUpdate {



}


}
