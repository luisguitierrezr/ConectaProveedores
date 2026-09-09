namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderRequestFileCommentCreateOrUpdate : VarsBag {
public EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord inParamSource;
public long resCreateOrUpdateOrderRequestFileComment_outParamId = 0L;

public lcvOrderRequestFileCommentCreateOrUpdate(EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderRequestFileCommentCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoOrderRequestFileCommentCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>OrderRequestFileCommentCreateOrUpdate</code> that represents the Service Studio action
///  <code>OrderRequestFileCommentCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionOrderRequestFileCommentCreateOrUpdate(IRequestContext requestContext,EN_4cb32cdf21d9078134019b8cfde83f76EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoOrderRequestFileCommentCreateOrUpdate result = new lcoOrderRequestFileCommentCreateOrUpdate();
lcvOrderRequestFileCommentCreateOrUpdate localVars = new lcvOrderRequestFileCommentCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderRequestFileCommentCreateOrUpdate", "d2b60a56-ec16-469c-9e90-d007d9cb1c35"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderRequestFileCommentCreateOrUpdate", "d2b60a56-ec16-469c-9e90-d007d9cb1c35", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();
}

// CreateOrUpdateOrderRequestFileComment
localVars.resCreateOrUpdateOrderRequestFileComment_outParamId = await ExtendedActions.CreateOrUpdateOrderRequestFileComment(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_003b51eef272cce91f55924f504b1b11)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateOrderRequestFileComment.Id
result.outParamId=localVars.resCreateOrUpdateOrderRequestFileComment_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionOrderRequestFileCommentCreateOrUpdate {



}


}
