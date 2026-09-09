namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioCommentCreateOrUpdate : VarsBag {
public EN_a75639301080da49357fc03810b8d65fEntityRecord inParamSource;
public long resCreateOrUpdateFolioComment_outParamId = 0L;

public lcvFolioCommentCreateOrUpdate(EN_a75639301080da49357fc03810b8d65fEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoFolioCommentCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoFolioCommentCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>FolioCommentCreateOrUpdate</code> that represents the Service Studio action
///  <code>FolioCommentCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionFolioCommentCreateOrUpdate(IRequestContext requestContext,EN_a75639301080da49357fc03810b8d65fEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoFolioCommentCreateOrUpdate result = new lcoFolioCommentCreateOrUpdate();
lcvFolioCommentCreateOrUpdate localVars = new lcvFolioCommentCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioCommentCreateOrUpdate", "9237d994-8474-4dd6-8338-35cbf8c6b0ab"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioCommentCreateOrUpdate", "9237d994-8474-4dd6-8338-35cbf8c6b0ab", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();

// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();
}

// CreateOrUpdateFolioComment
localVars.resCreateOrUpdateFolioComment_outParamId = await ExtendedActions.CreateOrUpdateFolioComment(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_bd4c69fd286a3fa1bae388a3d68ac007)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateFolioComment.Id
result.outParamId=localVars.resCreateOrUpdateFolioComment_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionFolioCommentCreateOrUpdate {



}


}
