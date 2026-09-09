namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceCommentCreateOrUpdate : VarsBag {
public EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord inParamSource;
public long resCreateOrUpdateInvoiceComment_outParamId = 0L;

public lcvInvoiceCommentCreateOrUpdate(EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoInvoiceCommentCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoInvoiceCommentCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>InvoiceCommentCreateOrUpdate</code> that represents the Service Studio action
///  <code>InvoiceCommentCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionInvoiceCommentCreateOrUpdate(IRequestContext requestContext,EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoInvoiceCommentCreateOrUpdate result = new lcoInvoiceCommentCreateOrUpdate();
lcvInvoiceCommentCreateOrUpdate localVars = new lcvInvoiceCommentCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceCommentCreateOrUpdate", "74104503-b08d-4f0c-bd6d-a4475dde18f5"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceCommentCreateOrUpdate", "74104503-b08d-4f0c-bd6d-a4475dde18f5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Is new record?
if(((localVars.inParamSource.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Set basic audit attributes
// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();

// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();
}

// CreateOrUpdateInvoiceComment
localVars.resCreateOrUpdateInvoiceComment_outParamId = await ExtendedActions.CreateOrUpdateInvoiceComment(requestContext,localVars.inParamSource.ChangedAttributes,(((RC_85ff0b93155717e6346b97d39d3b0222)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrUpdateInvoiceComment.Id
result.outParamId=localVars.resCreateOrUpdateInvoiceComment_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionInvoiceCommentCreateOrUpdate {



}


}
