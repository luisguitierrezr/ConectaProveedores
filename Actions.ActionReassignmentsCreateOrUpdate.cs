namespace ssConectaProveedores;

public partial class Actions {
public class lcvReassignmentsCreateOrUpdate : VarsBag {
public EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord inParamSource;
public long resCreateOrUpdateReassignments_outParamId = 0L;

public lcvReassignmentsCreateOrUpdate(EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoReassignmentsCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoReassignmentsCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ReassignmentsCreateOrUpdate</code> that represents the Service Studio action
///  <code>ReassignmentsCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionReassignmentsCreateOrUpdate(IRequestContext requestContext,EN_e8f034a972f4cc8fe1bc134211323cc1EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoReassignmentsCreateOrUpdate result = new lcoReassignmentsCreateOrUpdate();
lcvReassignmentsCreateOrUpdate localVars = new lcvReassignmentsCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ReassignmentsCreateOrUpdate", "584400c9-c421-4581-a518-5386de058c5e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ReassignmentsCreateOrUpdate", "584400c9-c421-4581-a518-5386de058c5e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();

// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();
}

// CreateOrUpdateReassignments
localVars.resCreateOrUpdateReassignments_outParamId = await ExtendedActions.CreateOrUpdateReassignments(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_c9394e1c31772209550f46c7f600d6ee)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateReassignments.Id
result.outParamId=localVars.resCreateOrUpdateReassignments_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionReassignmentsCreateOrUpdate {



}


}
