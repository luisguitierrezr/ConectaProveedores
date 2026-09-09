namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionCostCenterCreateOrUpdate : VarsBag {
public EN_114fcf95674648310a3efb0d78529a37EntityRecord inParamSource;
public long resCreateOrUpdateRequisitionCostCenter_outParamId = 0L;

public lcvRequisitionCostCenterCreateOrUpdate(EN_114fcf95674648310a3efb0d78529a37EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoRequisitionCostCenterCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoRequisitionCostCenterCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>RequisitionCostCenterCreateOrUpdate</code> that represents the Service Studio action
///  <code>RequisitionCostCenterCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionRequisitionCostCenterCreateOrUpdate(IRequestContext requestContext,EN_114fcf95674648310a3efb0d78529a37EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoRequisitionCostCenterCreateOrUpdate result = new lcoRequisitionCostCenterCreateOrUpdate();
lcvRequisitionCostCenterCreateOrUpdate localVars = new lcvRequisitionCostCenterCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionCostCenterCreateOrUpdate", "8c8107b8-6469-4136-8d2e-993d82c7c47e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionCostCenterCreateOrUpdate", "8c8107b8-6469-4136-8d2e-993d82c7c47e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateRequisitionCostCenter
localVars.resCreateOrUpdateRequisitionCostCenter_outParamId = await ExtendedActions.CreateOrUpdateRequisitionCostCenter(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_508355980a3676af946819914b6b1546)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateRequisitionCostCenter.Id
result.outParamId=localVars.resCreateOrUpdateRequisitionCostCenter_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionRequisitionCostCenterCreateOrUpdate {



}


}
