namespace ssConectaProveedores;

public partial class Actions {
public class lcvEntry_CallService3EM_SM_MO : VarsBag {
public ST_e88e810a3be3c7b278de1b477e897388Structure inParamRequest;
public long inParamFolioId;
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogFolioSAPErrors resLogFolioSAPErrors =  new Actions.lcoLogFolioSAPErrors();
public ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure resService_EM_SM_MO_outParamResponse = new ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure();

public string resJSONSerialize2_outParamJSON = "";
public string resJSONSerialize1_outParamJSON = "";
public Actions.lcoFolioSAPData_CreateOrUpdate resFolioSAPData_Create =  new Actions.lcoFolioSAPData_CreateOrUpdate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate2 =  new Actions.lcoLogsAccountingCreate();
public lcvEntry_CallService3EM_SM_MO(ST_e88e810a3be3c7b278de1b477e897388Structure inParamRequest, long inParamFolioId) {
this.inParamRequest = inParamRequest;
this.inParamFolioId = inParamFolioId;
}
}
public class lcoEntry_CallService3EM_SM_MO : VarsBag {
public string outParamEntry_EM = "";

public string outParamEntry_221 = "";

public string outParamEntry_415 = "";

public string outParamErrorMsg = "";

public string outParamEjercicio = "";

public string outParamEjercicio_221 = "";

public string outParamEjercicio_415 = "";

public lcoEntry_CallService3EM_SM_MO() {
}
}
/// <summary>
/// Action <code>Entry_CallService3EM_SM_MO</code> that represents the Service Studio action
///  <code>Entry_CallService3EM_SM_MO</code> <p> Description: </p>
/// </summary>
public static async Task<(string,string,string,string,string,string,string)> ActionEntry_CallService3EM_SM_MO(IRequestContext requestContext,ST_e88e810a3be3c7b278de1b477e897388Structure inParamRequest,long inParamFolioId,CancellationToken cancellationToken) {
string outParamEntry_EM = default;
string outParamEntry_221 = default;
string outParamEntry_415 = default;
string outParamErrorMsg = default;
string outParamEjercicio = default;
string outParamEjercicio_221 = default;
string outParamEjercicio_415 = default;
lcoEntry_CallService3EM_SM_MO result = new lcoEntry_CallService3EM_SM_MO();
lcvEntry_CallService3EM_SM_MO localVars = new lcvEntry_CallService3EM_SM_MO(inParamRequest, inParamFolioId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Entry_CallService3EM_SM_MO", "06bc3c76-bf04-4233-a683-0f5dcae57e54"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Entry_CallService3EM_SM_MO", "06bc3c76-bf04-4233-a683-0f5dcae57e54", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// JSON Serialize JsonSerializeEntry_CallService3EM_SM_MOJSONSerialize1
FuncActionEntry_CallService3EM_SM_MO.JsonSerializeEntry_CallService3EM_SM_MOJSONSerialize1(localVars.inParamRequest, out localVars.resJSONSerialize1_outParamJSON);
// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call ZMXMIMMF_EM_SM_MO_COSMOZ", ssDescription = BuiltInFunction.SubstrSC (localVars.resJSONSerialize1_outParamJSON, 0, 1500), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("0s8s1whzKkOypjdeQvl1RQ"))).ssId },cancellationToken);

// Service_EM_SM_MO
localVars.resService_EM_SM_MO_outParamResponse = await ServiceAPIs.ServiceAPIService_EM_SM_MO(requestContext,(await RecordUtils.ConvertAsync(localVars.inParamRequest, new ST_f61ad0d448ed247a1bde22a5051a7d04Structure(), async (ST_e88e810a3be3c7b278de1b477e897388Structure source, ST_f61ad0d448ed247a1bde22a5051a7d04Structure target, CancellationToken cancellationToken) => {
target.ssEM_SM_MO_COSMOZ_Request_Struct.ssPI_HEADER = source.ssPI_HEADER;
target.ssEM_SM_MO_COSMOZ_Request_Struct.ssPI_ITEM_EM = source.ssPI_ITEM_EM;
target.ssEM_SM_MO_COSMOZ_Request_Struct.ssPI_ITEM_SM = source.ssPI_ITEM_SM;
return target;
}, cancellationToken)),cancellationToken);

// error
if(((localVars.resService_EM_SM_MO_outParamResponse.ssEM_SM_MO_COSMOZ_Response_Struct.ssPO_RESULTADO=="E"))) {
// ErrorMsg = If
result.outParamErrorMsg=(((localVars.resService_EM_SM_MO_outParamResponse.ssEM_SM_MO_COSMOZ_Response_Struct.ssPO_DESCRIPCION_ERROR!="")) ? (localVars.resService_EM_SM_MO_outParamResponse.ssEM_SM_MO_COSMOZ_Response_Struct.ssPO_DESCRIPCION_ERROR) : (AppUtils.GetStringResource("hphNKbltVUyEgAkU1ZJWpg#Value.859582450.1", "Error in service")));
// LogFolioSAPErrors
localVars.resLogFolioSAPErrors.outParamId = await Actions.ActionLogFolioSAPErrors(requestContext,localVars.inParamFolioId,((AppUtils.GetStringResource("LZnpYCb0PEejRNs_lqyAhQ#Value.1002514549.1", "Defective Goods Receipt")+": ")+result.outParamErrorMsg),true,cancellationToken);

} else {
// Entry_EM = Service_EM_SM_MO.Response.EM_SM_MO_COSMOZ_Response_Struct.PO_DOCUMENTO_MATERIAL_EM
result.outParamEntry_EM=localVars.resService_EM_SM_MO_outParamResponse.ssEM_SM_MO_COSMOZ_Response_Struct.ssPO_DOCUMENTO_MATERIAL_EM;

// Entry_221 = Service_EM_SM_MO.Response.EM_SM_MO_COSMOZ_Response_Struct.PO_DOCUMENTO_MATERIAL_221
result.outParamEntry_221=localVars.resService_EM_SM_MO_outParamResponse.ssEM_SM_MO_COSMOZ_Response_Struct.ssPO_DOCUMENTO_MATERIAL_221;

// Entry_415 = Service_EM_SM_MO.Response.EM_SM_MO_COSMOZ_Response_Struct.PO_DOCUMENTO_MATERIAL_415
result.outParamEntry_415=localVars.resService_EM_SM_MO_outParamResponse.ssEM_SM_MO_COSMOZ_Response_Struct.ssPO_DOCUMENTO_MATERIAL_415;

// Ejercicio = Service_EM_SM_MO.Response.EM_SM_MO_COSMOZ_Response_Struct.PO_EJERCICIO_EM
result.outParamEjercicio=localVars.resService_EM_SM_MO_outParamResponse.ssEM_SM_MO_COSMOZ_Response_Struct.ssPO_EJERCICIO_EM;

// Ejercicio_221 = Service_EM_SM_MO.Response.EM_SM_MO_COSMOZ_Response_Struct.PO_EJERCICIO_221
result.outParamEjercicio_221=localVars.resService_EM_SM_MO_outParamResponse.ssEM_SM_MO_COSMOZ_Response_Struct.ssPO_EJERCICIO_221;

// Ejercicio_415 = Service_EM_SM_MO.Response.EM_SM_MO_COSMOZ_Response_Struct.PO_EJERCICIO_415
result.outParamEjercicio_415=localVars.resService_EM_SM_MO_outParamResponse.ssEM_SM_MO_COSMOZ_Response_Struct.ssPO_EJERCICIO_415;
// FolioSAPData_Create
localVars.resFolioSAPData_Create.outParamId = await Actions.ActionFolioSAPData_CreateOrUpdate(requestContext,new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParamFolioId, ssService = "Call_ZMXMIMMF_EM_SM_MO_COSMOZ", ssPO_DOCUMENTO_MATERIAL_EM = localVars.resService_EM_SM_MO_outParamResponse.ssEM_SM_MO_COSMOZ_Response_Struct.ssPO_DOCUMENTO_MATERIAL_EM, ssPO_DOCUMENTO_MATERIAL_221 = localVars.resService_EM_SM_MO_outParamResponse.ssEM_SM_MO_COSMOZ_Response_Struct.ssPO_DOCUMENTO_MATERIAL_221, ssPO_DOCUMENTO_MATERIAL_415 = localVars.resService_EM_SM_MO_outParamResponse.ssEM_SM_MO_COSMOZ_Response_Struct.ssPO_DOCUMENTO_MATERIAL_415, ssPO_EJERCICIO_EM = localVars.resService_EM_SM_MO_outParamResponse.ssEM_SM_MO_COSMOZ_Response_Struct.ssPO_EJERCICIO_EM, ssPO_EJERCICIO_221 = localVars.resService_EM_SM_MO_outParamResponse.ssEM_SM_MO_COSMOZ_Response_Struct.ssPO_EJERCICIO_221, ssPO_EJERCICIO_415 = localVars.resService_EM_SM_MO_outParamResponse.ssEM_SM_MO_COSMOZ_Response_Struct.ssPO_EJERCICIO_415, ssPO_RESULTADO = localVars.resService_EM_SM_MO_outParamResponse.ssEM_SM_MO_COSMOZ_Response_Struct.ssPO_RESULTADO, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

}

// JSON Serialize JsonSerializeEntry_CallService3EM_SM_MOJSONSerialize2
FuncActionEntry_CallService3EM_SM_MO.JsonSerializeEntry_CallService3EM_SM_MOJSONSerialize2(localVars.resService_EM_SM_MO_outParamResponse, out localVars.resJSONSerialize2_outParamJSON);
// LogsAccountingCreate2
localVars.resLogsAccountingCreate2.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Resposta ZMXMIMMF_EM_SM_MO_COSMOZ", ssDescription = BuiltInFunction.SubstrSC (localVars.resJSONSerialize2_outParamJSON, 0, 1500), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("0s8s1whzKkOypjdeQvl1RQ"))).ssId },cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
outParamEntry_EM = result.outParamEntry_EM;
outParamEntry_221 = result.outParamEntry_221;
outParamEntry_415 = result.outParamEntry_415;
outParamErrorMsg = result.outParamErrorMsg;
outParamEjercicio = result.outParamEjercicio;
outParamEjercicio_221 = result.outParamEjercicio_221;
outParamEjercicio_415 = result.outParamEjercicio_415;
} // inner-finally
RETURN_STATEMENT:
return (outParamEntry_EM,outParamEntry_221,outParamEntry_415,outParamErrorMsg,outParamEjercicio,outParamEjercicio_221,outParamEjercicio_415);
}

public static class FuncActionEntry_CallService3EM_SM_MO {



/// <summary>
/// JSONSerialize: JsonSerializeEntry_CallService3EM_SM_MOJSONSerialize2 (Kq7DQamfr8UC1JvLBh3d7Qg)  of
///  Action "Entry_CallService3EM_SM_MO"
/// </summary>
public static void JsonSerializeEntry_CallService3EM_SM_MOJSONSerialize2 (ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure inParamRecord, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = ssConectaProveedores.RestRecords.JSONST_5a2f27e86c3f9cff3d6a27ca1772d236Structure.FromStructure(inParamRecord, config);
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

/// <summary>
/// JSONSerialize: JsonSerializeEntry_CallService3EM_SM_MOJSONSerialize1 (KR6LamwyhkEmUObHacNmIuw)  of
///  Action "Entry_CallService3EM_SM_MO"
/// </summary>
public static void JsonSerializeEntry_CallService3EM_SM_MOJSONSerialize1 (ST_e88e810a3be3c7b278de1b477e897388Structure inParamRecord, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = ssConectaProveedores.RestRecords.JSONST_e88e810a3be3c7b278de1b477e897388Structure.FromStructure(inParamRecord, config);
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

}


}
