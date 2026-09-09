namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrdersApproveBulk : VarsBag {
public RL_35197d78da55a316e453192f6bb43d39 inParami_OrderList;
public Actions.lcoApprovRejectOrder resApprovRejectOrder =  new Actions.lcoApprovRejectOrder();
public lcvOrdersApproveBulk(RL_35197d78da55a316e453192f6bb43d39 inParami_OrderList) {
this.inParami_OrderList = inParami_OrderList;
}
}
public class lcoOrdersApproveBulk : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoOrdersApproveBulk() {
}
}
/// <summary>
/// Action <code>OrdersApproveBulk</code> that represents the Service Studio action
///  <code>OrdersApproveBulk</code> <p> Description: Orders Approve Bulk.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionOrdersApproveBulk(IRequestContext requestContext,RL_35197d78da55a316e453192f6bb43d39 inParami_OrderList,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoOrdersApproveBulk result = new lcoOrdersApproveBulk();
lcvOrdersApproveBulk localVars = new lcvOrdersApproveBulk(inParami_OrderList);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrdersApproveBulk", "2f8f4638-fde5-4616-b117-5a4785f84b71"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrdersApproveBulk", "2f8f4638-fde5-4616-b117-5a4785f84b71", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((localVars.inParami_OrderList.Empty)) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Cannot approve an empty list of Orders"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("yBVpFXRdzU2gQysnYca0vw#Value.-1044926750.1", "Cannot approve an empty list of Orders");
} else {
// Foreach i_OrderList
localVars.inParami_OrderList.StartIteration();
try {while (!((localVars.inParami_OrderList.Eof))) {
// ApprovRejectOrder
localVars.resApprovRejectOrder.outParamo_Output = await Actions.ActionApprovRejectOrder(requestContext,localVars.inParami_OrderList.CurrentRec.ssOrderId,localVars.inParami_OrderList.CurrentRec.ssOrderApprovalLevelId,true,"",cancellationToken);

localVars.inParami_OrderList.Advance();
}

} finally {
localVars.inParami_OrderList.EndIteration();
}

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

} //close CreateActionActivity using block
} // try

catch (CommunicationException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// o_Output.Message = o_Output.Message + "." + " " + "Due to a timeout, some orders have not been approved" + "!"
result.outParamo_Output.ssMessage = ((((result.outParamo_Output.ssMessage+".")+" ")+AppUtils.GetStringResource("EHwZeaikZUqbIPpq6Q3IWA#Value.1158589010.1", "Due to a timeout, some orders have not been approved"))+"!");

// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_Output = result.outParamo_Output;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionOrdersApproveBulk {



}


}
