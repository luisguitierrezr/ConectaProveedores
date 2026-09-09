namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionCommentCreateOrUpdate : VarsBag {
public EN_cbeb601b681344342c8de0161d058f87EntityRecord inParamSource;
public long resCreateOrUpdateRequisitionComment_outParamId = 0L;

public lcvRequisitionCommentCreateOrUpdate(EN_cbeb601b681344342c8de0161d058f87EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoRequisitionCommentCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoRequisitionCommentCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>RequisitionCommentCreateOrUpdate</code> that represents the Service Studio action
///  <code>RequisitionCommentCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ActionRequisitionCommentCreateOrUpdate(IRequestContext requestContext,EN_cbeb601b681344342c8de0161d058f87EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoRequisitionCommentCreateOrUpdate result = new lcoRequisitionCommentCreateOrUpdate();
lcvRequisitionCommentCreateOrUpdate localVars = new lcvRequisitionCommentCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionCommentCreateOrUpdate", "fd572e78-d685-4da3-bf5a-b213d646a266"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionCommentCreateOrUpdate", "fd572e78-d685-4da3-bf5a-b213d646a266", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();
}

// CreateOrUpdateRequisitionComment
localVars.resCreateOrUpdateRequisitionComment_outParamId = await ExtendedActions.CreateOrUpdateRequisitionComment(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_08daffa670c72e7502779e59a7b292d3)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateRequisitionComment.Id
result.outParamId=localVars.resCreateOrUpdateRequisitionComment_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionRequisitionCommentCreateOrUpdate {



}


}
