using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_wb_documentExtrationBySupplier_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInvoiceFiles")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_cfb4b5cbc9f75e782e7f32736dbeac24> ScreenDataSetGetInvoiceFiles;
[JsonProperty("SupplierId")]
public long? varLcSupplierId;
[JsonProperty("Keyword")]
public string varLcKeyword;
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

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_g_Reports_wb_documentExtrationBySupplier_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_g_Reports_wb_documentExtrationBySupplier_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_g_Reports_wb_documentExtrationBySupplier_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_g_Reports_wb_documentExtrationBySupplier_ScreenModel ToModel() {long varLcSupplierId = variables.varLcSupplierId == null ? 0L : variables.varLcSupplierId.Value;
string varLcKeyword = variables.varLcKeyword == null ? "" : variables.varLcKeyword;
DateTime varLcDateStart = variables.varLcDateStart == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcDateStart, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
DateTime varLcDateEnd = variables.varLcDateEnd == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcDateEnd, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 50 : variables.varLcMaxRecords.Value;
long varLcStorageId = variables.varLcStorageId == null ? 0L : variables.varLcStorageId.Value;
bool varLcIsSelectOne = variables.varLcIsSelectOne == null ? false : variables.varLcIsSelectOne.Value;
DateTime varLcForceRefresh = variables.varLcForceRefresh == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcForceRefresh, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
AggregateRecord<RL_9cdf1789e965682ff9f78e76a5697073> _ScreenDataSetGetInvoiceFiles = (variables.ScreenDataSetGetInvoiceFiles != null) ? variables.ScreenDataSetGetInvoiceFiles.FromJS((array) => {
return RL_9cdf1789e965682ff9f78e76a5697073.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_cfb4b5cbc9f75e782e7f32736dbeac24.ToStructure);
}
) : null;
ConectaProveedores_g_Reports_wb_documentExtrationBySupplier_ScreenModel screenModel = new ConectaProveedores_g_Reports_wb_documentExtrationBySupplier_ScreenModel(varLcSupplierId, varLcKeyword, varLcDateStart, varLcDateEnd, varLcTableSort, varLcStartIndex, varLcMaxRecords, varLcStorageId, varLcIsSelectOne, varLcForceRefresh, _ScreenDataSetGetInvoiceFiles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
