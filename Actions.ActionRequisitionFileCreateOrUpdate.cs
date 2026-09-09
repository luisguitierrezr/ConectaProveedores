namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionFileCreateOrUpdate : VarsBag {
public EN_4cce425e15647f937e21de4e52849889EntityRecord inParamSource;
public long resCreateOrUpdateRequisitionFile2_outParamId = 0L;

public lcvRequisitionFileCreateOrUpdate(EN_4cce425e15647f937e21de4e52849889EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoRequisitionFileCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoRequisitionFileCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>RequisitionFileCreateOrUpdate</code> that represents the Service Studio action
///  <code>RequisitionFileCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionRequisitionFileCreateOrUpdate(IRequestContext requestContext,EN_4cce425e15647f937e21de4e52849889EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoRequisitionFileCreateOrUpdate result = new lcoRequisitionFileCreateOrUpdate();
lcvRequisitionFileCreateOrUpdate localVars = new lcvRequisitionFileCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionFileCreateOrUpdate", "7e0ccccd-3c96-4403-bac8-9d34a26452ae"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionFileCreateOrUpdate", "7e0ccccd-3c96-4403-bac8-9d34a26452ae", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();

// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();
}

// CreateOrUpdateRequisitionFile2
localVars.resCreateOrUpdateRequisitionFile2_outParamId = await ExtendedActions.CreateOrUpdateRequisitionFile2(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_3e0fb635eefe948054fa75421546a901)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateRequisitionFile2.Id
result.outParamId=localVars.resCreateOrUpdateRequisitionFile2_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionRequisitionFileCreateOrUpdate {



}


}
