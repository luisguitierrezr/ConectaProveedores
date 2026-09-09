namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderCommentCreateOrUpdate : VarsBag {
public EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord inParamSource;
public long resCreateOrUpdateOrderComment_outParamId = 0L;

public lcvOrderCommentCreateOrUpdate(EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderCommentCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoOrderCommentCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>OrderCommentCreateOrUpdate</code> that represents the Service Studio action
///  <code>OrderCommentCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionOrderCommentCreateOrUpdate(IRequestContext requestContext,EN_294738e57a3a5c4ae9c7f2034713ca42EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoOrderCommentCreateOrUpdate result = new lcoOrderCommentCreateOrUpdate();
lcvOrderCommentCreateOrUpdate localVars = new lcvOrderCommentCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderCommentCreateOrUpdate", "8ad1799f-cb01-4725-91c5-d8878b0ced42"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderCommentCreateOrUpdate", "8ad1799f-cb01-4725-91c5-d8878b0ced42", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();
}

// CreateOrUpdateOrderComment
localVars.resCreateOrUpdateOrderComment_outParamId = await ExtendedActions.CreateOrUpdateOrderComment(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_cd61721ee82121e78e4055ba4deb1fa6)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateOrderComment.Id
result.outParamId=localVars.resCreateOrUpdateOrderComment_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionOrderCommentCreateOrUpdate {



}


}
