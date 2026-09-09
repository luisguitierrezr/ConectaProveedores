namespace ssConectaProveedores;

public partial class Actions {
public class lcvEntry_CallService2EM_SM_CECO : VarsBag {
public ST_883584831b34399a326748c4b1ce95c9Structure inParamRequest;
public long inParamFolioId;
public Actions.lcoLogFolioSAPErrors resLogFolioSAPErrors =  new Actions.lcoLogFolioSAPErrors();
public Actions.lcoFolioSAPData_CreateOrUpdate resFolioSAPData_Create =  new Actions.lcoFolioSAPData_CreateOrUpdate();
public string resJSONSerialize2_outParamJSON = "";
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public ST_92e975006ec90075480e9af34dc228e3Structure resService_EM_SM_CECO_outParamResponse = new ST_92e975006ec90075480e9af34dc228e3Structure();

public string resJSONSerialize1_outParamJSON = "";
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate2 =  new Actions.lcoLogsAccountingCreate();
public lcvEntry_CallService2EM_SM_CECO(ST_883584831b34399a326748c4b1ce95c9Structure inParamRequest, long inParamFolioId) {
this.inParamRequest = inParamRequest;
this.inParamFolioId = inParamFolioId;
}
}
public class lcoEntry_CallService2EM_SM_CECO : VarsBag {
public string outParamEntry_EM = "";

public string outParamEntry_SM = "";

public string outParamErrorMsg = "";

public string outParamEjercicio_EM = "";

public string outParamEjercicio_SM = "";

public string outParamGroupFolio = "";

public lcoEntry_CallService2EM_SM_CECO() {
}
}
/// <summary>
/// Action <code>Entry_CallService2EM_SM_CECO</code> that represents the Service Studio action
///  <code>Entry_CallService2EM_SM_CECO</code> <p> Description: </p>
/// </summary>
public static async Task<(string,string,string,string,string,string)> ActionEntry_CallService2EM_SM_CECO(IRequestContext requestContext,ST_883584831b34399a326748c4b1ce95c9Structure inParamRequest,long inParamFolioId,CancellationToken cancellationToken) {
string outParamEntry_EM = default;
string outParamEntry_SM = default;
string outParamErrorMsg = default;
string outParamEjercicio_EM = default;
string outParamEjercicio_SM = default;
string outParamGroupFolio = default;
lcoEntry_CallService2EM_SM_CECO result = new lcoEntry_CallService2EM_SM_CECO();
lcvEntry_CallService2EM_SM_CECO localVars = new lcvEntry_CallService2EM_SM_CECO(inParamRequest, inParamFolioId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Entry_CallService2EM_SM_CECO", "bd6db68f-ddb3-4384-8077-102329502d02"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Entry_CallService2EM_SM_CECO", "bd6db68f-ddb3-4384-8077-102329502d02", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// JSON Serialize JsonSerializeEntry_CallService2EM_SM_CECOJSONSerialize1
FuncActionEntry_CallService2EM_SM_CECO.JsonSerializeEntry_CallService2EM_SM_CECOJSONSerialize1(localVars.inParamRequest, out localVars.resJSONSerialize1_outParamJSON);
// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call ZMXMIMMF_EM_SM_CECO_COSMOZ", ssDescription = BuiltInFunction.SubstrSC (localVars.resJSONSerialize1_outParamJSON, 0, 1500), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("0s8s1whzKkOypjdeQvl1RQ"))).ssId },cancellationToken);

// Service_EM_SM_CECO
localVars.resService_EM_SM_CECO_outParamResponse = await ServiceAPIs.ServiceAPIService_EM_SM_CECO(requestContext,new ST_abeb699a3b96359819e408d199643162Structure(){ ssEM_SM_CECO_COSMOZ_Request_Struct = localVars.inParamRequest },cancellationToken);

// error
if(((localVars.resService_EM_SM_CECO_outParamResponse.ssEM_SM_CECO_COSMOZ_Response_Struct.ssPO_RESULTADO=="E"))) {
// ErrorMsg = If
result.outParamErrorMsg=(((localVars.resService_EM_SM_CECO_outParamResponse.ssEM_SM_CECO_COSMOZ_Response_Struct.ssPO_DESCRIPCION_ERROR!="")) ? (localVars.resService_EM_SM_CECO_outParamResponse.ssEM_SM_CECO_COSMOZ_Response_Struct.ssPO_DESCRIPCION_ERROR) : (AppUtils.GetStringResource("EEQ+QBNjVUmJfJGk6P4v6g#Value.859582450.1", "Error in service")));
// LogFolioSAPErrors
localVars.resLogFolioSAPErrors.outParamId = await Actions.ActionLogFolioSAPErrors(requestContext,localVars.inParamFolioId,((AppUtils.GetStringResource("gQcTz8A7jk6dCGZVlsvcmw#Value.1002514549.1", "Defective Goods Receipt")+": ")+result.outParamErrorMsg),true,cancellationToken);

} else {
// Entry_EM = Service_EM_SM_CECO.Response.EM_SM_CECO_COSMOZ_Response_Struct.PO_DOCUMENTO_MATERIAL_EM
result.outParamEntry_EM=localVars.resService_EM_SM_CECO_outParamResponse.ssEM_SM_CECO_COSMOZ_Response_Struct.ssPO_DOCUMENTO_MATERIAL_EM;

// Entry_SM = Service_EM_SM_CECO.Response.EM_SM_CECO_COSMOZ_Response_Struct.PO_DOCUMENTO_MATERIAL_SM
result.outParamEntry_SM=localVars.resService_EM_SM_CECO_outParamResponse.ssEM_SM_CECO_COSMOZ_Response_Struct.ssPO_DOCUMENTO_MATERIAL_SM;

// Ejercicio_EM = Service_EM_SM_CECO.Response.EM_SM_CECO_COSMOZ_Response_Struct.PO_EJERCICIO_EM
result.outParamEjercicio_EM=localVars.resService_EM_SM_CECO_outParamResponse.ssEM_SM_CECO_COSMOZ_Response_Struct.ssPO_EJERCICIO_EM;

// Ejercicio_SM = Service_EM_SM_CECO.Response.EM_SM_CECO_COSMOZ_Response_Struct.PO_EJERCICIO_SM
result.outParamEjercicio_SM=localVars.resService_EM_SM_CECO_outParamResponse.ssEM_SM_CECO_COSMOZ_Response_Struct.ssPO_EJERCICIO_SM;

// GroupFolio = Service_EM_SM_CECO.Response.EM_SM_CECO_COSMOZ_Response_Struct.PO_FOLIO_AGRUPADOS
result.outParamGroupFolio=localVars.resService_EM_SM_CECO_outParamResponse.ssEM_SM_CECO_COSMOZ_Response_Struct.ssPO_FOLIO_AGRUPADOS;
// FolioSAPData_Create
localVars.resFolioSAPData_Create.outParamId = await Actions.ActionFolioSAPData_CreateOrUpdate(requestContext,new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParamFolioId, ssService = "ZMXMIMMF_EM_SM_CECO_COSMOZ", ssPO_DOCUMENTO_MATERIAL_EM = localVars.resService_EM_SM_CECO_outParamResponse.ssEM_SM_CECO_COSMOZ_Response_Struct.ssPO_DOCUMENTO_MATERIAL_EM, ssPO_DOCUMENTO_MATERIAL_SM = localVars.resService_EM_SM_CECO_outParamResponse.ssEM_SM_CECO_COSMOZ_Response_Struct.ssPO_DOCUMENTO_MATERIAL_SM, ssPO_EJERCICIO_EM = localVars.resService_EM_SM_CECO_outParamResponse.ssEM_SM_CECO_COSMOZ_Response_Struct.ssPO_EJERCICIO_EM, ssPO_EJERCICIO_SM = localVars.resService_EM_SM_CECO_outParamResponse.ssEM_SM_CECO_COSMOZ_Response_Struct.ssPO_EJERCICIO_SM, ssPO_FOLIO_AGRUPADOS = localVars.resService_EM_SM_CECO_outParamResponse.ssEM_SM_CECO_COSMOZ_Response_Struct.ssPO_FOLIO_AGRUPADOS, ssPO_RESULTADO = localVars.resService_EM_SM_CECO_outParamResponse.ssEM_SM_CECO_COSMOZ_Response_Struct.ssPO_RESULTADO, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

}

// JSON Serialize JsonSerializeEntry_CallService2EM_SM_CECOJSONSerialize2
FuncActionEntry_CallService2EM_SM_CECO.JsonSerializeEntry_CallService2EM_SM_CECOJSONSerialize2(localVars.resService_EM_SM_CECO_outParamResponse, out localVars.resJSONSerialize2_outParamJSON);
// LogsAccountingCreate2
localVars.resLogsAccountingCreate2.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Resposta ZMXMIMMF_EM_SM_CECO_COSMOZ", ssDescription = BuiltInFunction.SubstrSC (localVars.resJSONSerialize2_outParamJSON, 0, 1500), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("0s8s1whzKkOypjdeQvl1RQ"))).ssId },cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
outParamEntry_EM = result.outParamEntry_EM;
outParamEntry_SM = result.outParamEntry_SM;
outParamErrorMsg = result.outParamErrorMsg;
outParamEjercicio_EM = result.outParamEjercicio_EM;
outParamEjercicio_SM = result.outParamEjercicio_SM;
outParamGroupFolio = result.outParamGroupFolio;
} // inner-finally
RETURN_STATEMENT:
return (outParamEntry_EM,outParamEntry_SM,outParamErrorMsg,outParamEjercicio_EM,outParamEjercicio_SM,outParamGroupFolio);
}

public static class FuncActionEntry_CallService2EM_SM_CECO {



/// <summary>
/// JSONSerialize: JsonSerializeEntry_CallService2EM_SM_CECOJSONSerialize2 (KRYEpeBmbdkmy5wKEWPCg7Q) 
///  of Action "Entry_CallService2EM_SM_CECO"
/// </summary>
public static void JsonSerializeEntry_CallService2EM_SM_CECOJSONSerialize2 (ST_92e975006ec90075480e9af34dc228e3Structure inParamRecord, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = ssConectaProveedores.RestRecords.JSONST_92e975006ec90075480e9af34dc228e3Structure.FromStructure(inParamRecord, config);
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

/// <summary>
/// JSONSerialize: JsonSerializeEntry_CallService2EM_SM_CECOJSONSerialize1 (KVV14yHuB4U_NXHGAsRhuXQ) 
///  of Action "Entry_CallService2EM_SM_CECO"
/// </summary>
public static void JsonSerializeEntry_CallService2EM_SM_CECOJSONSerialize1 (ST_883584831b34399a326748c4b1ce95c9Structure inParamRecord, out string outParamJSON) {
var config = new OutSystems.RESTService.Runtime.Abstractions.Controllers.BaseRestServiceControllerConfiguration() {
DefaultValuesBehavior = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DefaultValuesBehavior.DontSend,
DateTimeFormat = OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO
};

var holder = ssConectaProveedores.RestRecords.JSONST_883584831b34399a326748c4b1ce95c9Structure.FromStructure(inParamRecord, config);
outParamJSON = Newtonsoft.Json.JsonConvert.SerializeObject(holder, config.SerializerSettings);

}

}


}
