namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionCreateOrUpdate : VarsBag {
public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord inParamSource;
public long resCreateOrUpdateRequisition_outParamId = 0L;

public lcvRequisitionCreateOrUpdate(EN_98680591dcf3728e0877a90eb5e1e552EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoRequisitionCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoRequisitionCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>RequisitionCreateOrUpdate</code> that represents the Service Studio action
///  <code>RequisitionCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionRequisitionCreateOrUpdate(IRequestContext requestContext,EN_98680591dcf3728e0877a90eb5e1e552EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoRequisitionCreateOrUpdate result = new lcoRequisitionCreateOrUpdate();
lcvRequisitionCreateOrUpdate localVars = new lcvRequisitionCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionCreateOrUpdate", "4a44fcc1-ef0f-4ecf-a559-3be9aebe02d6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionCreateOrUpdate", "4a44fcc1-ef0f-4ecf-a559-3be9aebe02d6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();

// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();

// Source.ApplicantId = GetUserId
localVars.inParamSource.ssApplicantId = BuiltInFunction.GetUserId ();
} else {
// Source.UpdatedOn = CurrDateTime
localVars.inParamSource.ssUpdatedOn = BuiltInFunction.CurrDateTime ();

// Source.UpdatedBy = GetUserId
localVars.inParamSource.ssUpdatedBy = BuiltInFunction.GetUserId ();
}

// CreateOrUpdateRequisition
localVars.resCreateOrUpdateRequisition_outParamId = await ExtendedActions.CreateOrUpdateRequisition(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_bb81744faa58ae73e7cd8db74cb32155)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateRequisition.Id
result.outParamId=localVars.resCreateOrUpdateRequisition_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionRequisitionCreateOrUpdate {



}


}
