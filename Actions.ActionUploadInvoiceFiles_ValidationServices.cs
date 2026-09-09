namespace ssConectaProveedores;

public partial class Actions {
public class lcvUploadInvoiceFiles_ValidationServices : VarsBag {
public bool inParamIsAccounting;
public byte[] inParamBinary;
public string inParamFilename;
public string inParamSupplierNumber;
public string inParamSupplierRegion;
public string inParamSupplierCompanySociety;
public string resBinaryToBase64_outParamBase64 = "";

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate14 =  new Actions.lcoLogsAccountingCreate();
public ST_13caff817360521524d01995a65282cdStructure resServicePostValidacfdiprov_outParamResponse = new ST_13caff817360521524d01995a65282cdStructure();

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate13 =  new Actions.lcoLogsAccountingCreate();
public ST_6636acdf9f49922edfd43b4865475460Structure resServicePostCarganovim_outParamResponse = new ST_6636acdf9f49922edfd43b4865475460Structure();

public Actions.lcoLogsAccountingCreate resLogsXMLValidationCreate15 =  new Actions.lcoLogsAccountingCreate();
public lcvUploadInvoiceFiles_ValidationServices(bool inParamIsAccounting, byte[] inParamBinary, string inParamFilename, string inParamSupplierNumber, string inParamSupplierRegion, string inParamSupplierCompanySociety) {
this.inParamIsAccounting = inParamIsAccounting;
this.inParamBinary = inParamBinary;
this.inParamFilename = inParamFilename;
this.inParamSupplierNumber = inParamSupplierNumber;
this.inParamSupplierRegion = inParamSupplierRegion;
this.inParamSupplierCompanySociety = inParamSupplierCompanySociety;
}
}
public class lcoUploadInvoiceFiles_ValidationServices : VarsBag {
public string outParamErrorMsg = "";

public lcoUploadInvoiceFiles_ValidationServices() {
}
}
/// <summary>
/// Action <code>UploadInvoiceFiles_ValidationServices</code> that represents the Service Studio action
///  <code>UploadInvoiceFiles_ValidationServices</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionUploadInvoiceFiles_ValidationServices(IRequestContext requestContext,bool inParamIsAccounting,byte[] inParamBinary,string inParamFilename,string inParamSupplierNumber,string inParamSupplierRegion,string inParamSupplierCompanySociety,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
lcoUploadInvoiceFiles_ValidationServices result = new lcoUploadInvoiceFiles_ValidationServices();
lcvUploadInvoiceFiles_ValidationServices localVars = new lcvUploadInvoiceFiles_ValidationServices(inParamIsAccounting, inParamBinary, inParamFilename, inParamSupplierNumber, inParamSupplierRegion, inParamSupplierCompanySociety);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("UploadInvoiceFiles_ValidationServices", "184d15cb-f84e-4c81-830c-c0937cbefb54"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("UploadInvoiceFiles_ValidationServices", "184d15cb-f84e-4c81-830c-c0937cbefb54", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// BinaryToBase64
localVars.resBinaryToBase64_outParamBase64 = await Actions.ActionBinaryToBase64(requestContext,localVars.inParamBinary,cancellationToken);

// LogsXMLValidationCreate13
localVars.resLogsXMLValidationCreate13.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = ((localVars.inParamIsAccounting) ? ("Call - PAC") : ("Call - CFDI")), ssDescription = ((localVars.inParamIsAccounting) ? (((((((((("Soc: "+localVars.inParamSupplierCompanySociety)+" // CveProv: ")+localVars.inParamSupplierNumber)+" // Reg: ")+localVars.inParamSupplierRegion)+" // Filename: ")+BuiltInFunction.ToUpper (localVars.inParamFilename))+" // Base64 ")+BuiltInFunction.SubstrSC (localVars.resBinaryToBase64_outParamBase64, 0, 40))) : (((("Soc: "+localVars.inParamSupplierCompanySociety)+" // Base64 ")+BuiltInFunction.SubstrSC (localVars.resBinaryToBase64_outParamBase64, 0, 40)))), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("QFMEycHUcEK7AmrqKizZBw"))).ssId },cancellationToken);

