namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionApprovalCreateOrUpdate : VarsBag {
public EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord inParamSource;
public long resCreateOrUpdateRequisitionApproval_outParamId = 0L;

public lcvRequisitionApprovalCreateOrUpdate(EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoRequisitionApprovalCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoRequisitionApprovalCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>RequisitionApprovalCreateOrUpdate</code> that represents the Service Studio action
///  <code>RequisitionApprovalCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionRequisitionApprovalCreateOrUpdate(IRequestContext requestContext,EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoRequisitionApprovalCreateOrUpdate result = new lcoRequisitionApprovalCreateOrUpdate();
lcvRequisitionApprovalCreateOrUpdate localVars = new lcvRequisitionApprovalCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionApprovalCreateOrUpdate", "b20d320a-bc7b-46fa-984e-0c662c1ca70e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionApprovalCreateOrUpdate", "b20d320a-bc7b-46fa-984e-0c662c1ca70e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateRequisitionApproval
localVars.resCreateOrUpdateRequisitionApproval_outParamId = await ExtendedActions.CreateOrUpdateRequisitionApproval(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_6d2bef4b7e32de4c7c78886eeff75224)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateRequisitionApproval.Id
result.outParamId=localVars.resCreateOrUpdateRequisitionApproval_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionRequisitionApprovalCreateOrUpdate {



}


}
