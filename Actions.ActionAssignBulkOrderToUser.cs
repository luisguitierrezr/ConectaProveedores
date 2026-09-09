namespace ssConectaProveedores;

public partial class Actions {
public class lcvAssignBulkOrderToUser : VarsBag {
public string inParami_UserId;
public RL_ae86137c3849df82f874f36658b7a66a inParami_OrderList;
public Actions.lcoAssignOrderToUser resAssignOrderToUser =  new Actions.lcoAssignOrderToUser();
public lcvAssignBulkOrderToUser(string inParami_UserId, RL_ae86137c3849df82f874f36658b7a66a inParami_OrderList) {
this.inParami_UserId = inParami_UserId;
this.inParami_OrderList = inParami_OrderList;
}
}
public class lcoAssignBulkOrderToUser : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoAssignBulkOrderToUser() {
}
}
/// <summary>
/// Action <code>AssignBulkOrderToUser</code> that represents the Service Studio action
///  <code>AssignBulkOrderToUser</code> <p> Description: Server action to assign bulk orders t
/// o someone.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionAssignBulkOrderToUser(IRequestContext requestContext,string inParami_UserId,RL_ae86137c3849df82f874f36658b7a66a inParami_OrderList,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoAssignBulkOrderToUser result = new lcoAssignBulkOrderToUser();
lcvAssignBulkOrderToUser localVars = new lcvAssignBulkOrderToUser(inParami_UserId, inParami_OrderList);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("AssignBulkOrderToUser", "d68692b5-2cc8-4ff7-a365-615f2c7a9ba7"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("AssignBulkOrderToUser", "d68692b5-2cc8-4ff7-a365-615f2c7a9ba7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// List Empty?
if((localVars.inParami_OrderList.Empty)) {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException (AppUtils.GetStringResource("U3XzlbEJD0qZ+39S9ZkHaQ#Message.2130969411.1", "List cannot be empty."));

} else {
// Foreach i_OrderList
localVars.inParami_OrderList.StartIteration();
try {while (!((localVars.inParami_OrderList.Eof))) {
// AssignOrderToUser
localVars.resAssignOrderToUser.outParamo_Output = await Actions.ActionAssignOrderToUser(requestContext,localVars.inParami_OrderList.CurrentRec.ssOrderMainId,localVars.inParami_OrderList.CurrentRec.ssOrderApprovaLevelId,localVars.inParami_UserId,cancellationToken);

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

catch (Ex_EntityExceptionUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = EntityException.ExceptionMessage
result.outParamo_Output.ssMessage = ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_Output = result.outParamo_Output;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionAssignBulkOrderToUser {



}


}
