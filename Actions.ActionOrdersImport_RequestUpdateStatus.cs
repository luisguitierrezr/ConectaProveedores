namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrdersImport_RequestUpdateStatus : VarsBag {
public long inParamId;
public int inParamStatus;
public RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 resGetOrdersImportRequest_outParamRecord = new RC_2407b5abb2cbfeaeaa8da6cdea4ccf12();

public lcvOrdersImport_RequestUpdateStatus(long inParamId, int inParamStatus) {
this.inParamId = inParamId;
this.inParamStatus = inParamStatus;
}
}
public class lcoOrdersImport_RequestUpdateStatus : VarsBag {
public ST_9f3831cec6ebd34416b59b8df7a27893Structure outParamResult = new ST_9f3831cec6ebd34416b59b8df7a27893Structure();

public lcoOrdersImport_RequestUpdateStatus() {
}
}
/// <summary>
/// Action <code>OrdersImport_RequestUpdateStatus</code> that represents the Service Studio action
///  <code>OrdersImport_RequestUpdateStatus</code> <p> Description: Encapsulates the Update entit
/// y action, enabling logic to run consistently before and after a record is modified.</p>
/// </summary>
public static async Task<ST_9f3831cec6ebd34416b59b8df7a27893Structure> ActionOrdersImport_RequestUpdateStatus(IRequestContext requestContext,long inParamId,int inParamStatus,CancellationToken cancellationToken) {
ST_9f3831cec6ebd34416b59b8df7a27893Structure outParamResult = default;
lcoOrdersImport_RequestUpdateStatus result = new lcoOrdersImport_RequestUpdateStatus();
lcvOrdersImport_RequestUpdateStatus localVars = new lcvOrdersImport_RequestUpdateStatus(inParamId, inParamStatus);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrdersImport_RequestUpdateStatus", "b1f63f76-6b34-435a-83ae-06f2bddeabeb"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrdersImport_RequestUpdateStatus", "b1f63f76-6b34-435a-83ae-06f2bddeabeb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Has Identifier?
if(((localVars.inParamId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Mandatory attributes validation
if(((localVars.inParamStatus!=BuiltInFunction.NullIdentifier ()))) {
// ControledLogMessage2
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),AppUtils.GetStringResource("T5S7L1qzg0KpnnTAMVimyg#Value.-565163602.1", "OrdersImport_RequestUpdateStatus » Request status updated"),"OrdersImport_RequestUpdateStatus",cancellationToken);

// GetOrdersImportRequest
localVars.resGetOrdersImportRequest_outParamRecord = await ExtendedActions.GetOrdersImportRequest(requestContext,localVars.inParamId,cancellationToken);

// Set basic audit attributes
// GetOrdersImportRequest.Record.OrdersImportRequest.Status = Status
localVars.resGetOrdersImportRequest_outParamRecord.ssENOrdersImportRequest.ssStatus = localVars.inParamStatus;
// UpdateOrdersImportRequest
await ExtendedActions.UpdateOrdersImportRequest(requestContext,localVars.resGetOrdersImportRequest_outParamRecord.ChangedAttributes,localVars.resGetOrdersImportRequest_outParamRecord,cancellationToken);

// Set Id
// Result.Identifier = Id
result.outParamResult.ssIdentifier = localVars.inParamId;

// Result.HasSuccess = True
result.outParamResult.ssHasSuccess = true;

// Result.ErrorMessage = ""
result.outParamResult.ssErrorMessage = "";
} else {
// Result.HasSuccess = False
result.outParamResult.ssHasSuccess = false;

// Result.ErrorMessage = "Status is mandatory"
result.outParamResult.ssErrorMessage = AppUtils.GetStringResource("fcvQhIlkZEaeaostBuOK9A#Value.1534308273.1", "Status is mandatory");

// Result.Identifier = Id
result.outParamResult.ssIdentifier = localVars.inParamId;
}

} else {
// Result.HasSuccess = False
result.outParamResult.ssHasSuccess = false;

// Result.ErrorMessage = "Identifier is mandatory"
result.outParamResult.ssErrorMessage = AppUtils.GetStringResource("dOYtlr1T80SaBnJpv7wJ4w#Value.48399450.1", "Identifier is mandatory");

// Result.Identifier = Id
result.outParamResult.ssIdentifier = localVars.inParamId;
}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// Result.HasSuccess = False
result.outParamResult.ssHasSuccess = false;

// Result.ErrorMessage = AllExceptions.ExceptionMessage
result.outParamResult.ssErrorMessage = ex.Message;

// Result.Identifier = Id
result.outParamResult.ssIdentifier = localVars.inParamId;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamResult = result.outParamResult;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamResult;
}

public static class FuncActionOrdersImport_RequestUpdateStatus {



}


}
