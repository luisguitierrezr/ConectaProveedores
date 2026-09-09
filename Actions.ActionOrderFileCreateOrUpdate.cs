namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderFileCreateOrUpdate : VarsBag {
public EN_096339be3ef098b3762e8897e3a1c095EntityRecord inParamSource;
public long resCreateOrUpdateOrderFile_outParamId = 0L;

public lcvOrderFileCreateOrUpdate(EN_096339be3ef098b3762e8897e3a1c095EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderFileCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoOrderFileCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>OrderFileCreateOrUpdate</code> that represents the Service Studio action
///  <code>OrderFileCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionOrderFileCreateOrUpdate(IRequestContext requestContext,EN_096339be3ef098b3762e8897e3a1c095EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoOrderFileCreateOrUpdate result = new lcoOrderFileCreateOrUpdate();
lcvOrderFileCreateOrUpdate localVars = new lcvOrderFileCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderFileCreateOrUpdate", "1523d89d-dcbd-4e69-a414-8df1731ef397"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderFileCreateOrUpdate", "1523d89d-dcbd-4e69-a414-8df1731ef397", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();

// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();
}

// CreateOrUpdateOrderFile
localVars.resCreateOrUpdateOrderFile_outParamId = await ExtendedActions.CreateOrUpdateOrderFile(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_a7394a353dc1b7f636aaced209e66116)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateOrderFile.Id
result.outParamId=localVars.resCreateOrUpdateOrderFile_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionOrderFileCreateOrUpdate {



}


}
