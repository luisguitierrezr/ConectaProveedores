namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderApprovalCreate : VarsBag {
public EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord inParamSource;
public long resCreateOrderApproval_outParamId = 0L;

public lcvOrderApprovalCreate(EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderApprovalCreate : VarsBag {
public long outParamId = 0L;

public lcoOrderApprovalCreate() {
}
}
/// <summary>
/// Action <code>OrderApprovalCreate</code> that represents the Service Studio action
///  <code>OrderApprovalCreate</code> <p> Description: Encapsulates the Create entity action, enablin
/// g logic to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<long> ActionOrderApprovalCreate(IRequestContext requestContext,EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoOrderApprovalCreate result = new lcoOrderApprovalCreate();
lcvOrderApprovalCreate localVars = new lcvOrderApprovalCreate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderApprovalCreate", "cb7d5019-cc62-4c88-9c23-d481d004c8f1"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderApprovalCreate", "cb7d5019-cc62-4c88-9c23-d481d004c8f1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrderApproval
localVars.resCreateOrderApproval_outParamId = await ExtendedActions.CreateOrderApproval(requestContext,(((RC_51831f8bbf408689b196be5dba3a91ea)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrderApproval.Id
result.outParamId=localVars.resCreateOrderApproval_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionOrderApprovalCreate {



}


}
