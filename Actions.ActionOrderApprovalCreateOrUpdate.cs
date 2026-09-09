namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderApprovalCreateOrUpdate : VarsBag {
public EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord inParamSource;
public long resCreateOrUpdateOrderApproval_outParamId = 0L;

public lcvOrderApprovalCreateOrUpdate(EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderApprovalCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoOrderApprovalCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>OrderApprovalCreateOrUpdate</code> that represents the Service Studio action
///  <code>OrderApprovalCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionOrderApprovalCreateOrUpdate(IRequestContext requestContext,EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoOrderApprovalCreateOrUpdate result = new lcoOrderApprovalCreateOrUpdate();
lcvOrderApprovalCreateOrUpdate localVars = new lcvOrderApprovalCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderApprovalCreateOrUpdate", "393baa3b-1ab0-4b7f-be30-03077f8efb51"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderApprovalCreateOrUpdate", "393baa3b-1ab0-4b7f-be30-03077f8efb51", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateOrderApproval
localVars.resCreateOrUpdateOrderApproval_outParamId = await ExtendedActions.CreateOrUpdateOrderApproval(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_51831f8bbf408689b196be5dba3a91ea)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateOrderApproval.Id
result.outParamId=localVars.resCreateOrUpdateOrderApproval_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionOrderApprovalCreateOrUpdate {



}


}
