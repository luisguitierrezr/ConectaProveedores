namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionServiceCreateOrUpdate : VarsBag {
public EN_455768e63ed34ad2746f7c539b65e1caEntityRecord inParamSource;
public long resCreateOrUpdateRequisitionService_outParamId = 0L;

public lcvRequisitionServiceCreateOrUpdate(EN_455768e63ed34ad2746f7c539b65e1caEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoRequisitionServiceCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoRequisitionServiceCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>RequisitionServiceCreateOrUpdate</code> that represents the Service Studio action
///  <code>RequisitionServiceCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionRequisitionServiceCreateOrUpdate(IRequestContext requestContext,EN_455768e63ed34ad2746f7c539b65e1caEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoRequisitionServiceCreateOrUpdate result = new lcoRequisitionServiceCreateOrUpdate();
lcvRequisitionServiceCreateOrUpdate localVars = new lcvRequisitionServiceCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionServiceCreateOrUpdate", "86263f33-ccf1-49a7-98fd-df6176b1472e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionServiceCreateOrUpdate", "86263f33-ccf1-49a7-98fd-df6176b1472e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateRequisitionService
localVars.resCreateOrUpdateRequisitionService_outParamId = await ExtendedActions.CreateOrUpdateRequisitionService(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_04e7247757060d4016b43102119b0dd6)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateRequisitionService.Id
result.outParamId=localVars.resCreateOrUpdateRequisitionService_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionRequisitionServiceCreateOrUpdate {



}


}
