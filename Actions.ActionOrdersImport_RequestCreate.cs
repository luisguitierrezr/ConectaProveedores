namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrdersImport_RequestCreate : VarsBag {
public string inParamOrigin;
public byte[] inParamImportedData;
public long resCreateOrdersImportRequest_outParamId = 0L;

public lcvOrdersImport_RequestCreate(string inParamOrigin, byte[] inParamImportedData) {
this.inParamOrigin = inParamOrigin;
this.inParamImportedData = inParamImportedData;
}
}
public class lcoOrdersImport_RequestCreate : VarsBag {
public ST_9f3831cec6ebd34416b59b8df7a27893Structure outParamResult = new ST_9f3831cec6ebd34416b59b8df7a27893Structure();

public lcoOrdersImport_RequestCreate() {
}
}
/// <summary>
/// Action <code>OrdersImport_RequestCreate</code> that represents the Service Studio action
///  <code>OrdersImport_RequestCreate</code> <p> Description: Encapsulates the Create entity action
/// , enabling logic to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<ST_9f3831cec6ebd34416b59b8df7a27893Structure> ActionOrdersImport_RequestCreate(IRequestContext requestContext,string inParamOrigin,byte[] inParamImportedData,CancellationToken cancellationToken) {
ST_9f3831cec6ebd34416b59b8df7a27893Structure outParamResult = default;
lcoOrdersImport_RequestCreate result = new lcoOrdersImport_RequestCreate();
lcvOrdersImport_RequestCreate localVars = new lcvOrdersImport_RequestCreate(inParamOrigin, inParamImportedData);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrdersImport_RequestCreate", "434bd4ed-5c42-431d-bcfa-75e6e514add2"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrdersImport_RequestCreate", "434bd4ed-5c42-431d-bcfa-75e6e514add2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((((localVars.inParamOrigin!="API")&&(localVars.inParamOrigin!="Excel")))) {
// Result.HasSuccess = False
result.outParamResult.ssHasSuccess = false;

// Result.ErrorMessage = "Inválid Origin"
result.outParamResult.ssErrorMessage = AppUtils.GetStringResource("HDdZiLVi2UeALLNn8_oxiw#Value.-360748497.1", "Inválid Origin");

// Result.Identifier = NullIdentifier
result.outParamResult.ssIdentifier = Convert.ToInt64(BuiltInFunction.NullIdentifier ());
} else {
// ControledLogMessage2
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),AppUtils.GetStringResource("75H+Be0DH0WO4cRLvsEDcg#Value.-957779640.1", "OrdersImport_RequestCreate » Create Order Request"),"OrdersImport_RequestCreate",cancellationToken);

// CreateOrdersImportRequest
localVars.resCreateOrdersImportRequest_outParamId = await ExtendedActions.CreateOrdersImportRequest(requestContext,new RC_2407b5abb2cbfeaeaa8da6cdea4ccf12(){ ssENOrdersImportRequest = new EN_8c3668a93870461b8ea1216c2848f298EntityRecord(){ ssOrigin = localVars.inParamOrigin, ssImportedData = localVars.inParamImportedData, ssStatus = (ENImportStatusEntity.GetRecordByKey(ObjectKey.Parse("a_Cgy05KMEa+_erSCK6rCg"))).ssId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () } },cancellationToken);

// Set Id
// Result.Identifier = CreateOrdersImportRequest.Id
result.outParamResult.ssIdentifier = localVars.resCreateOrdersImportRequest_outParamId;

// Result.HasSuccess = True
result.outParamResult.ssHasSuccess = true;

// Result.ErrorMessage = ""
result.outParamResult.ssErrorMessage = "";
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

// Result.Identifier = NullIdentifier
result.outParamResult.ssIdentifier = Convert.ToInt64(BuiltInFunction.NullIdentifier ());
goto RETURN_STATEMENT;

} // Catch
finally {
outParamResult = result.outParamResult;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamResult;
}

public static class FuncActionOrdersImport_RequestCreate {



}


}
