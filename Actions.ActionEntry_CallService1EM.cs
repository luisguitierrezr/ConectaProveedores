namespace ssConectaProveedores;

public partial class Actions {
public class lcvEntry_CallService1EM : VarsBag {
public ST_54b441362fa983751bf9575ed6b668beStructure inParamRequest;
public long inParamFolioId;
public Actions.lcoLogFolioSAPErrors resLogFolioSAPErrors2 =  new Actions.lcoLogFolioSAPErrors();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate3 =  new Actions.lcoLogsAccountingCreate();
public string resJSONSerialize1_outParamJSON = "";
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate2 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoFolioSAPData_CreateOrUpdate resFolioSAPData_Create =  new Actions.lcoFolioSAPData_CreateOrUpdate();
public string resJSONSerialize2_outParamJSON = "";
public ST_ff65d449d860eb4ed98725735a32f4f3Structure resService_EM_outParamResponse = new ST_ff65d449d860eb4ed98725735a32f4f3Structure();

public Actions.lcoLogFolioSAPErrors resLogFolioSAPErrors =  new Actions.lcoLogFolioSAPErrors();
public lcvEntry_CallService1EM(ST_54b441362fa983751bf9575ed6b668beStructure inParamRequest, long inParamFolioId) {
this.inParamRequest = inParamRequest;
this.inParamFolioId = inParamFolioId;
}
}
public class lcoEntry_CallService1EM : VarsBag {
public string outParamEntry = "";

public string outParamErrorMsg = "";

public string outParamEjercicio = "";

public lcoEntry_CallService1EM() {
}
}
/// <summary>
/// Action <code>Entry_CallService1EM</code> that represents the Service Studio action
///  <code>Entry_CallService1EM</code> <p> Description: </p>
/// </summary>
public static async Task<(string,string,string)> ActionEntry_CallService1EM(IRequestContext requestContext,ST_54b441362fa983751bf9575ed6b668beStructure inParamRequest,long inParamFolioId,CancellationToken cancellationToken) {
string outParamEntry = default;
string outParamErrorMsg = default;
string outParamEjercicio = default;
lcoEntry_CallService1EM result = new lcoEntry_CallService1EM();
lcvEntry_CallService1EM localVars = new lcvEntry_CallService1EM(inParamRequest, inParamFolioId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Entry_CallService1EM", "f97ae5f0-033e-4035-8c6a-ba97379e3c78"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Entry_CallService1EM", "f97ae5f0-033e-4035-8c6a-ba97379e3c78", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// JSON Serialize JsonSerializeEntry_CallService1EMJSONSerialize1
FuncActionEntry_CallService1EM.JsonSerializeEntry_CallService1EMJSONSerialize1(localVars.inParamRequest, out localVars.resJSONSerialize1_outParamJSON);
// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call ZMXMIMMF_EM_COSMOZ", ssDescription = BuiltInFunction.SubstrSC (localVars.resJSONSerialize1_outParamJSON, 0, 1500), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("0s8s1whzKkOypjdeQvl1RQ"))).ssId },cancellationToken);

// Service_EM
localVars.resService_EM_outParamResponse = await ServiceAPIs.ServiceAPIService_EM(requestContext,new ST_471afc38d91cd307b39846c7ca5ddb86Structure(){ ssEM_COSMOZ_Request_Struct = localVars.inParamRequest },cancellationToken);

// error
if((((localVars.resService_EM_outParamResponse.ssEM_COSMOZ_Response_Struct.ssPO_RESULTADO=="E")||(localVars.resService_EM_outParamResponse.ssEM_COSMOZ_Response_Struct.ssPO_RESULTADO=="")))) {
// ErrorMsg = If
result.outParamErrorMsg=(((localVars.resService_EM_outParamResponse.ssEM_COSMOZ_Response_Struct.ssPO_DESCRIPCION_ERROR!="")) ? (localVars.resService_EM_outParamResponse.ssEM_COSMOZ_Response_Struct.ssPO_DESCRIPCION_ERROR) : (AppUtils.GetStringResource("ofalpl5F60Sf8NMrl9uEww#Value.859582450.1", "Error in service")));
// LogFolioSAPErrors
localVars.resLogFolioSAPErrors.outParamId = await Actions.ActionLogFolioSAPErrors(requestContext,localVars.inParamFolioId,((AppUtils.GetStringResource("forFee2os0GHFwX_gju97A#Value.1002514549.1", "Defective Goods Receipt")+": ")+result.outParamErrorMsg),true,cancellationToken);

} else {
// Entry = Service_EM.Response.EM_COSMOZ_Response_Struct.PO_DOCUMENTO_MATERIAL
result.outParamEntry=localVars.resService_EM_outParamResponse.ssEM_COSMOZ_Response_Struct.ssPO_DOCUMENTO_MATERIAL;

// Ejercicio = Service_EM.Response.EM_COSMOZ_Response_Struct.PO_EJERCICIO
result.outParamEjercicio=localVars.resService_EM_outParamResponse.ssEM_COSMOZ_Response_Struct.ssPO_EJERCICIO;
// FolioSAPData_Create
localVars.resFolioSAPData_Create.outParamId = await Actions.ActionFolioSAPData_CreateOrUpdate(requestContext,new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParamFolioId, ssService = "Call_ZMXMIMMF_EM_COSMOZ", ssPO_DOCUMENTO_MATERIAL_EM = localVars.resService_EM_outParamResponse.ssEM_COSMOZ_Response_Struct.ssPO_DOCUMENTO_MATERIAL, ssPO_EJERCICIO_EM = localVars.resService_EM_outParamResponse.ssEM_COSMOZ_Response_Struct.ssPO_EJERCICIO, ssPO_RESULTADO = localVars.resService_EM_outParamResponse.ssEM_COSMOZ_Response_Struct.ssPO_RESULTADO, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

}

// JSON Serialize JsonSerializeEntry_CallService1EMJSONSerialize2
FuncActionEntry_CallService1EM.JsonSerializeEntry_CallService1EMJSONSerialize2(localVars.resService_EM_outParamResponse, out localVars.resJSONSerialize2_outParamJSON);
// LogsAccountingCreate2
localVars.resLogsAccountingCreate2.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Resposta ZMXMIMMF_EM_COSMOZ", ssDescription = BuiltInFunction.SubstrSC (localVars.resJSONSerialize2_outParamJSON, 0, 1500), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("0s8s1whzKkOypjdeQvl1RQ"))).ssId },cancellationToken);

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// ErrorMsg = Substr
result.outParamErrorMsg=BuiltInFunction.SubstrSC (ex.Message, 0, 1500);
// LogFolioSAPErrors2
localVars.resLogFolioSAPErrors2.outParamId = await Actions.ActionLogFolioSAPErrors(requestContext,localVars.inParamFolioId,((AppUtils.GetStringResource("TYDC8zDLdUiP8jX78zcQmQ#Value.1002514549.1", "Defective Goods Receipt")+": ")+result.outParamErrorMsg),true,cancellationToken);

// LogsAccountingCreate3
localVars.resLogsAccountingCreate3.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Resposta ZMXMIMMF_EM_COSMOZ", ssDescription = result.outParamErrorMsg, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("0s8s1whzKkOypjdeQvl1RQ"))).ssId },cancellationToken);

goto RETURN_STATEMENT;

} // Catch
finally {
outParamEntry = result.outParamEntry;
outParamErrorMsg = result.outParamErrorMsg;
outParamEjercicio = result.outParamEjercicio;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamEntry,outParamErrorMsg,outParamEjercicio);
}

public static class FuncActionEntry_CallService1EM {



/// <summary>
/// JSONSerialize: JsonSerializeEntry_CallService1EMJSONSerialize1 (Kd7zYnhay3k_8P1PpFsm0zw)  of Action
///  "Entry_CallService1EM"
/// </summary>
public static void JsonSerializeEntry_CallService1EMJSONSerialize1 (ST_54b441362fa983751bf9575ed6b668beStructure inParamRecord, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = ssConectaProveedores.RestRecords.JSONST_54b441362fa983751bf9575ed6b668beStructure.FromStructure(inParamRecord, config);
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

/// <summary>
/// JSONSerialize: JsonSerializeEntry_CallService1EMJSONSerialize2 (KiLmhwVmur0_Yi7vLLL_r8w)  of Action
///  "Entry_CallService1EM"
/// </summary>
public static void JsonSerializeEntry_CallService1EMJSONSerialize2 (ST_ff65d449d860eb4ed98725735a32f4f3Structure inParamRecord, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = ssConectaProveedores.RestRecords.JSONST_ff65d449d860eb4ed98725735a32f4f3Structure.FromStructure(inParamRecord, config);
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

}


}