if((localVars.inParamIsAccounting)) {
// ServicePostCarganovim
localVars.resServicePostCarganovim_outParamResponse = await ServiceAPIs.ServiceAPIServicePostCarganovim(requestContext,new ST_9b7f85dc32c7c81ceef0a0963388237dStructure(){ ssCfdFile = localVars.resBinaryToBase64_outParamBase64, ssSociedad = localVars.inParamSupplierCompanySociety, ssCveProveedor = localVars.inParamSupplierNumber, ssFileName = BuiltInFunction.ToUpper (localVars.inParamFilename), ssDocType = "XML", ssRegion = localVars.inParamSupplierRegion },cancellationToken);

// ErrorMsg = If
result.outParamErrorMsg=(((localVars.resServicePostCarganovim_outParamResponse.ssCode!=Convert.ToInt64(200))) ? (localVars.resServicePostCarganovim_outParamResponse.ssMessage) : ((((localVars.resServicePostCarganovim_outParamResponse.ssCargaCFDResult.ssStatus!=Convert.ToString(200))) ? (localVars.resServicePostCarganovim_outParamResponse.ssCargaCFDResult.ssDescripcionStatus) : (""))));
// LogsXMLValidationCreate14
localVars.resLogsXMLValidationCreate14.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = (((result.outParamErrorMsg!="")) ? ("ERROR - PAC") : ("OK - PAC")), ssDescription = ((((((("Code: "+BuiltInFunction.LongIntegerToText(localVars.resServicePostCarganovim_outParamResponse.ssCode))+" // Msg: ")+localVars.resServicePostCarganovim_outParamResponse.ssMessage)+" // CargaCFDStatus: ")+localVars.resServicePostCarganovim_outParamResponse.ssCargaCFDResult.ssStatus)+" - ")+localVars.resServicePostCarganovim_outParamResponse.ssCargaCFDResult.ssDescripcionStatus), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("QFMEycHUcEK7AmrqKizZBw"))).ssId },cancellationToken);

} else {
// ServicePostValidacfdiprov
localVars.resServicePostValidacfdiprov_outParamResponse = await ServiceAPIs.ServiceAPIServicePostValidacfdiprov(requestContext,new ST_1e5384bdcb5c8be6badd45c0e821aec6Structure(){ ssSociedad = localVars.inParamSupplierCompanySociety, ssCfdFile = localVars.resBinaryToBase64_outParamBase64 },cancellationToken);

// ErrorMsg = If
result.outParamErrorMsg=(((localVars.resServicePostValidacfdiprov_outParamResponse.ssCode!=Convert.ToInt64(200))) ? (localVars.resServicePostValidacfdiprov_outParamResponse.ssMessage) : (((((!localVars.resServicePostValidacfdiprov_outParamResponse.ssValidaCfdResultWrapper.ssVigenteSat)||(localVars.resServicePostValidacfdiprov_outParamResponse.ssCode!=Convert.ToInt64(200)))) ? (localVars.resServicePostValidacfdiprov_outParamResponse.ssValidaCfdResultWrapper.ssMsgSat) : (""))));
// LogsXMLValidationCreate15
localVars.resLogsXMLValidationCreate15.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = (((result.outParamErrorMsg!="")) ? ("ERROR - CFDI") : ("OK - CFDI")), ssDescription = ((((((("Code: "+BuiltInFunction.LongIntegerToText(localVars.resServicePostValidacfdiprov_outParamResponse.ssCode))+" // Msg: ")+localVars.resServicePostValidacfdiprov_outParamResponse.ssMessage)+" // VigenteSat: ")+(localVars.resServicePostValidacfdiprov_outParamResponse.ssValidaCfdResultWrapper.ssVigenteSat ? "True" : "False"))+" - ")+localVars.resServicePostValidacfdiprov_outParamResponse.ssValidaCfdResultWrapper.ssMsgSat), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("QFMEycHUcEK7AmrqKizZBw"))).ssId },cancellationToken);

}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// ErrorMsg = "There was an error in the application. Please try again or contact an administrator."
result.outParamErrorMsg=AppUtils.GetStringResource("iqnCf14RAEiGOfhdqVsNDg#Value.166615810.1", "There was an error in the application. Please try again or contact an administrator.");
goto RETURN_STATEMENT;

} // Catch
finally {
outParamErrorMsg = result.outParamErrorMsg;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamErrorMsg;
}

public static class FuncActionUploadInvoiceFiles_ValidationServices {



}


}
