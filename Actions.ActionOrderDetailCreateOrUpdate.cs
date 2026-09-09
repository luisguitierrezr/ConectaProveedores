namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderDetailCreateOrUpdate : VarsBag {
public EN_26f696e758428762fc617e811634d15dEntityRecord inParamSource;
public long resCreateOrUpdateOrderDetail_outParamId = 0L;

public lcvOrderDetailCreateOrUpdate(EN_26f696e758428762fc617e811634d15dEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderDetailCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public bool outParamHasSuccess = true;

public string outParamErrorMessage = "";

public lcoOrderDetailCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>OrderDetailCreateOrUpdate</code> that represents the Service Studio action
///  <code>OrderDetailCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<(long,bool,string)> ActionOrderDetailCreateOrUpdate(IRequestContext requestContext,EN_26f696e758428762fc617e811634d15dEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
bool outParamHasSuccess = default;
string outParamErrorMessage = default;
lcoOrderDetailCreateOrUpdate result = new lcoOrderDetailCreateOrUpdate();
lcvOrderDetailCreateOrUpdate localVars = new lcvOrderDetailCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderDetailCreateOrUpdate", "95d81e58-42c5-4658-9a6b-9c0d7f41f3ca"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderDetailCreateOrUpdate", "95d81e58-42c5-4658-9a6b-9c0d7f41f3ca", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// New record?
if(((localVars.inParamSource.ssOrderId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Audit
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();

// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();
}

// Source.UpdatedBy = GetUserId
localVars.inParamSource.ssUpdatedBy = BuiltInFunction.GetUserId ();

// Source.UpdatedOn = CurrDateTime
localVars.inParamSource.ssUpdatedOn = BuiltInFunction.CurrDateTime ();
// CreateOrUpdateOrderDetail
localVars.resCreateOrUpdateOrderDetail_outParamId = await ExtendedActions.CreateOrUpdateOrderDetail(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_7f0ffeffec7d0864eb8855fe8e873743)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateOrderDetail.Id
result.outParamId=localVars.resCreateOrUpdateOrderDetail_outParamId;
} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// Id = Source.OrderId
result.outParamId=localVars.inParamSource.ssOrderId;

// HasSuccess = False
result.outParamHasSuccess=false;

// ErrorMessage = AllExceptions.ExceptionMessage
result.outParamErrorMessage=ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamId = result.outParamId;
outParamHasSuccess = result.outParamHasSuccess;
outParamErrorMessage = result.outParamErrorMessage;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamId,outParamHasSuccess,outParamErrorMessage);
}

public static class FuncActionOrderDetailCreateOrUpdate {



}


}
