using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_y_Logs_Wb_GetAuditList_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("OriginId")]
public int? inParamOriginId;
[JsonProperty("PeriodInit")]
public String inParamPeriodInit;
[JsonProperty("PeriodEnd")]
public String inParamPeriodEnd;
[JsonProperty("MaxRecords")]
public int? inParamMaxRecords;
[JsonProperty("ShowErrors")]
public bool? inParamShowErrors;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("ShowPopup")]
public bool? varLcShowPopup;
[JsonProperty("JSON_After")]
public string varLcJSON_After;
[JsonProperty("JSON_Before")]
public string varLcJSON_Before;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("GetData")]
public RESTConectaProveedores_y_Logs_Wb_GetAuditList_DataActionGetData_Outputs varLcGetData;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_y_Logs_Wb_GetAuditList_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_y_Logs_Wb_GetAuditList_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_y_Logs_Wb_GetAuditList_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_y_Logs_Wb_GetAuditList_ScreenModel ToModel() {int inParamOriginId = variables.inParamOriginId == null ? 0 : variables.inParamOriginId.Value;
DateTime inParamPeriodInit = variables.inParamPeriodInit == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.inParamPeriodInit, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
DateTime inParamPeriodEnd = variables.inParamPeriodEnd == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.inParamPeriodEnd, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
int inParamMaxRecords = variables.inParamMaxRecords == null ? 0 : variables.inParamMaxRecords.Value;
bool inParamShowErrors = variables.inParamShowErrors == null ? false : variables.inParamShowErrors.Value;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
bool varLcShowPopup = variables.varLcShowPopup == null ? false : variables.varLcShowPopup.Value;
string varLcJSON_After = variables.varLcJSON_After == null ? "" : variables.varLcJSON_After;
string varLcJSON_Before = variables.varLcJSON_Before == null ? "" : variables.varLcJSON_Before;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
ConectaProveedores_y_Logs_Wb_GetAuditList_DataActionGetData_Model _varLcGetData = (variables.varLcGetData != null) ? RESTConectaProveedores_y_Logs_Wb_GetAuditList_DataActionGetData_Outputs.ToModel(variables.varLcGetData) : null;
ConectaProveedores_y_Logs_Wb_GetAuditList_ScreenModel screenModel = new ConectaProveedores_y_Logs_Wb_GetAuditList_ScreenModel(inParamOriginId, inParamPeriodInit, inParamPeriodEnd, inParamMaxRecords, inParamShowErrors, varLcStartIndex, varLcShowPopup, varLcJSON_After, varLcJSON_Before, varLcTableSort, _varLcGetData, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
