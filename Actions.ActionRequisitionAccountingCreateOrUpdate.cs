namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionAccountingCreateOrUpdate : VarsBag {
public EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord inParamSource;
public long resCreateOrUpdateRequisitionAccounting_outParamId = 0L;

public lcvRequisitionAccountingCreateOrUpdate(EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoRequisitionAccountingCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoRequisitionAccountingCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>RequisitionAccountingCreateOrUpdate</code> that represents the Service Studio action
///  <code>RequisitionAccountingCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionRequisitionAccountingCreateOrUpdate(IRequestContext requestContext,EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoRequisitionAccountingCreateOrUpdate result = new lcoRequisitionAccountingCreateOrUpdate();
lcvRequisitionAccountingCreateOrUpdate localVars = new lcvRequisitionAccountingCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionAccountingCreateOrUpdate", "17a7bdb5-029c-47b9-bd0e-c32f46fac27c"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionAccountingCreateOrUpdate", "17a7bdb5-029c-47b9-bd0e-c32f46fac27c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateRequisitionAccounting
localVars.resCreateOrUpdateRequisitionAccounting_outParamId = await ExtendedActions.CreateOrUpdateRequisitionAccounting(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_5860726e4142bb2973b9ba88d317465f)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateRequisitionAccounting.Id
result.outParamId=localVars.resCreateOrUpdateRequisitionAccounting_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionRequisitionAccountingCreateOrUpdate {



}


}
