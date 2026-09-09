using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_wb_documentExtrationFiles_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("FileName")]
public string varLcFileName;
[JsonProperty("DateStart")]
public String varLcDateStart;
[JsonProperty("DateEnd")]
public String varLcDateEnd;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("MaxRecords")]
public int? varLcMaxRecords;
[JsonProperty("StorageId")]
public long? varLcStorageId;
[JsonProperty("IsSelectOne")]
public bool? varLcIsSelectOne;
[JsonProperty("ForceRefresh")]
public String varLcForceRefresh;
[JsonProperty("ClickedCollum")]
public string varLcClickedCollum;
[JsonProperty("GetAllFiles")]
public RESTConectaProveedores_g_Reports_wb_documentExtrationFiles_DataActionGetAllFiles_Outputs varLcGetAllFiles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_g_Reports_wb_documentExtrationFiles_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_g_Reports_wb_documentExtrationFiles_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_g_Reports_wb_documentExtrationFiles_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_g_Reports_wb_documentExtrationFiles_ScreenModel ToModel() {string varLcFileName = variables.varLcFileName == null ? "" : variables.varLcFileName;
DateTime varLcDateStart = variables.varLcDateStart == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcDateStart, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
DateTime varLcDateEnd = variables.varLcDateEnd == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcDateEnd, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 50 : variables.varLcMaxRecords.Value;
long varLcStorageId = variables.varLcStorageId == null ? 0L : variables.varLcStorageId.Value;
bool varLcIsSelectOne = variables.varLcIsSelectOne == null ? false : variables.varLcIsSelectOne.Value;
DateTime varLcForceRefresh = variables.varLcForceRefresh == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcForceRefresh, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
string varLcClickedCollum = variables.varLcClickedCollum == null ? "" : variables.varLcClickedCollum;
ConectaProveedores_g_Reports_wb_documentExtrationFiles_DataActionGetAllFiles_Model _varLcGetAllFiles = (variables.varLcGetAllFiles != null) ? RESTConectaProveedores_g_Reports_wb_documentExtrationFiles_DataActionGetAllFiles_Outputs.ToModel(variables.varLcGetAllFiles) : null;
ConectaProveedores_g_Reports_wb_documentExtrationFiles_ScreenModel screenModel = new ConectaProveedores_g_Reports_wb_documentExtrationFiles_ScreenModel(varLcFileName, varLcDateStart, varLcDateEnd, varLcTableSort, varLcStartIndex, varLcMaxRecords, varLcStorageId, varLcIsSelectOne, varLcForceRefresh, varLcClickedCollum, _varLcGetAllFiles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
