namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderRequestFileApprovalCreateOrUpdate : VarsBag {
public EN_1710c672f4d7138b664ee1411114271eEntityRecord inParamSource;
public long resCreateOrUpdateOrderRequestFileApproval_outParamId = 0L;

public lcvOrderRequestFileApprovalCreateOrUpdate(EN_1710c672f4d7138b664ee1411114271eEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderRequestFileApprovalCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoOrderRequestFileApprovalCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>OrderRequestFileApprovalCreateOrUpdate</code> that represents the Service Studio
///  action <code>OrderRequestFileApprovalCreateOrUpdate</code> <p> Description: Encapsulates th
/// e CreateOrUpdate entity action, enabling logic to run consistently before and after a record is
///  created or modified.</p>
/// </summary>
public static async Task<long> ActionOrderRequestFileApprovalCreateOrUpdate(IRequestContext requestContext,EN_1710c672f4d7138b664ee1411114271eEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoOrderRequestFileApprovalCreateOrUpdate result = new lcoOrderRequestFileApprovalCreateOrUpdate();
lcvOrderRequestFileApprovalCreateOrUpdate localVars = new lcvOrderRequestFileApprovalCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderRequestFileApprovalCreateOrUpdate", "6e156088-bc49-4c6d-b041-2270d93d78ce"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderRequestFileApprovalCreateOrUpdate", "6e156088-bc49-4c6d-b041-2270d93d78ce", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateOrderRequestFileApproval
localVars.resCreateOrUpdateOrderRequestFileApproval_outParamId = await ExtendedActions.CreateOrUpdateOrderRequestFileApproval(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_64c70b8a3f72d1283f18a3da8f8eb3d5)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateOrderRequestFileApproval.Id
result.outParamId=localVars.resCreateOrUpdateOrderRequestFileApproval_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionOrderRequestFileApprovalCreateOrUpdate {



}


}
