namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionAccConceptsCreateOrUpdate : VarsBag {
public EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord inParamSource;
public long resCreateOrUpdateRequisitionAccConcepts_outParamId = 0L;

public lcvRequisitionAccConceptsCreateOrUpdate(EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoRequisitionAccConceptsCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoRequisitionAccConceptsCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>RequisitionAccConceptsCreateOrUpdate</code> that represents the Service Studio action
///  <code>RequisitionAccConceptsCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionRequisitionAccConceptsCreateOrUpdate(IRequestContext requestContext,EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoRequisitionAccConceptsCreateOrUpdate result = new lcoRequisitionAccConceptsCreateOrUpdate();
lcvRequisitionAccConceptsCreateOrUpdate localVars = new lcvRequisitionAccConceptsCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionAccConceptsCreateOrUpdate", "98065a6c-779e-4d18-82f4-75f8e317ee39"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionAccConceptsCreateOrUpdate", "98065a6c-779e-4d18-82f4-75f8e317ee39", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// CreateOrUpdateRequisitionAccConcepts
localVars.resCreateOrUpdateRequisitionAccConcepts_outParamId = await ExtendedActions.CreateOrUpdateRequisitionAccConcepts(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_e33b49261cecfe02249fd0f5f57f5dbc)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateRequisitionAccConcepts.Id
result.outParamId=localVars.resCreateOrUpdateRequisitionAccConcepts_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionRequisitionAccConceptsCreateOrUpdate {



}


}
