namespace ssConectaProveedores;

public partial class Actions {
public class lcvEntry_CallService4EM_SM_RM : VarsBag {
public ST_b38fe38940c72474a8e67442651bc995Structure inParamRequest;
public long inParamFolioId;
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate2 =  new Actions.lcoLogsAccountingCreate();
public string resJSONSerialize1_outParamJSON = "";
public Actions.lcoLogFolioSAPErrors resLogFolioSAPErrors =  new Actions.lcoLogFolioSAPErrors();
public ST_b3b2573902c6e22d9647e405d3baf728Structure resService_EM_SM_RM_outParamResponse = new ST_b3b2573902c6e22d9647e405d3baf728Structure();

public Actions.lcoFolioSAPData_CreateOrUpdate resFolioSAPData_Create =  new Actions.lcoFolioSAPData_CreateOrUpdate();
public string resJSONSerialize2_outParamJSON = "";
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public lcvEntry_CallService4EM_SM_RM(ST_b38fe38940c72474a8e67442651bc995Structure inParamRequest, long inParamFolioId) {
this.inParamRequest = inParamRequest;
this.inParamFolioId = inParamFolioId;
}
}
public class lcoEntry_CallService4EM_SM_RM : VarsBag {
public string outParamEntry = "";

public string outParamErrorMsg = "";

public string outParamEjercicio = "";

public string outParamGroupFolio = "";

public lcoEntry_CallService4EM_SM_RM() {
}
}
/// <summary>
/// Action <code>Entry_CallService4EM_SM_RM</code> that represents the Service Studio action
///  <code>Entry_CallService4EM_SM_RM</code> <p> Description: </p>
/// </summary>
public static async Task<(string,string,string,string)> ActionEntry_CallService4EM_SM_RM(IRequestContext requestContext,ST_b38fe38940c72474a8e67442651bc995Structure inParamRequest,long inParamFolioId,CancellationToken cancellationToken) {
string outParamEntry = default;
string outParamErrorMsg = default;
string outParamEjercicio = default;
string outParamGroupFolio = default;
lcoEntry_CallService4EM_SM_RM result = new lcoEntry_CallService4EM_SM_RM();
lcvEntry_CallService4EM_SM_RM localVars = new lcvEntry_CallService4EM_SM_RM(inParamRequest, inParamFolioId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Entry_CallService4EM_SM_RM", "8ab05444-c2a3-4a53-93b0-13cee0ec9b76"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Entry_CallService4EM_SM_RM", "8ab05444-c2a3-4a53-93b0-13cee0ec9b76", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// JSON Serialize JsonSerializeEntry_CallService4EM_SM_RMJSONSerialize1
FuncActionEntry_CallService4EM_SM_RM.JsonSerializeEntry_CallService4EM_SM_RMJSONSerialize1(localVars.inParamRequest, out localVars.resJSONSerialize1_outParamJSON);
// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call ZMXMIMMF_EM_SM_RM_COSMOZ", ssDescription = BuiltInFunction.SubstrSC (localVars.resJSONSerialize1_outParamJSON, 0, 1500), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("0s8s1whzKkOypjdeQvl1RQ"))).ssId },cancellationToken);

// Service_EM_SM_RM
localVars.resService_EM_SM_RM_outParamResponse = await ServiceAPIs.ServiceAPIService_EM_SM_RM(requestContext,(await RecordUtils.ConvertAsync(localVars.inParamRequest, new ST_c338780fd6468541199340ed93f1aecdStructure(), async (ST_b38fe38940c72474a8e67442651bc995Structure source, ST_c338780fd6468541199340ed93f1aecdStructure target, CancellationToken cancellationToken) => {
target.ssEM_SM_RM_COSMOZ_Request_Struct.ssPI_HEADER = source.ssPI_HEADER;
target.ssEM_SM_RM_COSMOZ_Request_Struct.ssPI_ITEM_EM = source.ssPI_ITEM_EM;
target.ssEM_SM_RM_COSMOZ_Request_Struct.ssPI_ITEM_SM = source.ssPI_ITEM_SM;
return target;
}, cancellationToken)),cancellationToken);

// error
if(((localVars.resService_EM_SM_RM_outParamResponse.ssEM_SM_RM_COSMOZ_Response_Struct.ssPO_RESULTADO=="E"))) {
// ErrorMsg = If
result.outParamErrorMsg=(((localVars.resService_EM_SM_RM_outParamResponse.ssEM_SM_RM_COSMOZ_Response_Struct.ssPO_DESCRIPCION_ERROR!="")) ? (localVars.resService_EM_SM_RM_outParamResponse.ssEM_SM_RM_COSMOZ_Response_Struct.ssPO_DESCRIPCION_ERROR) : (AppUtils.GetStringResource("fjFgrGIqBkqOFgkX3TZZdA#Value.859582450.1", "Error in service")));
// LogFolioSAPErrors
localVars.resLogFolioSAPErrors.outParamId = await Actions.ActionLogFolioSAPErrors(requestContext,localVars.inParamFolioId,((AppUtils.GetStringResource("KLS5kZlkn0CV7WO3ForjVw#Value.1002514549.1", "Defective Goods Receipt")+": ")+result.outParamErrorMsg),true,cancellationToken);

} else {
// Entry = Service_EM_SM_RM.Response.EM_SM_RM_COSMOZ_Response_Struct.PO_DOCUMENTO_MATERIAL
result.outParamEntry=localVars.resService_EM_SM_RM_outParamResponse.ssEM_SM_RM_COSMOZ_Response_Struct.ssPO_DOCUMENTO_MATERIAL;

// Ejercicio = Service_EM_SM_RM.Response.EM_SM_RM_COSMOZ_Response_Struct.PO_EJERCICIO
result.outParamEjercicio=localVars.resService_EM_SM_RM_outParamResponse.ssEM_SM_RM_COSMOZ_Response_Struct.ssPO_EJERCICIO;

// GroupFolio = Service_EM_SM_RM.Response.EM_SM_RM_COSMOZ_Response_Struct.PO_FOLIO_AGRUPADOR
result.outParamGroupFolio=localVars.resService_EM_SM_RM_outParamResponse.ssEM_SM_RM_COSMOZ_Response_Struct.ssPO_FOLIO_AGRUPADOR;
// FolioSAPData_Create
localVars.resFolioSAPData_Create.outParamId = await Actions.ActionFolioSAPData_CreateOrUpdate(requestContext,new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParamFolioId, ssService = "Call_ZMXMIMMF_EM_SM_RM_COSMOZ", ssPO_DOCUMENTO_MATERIAL_EM = localVars.resService_EM_SM_RM_outParamResponse.ssEM_SM_RM_COSMOZ_Response_Struct.ssPO_DOCUMENTO_MATERIAL, ssPO_EJERCICIO_EM = localVars.resService_EM_SM_RM_outParamResponse.ssEM_SM_RM_COSMOZ_Response_Struct.ssPO_EJERCICIO, ssPO_FOLIO_AGRUPADOS = localVars.resService_EM_SM_RM_outParamResponse.ssEM_SM_RM_COSMOZ_Response_Struct.ssPO_FOLIO_AGRUPADOR, ssPO_RESULTADO = localVars.resService_EM_SM_RM_outParamResponse.ssEM_SM_RM_COSMOZ_Response_Struct.ssPO_RESULTADO, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

}

// JSON Serialize JsonSerializeEntry_CallService4EM_SM_RMJSONSerialize2
FuncActionEntry_CallService4EM_SM_RM.JsonSerializeEntry_CallService4EM_SM_RMJSONSerialize2(localVars.resService_EM_SM_RM_outParamResponse, out localVars.resJSONSerialize2_outParamJSON);
// LogsAccountingCreate2
localVars.resLogsAccountingCreate2.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Resposta ZMXMIMMF_EM_SM_RM_COSMOZ", ssDescription = BuiltInFunction.SubstrSC (localVars.resJSONSerialize2_outParamJSON, 0, 1500), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("0s8s1whzKkOypjdeQvl1RQ"))).ssId },cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
outParamEntry = result.outParamEntry;
outParamErrorMsg = result.outParamErrorMsg;
outParamEjercicio = result.outParamEjercicio;
outParamGroupFolio = result.outParamGroupFolio;
} // inner-finally
RETURN_STATEMENT:
return (outParamEntry,outParamErrorMsg,outParamEjercicio,outParamGroupFolio);
}

public static class FuncActionEntry_CallService4EM_SM_RM {



/// <summary>
/// JSONSerialize: JsonSerializeEntry_CallService4EM_SM_RMJSONSerialize1 (KvqueTJAH70usUITBLg04oA)  of
///  Action "Entry_CallService4EM_SM_RM"
/// </summary>
public static void JsonSerializeEntry_CallService4EM_SM_RMJSONSerialize1 (ST_b38fe38940c72474a8e67442651bc995Structure inParamRecord, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = ssConectaProveedores.RestRecords.JSONST_b38fe38940c72474a8e67442651bc995Structure.FromStructure(inParamRecord, config);
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

/// <summary>
/// JSONSerialize: JsonSerializeEntry_CallService4EM_SM_RMJSONSerialize2 (K0Z0Arv3aTky2uYXlrC6WjA)  of
///  Action "Entry_CallService4EM_SM_RM"
/// </summary>
public static void JsonSerializeEntry_CallService4EM_SM_RMJSONSerialize2 (ST_b3b2573902c6e22d9647e405d3baf728Structure inParamRecord, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = ssConectaProveedores.RestRecords.JSONST_b3b2573902c6e22d9647e405d3baf728Structure.FromStructure(inParamRecord, config);
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

}


}
