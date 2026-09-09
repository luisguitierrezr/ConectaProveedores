namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderRequestFileCreateOrUpdate : VarsBag {
public EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord inParamSource;
public long resCreateOrUpdateOrderRequestFile_outParamId = 0L;

public lcvOrderRequestFileCreateOrUpdate(EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderRequestFileCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoOrderRequestFileCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>OrderRequestFileCreateOrUpdate</code> that represents the Service Studio action
///  <code>OrderRequestFileCreateOrUpdate</code> <p> Description: Create Or Update OrderRequestFile</p>
/// </summary>
public static async Task<long> ActionOrderRequestFileCreateOrUpdate(IRequestContext requestContext,EN_e4c3d4adf857b2c10b2425b3cc0babe3EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoOrderRequestFileCreateOrUpdate result = new lcoOrderRequestFileCreateOrUpdate();
lcvOrderRequestFileCreateOrUpdate localVars = new lcvOrderRequestFileCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderRequestFileCreateOrUpdate", "8915d306-2a57-4587-89bc-fbc86a4834e6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderRequestFileCreateOrUpdate", "8915d306-2a57-4587-89bc-fbc86a4834e6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();

// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();
} else {
// Set basic audit attributes
// Source.UpdatedBy = GetUserId
localVars.inParamSource.ssUpdatedBy = BuiltInFunction.GetUserId ();

// Source.UpdatedOn = CurrDateTime
localVars.inParamSource.ssUpdatedOn = BuiltInFunction.CurrDateTime ();
}

// CreateOrUpdateOrderRequestFile
localVars.resCreateOrUpdateOrderRequestFile_outParamId = await ExtendedActions.CreateOrUpdateOrderRequestFile(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_73d8126c722e2b4dd662dab2bf1a72d1)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateOrderRequestFile.Id
result.outParamId=localVars.resCreateOrUpdateOrderRequestFile_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionOrderRequestFileCreateOrUpdate {



}


}
