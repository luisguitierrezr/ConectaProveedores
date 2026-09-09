namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceCommentBulk : VarsBag {
public RL_12444f18cbf938e5a637c66b266df871 inParami_InvoiceList;
public string inParami_Comment;
public string inParami_GetUserId;
public Actions.lcoInvoiceCommentCreateOrUpdate resInvoiceCommentCreateOrUpdate =  new Actions.lcoInvoiceCommentCreateOrUpdate();
public lcvInvoiceCommentBulk(RL_12444f18cbf938e5a637c66b266df871 inParami_InvoiceList, string inParami_Comment, string inParami_GetUserId) {
this.inParami_InvoiceList = inParami_InvoiceList;
this.inParami_Comment = inParami_Comment;
this.inParami_GetUserId = inParami_GetUserId;
}
}
/// <summary>
/// Action <code>InvoiceCommentBulk</code> that represents the Service Studio action
///  <code>InvoiceCommentBulk</code> <p> Description: </p>
/// </summary>
public static async Task ActionInvoiceCommentBulk(IRequestContext requestContext,RL_12444f18cbf938e5a637c66b266df871 inParami_InvoiceList,string inParami_Comment,string inParami_GetUserId,CancellationToken cancellationToken) {
lcvInvoiceCommentBulk localVars = new lcvInvoiceCommentBulk(inParami_InvoiceList, inParami_Comment, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceCommentBulk", "3d3e437a-1b2d-4bee-aa50-042e11360851"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceCommentBulk", "3d3e437a-1b2d-4bee-aa50-042e11360851", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Foreach i_InvoiceList
localVars.inParami_InvoiceList.StartIteration();
try {while (!((localVars.inParami_InvoiceList.Eof))) {
// InvoiceCommentCreateOrUpdate
localVars.resInvoiceCommentCreateOrUpdate.outParamId = await Actions.ActionInvoiceCommentCreateOrUpdate(requestContext,new EN_41db3de59e8e7bb612336c1b02d2e4f8EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParami_InvoiceList.CurrentRec.ssInvoiceId, ssInvoiceApprovalLevelId = localVars.inParami_InvoiceList.CurrentRec.ssInvoiceApprovalLevelId, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = (((localVars.inParami_GetUserId!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_GetUserId) : (BuiltInFunction.GetUserId ())), ssMessage = localVars.inParami_Comment, ssIsPublic = true },cancellationToken);

localVars.inParami_InvoiceList.Advance();
}

} finally {
localVars.inParami_InvoiceList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionInvoiceCommentBulk {



}


}
