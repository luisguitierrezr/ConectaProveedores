using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_s_Storage_StorageList_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("StorageList")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_b2edf1939202eb7e60eb499349388514> ScreenDataSetStorageList;
[JsonProperty("Keyword")]
public string varLcKeyword;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("MaxRecords")]
public int? varLcMaxRecords;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_s_Storage_StorageList_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_s_Storage_StorageList_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_s_Storage_StorageList_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_s_Storage_StorageList_ScreenModel ToModel() {string varLcKeyword = variables.varLcKeyword == null ? "" : variables.varLcKeyword;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 50 : variables.varLcMaxRecords.Value;
AggregateRecord<RL_d3db3806acf82f8f2cc8b7a1ac07805b> _ScreenDataSetStorageList = (variables.ScreenDataSetStorageList != null) ? variables.ScreenDataSetStorageList.FromJS((array) => {
return RL_d3db3806acf82f8f2cc8b7a1ac07805b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_b2edf1939202eb7e60eb499349388514.ToStructure);
}
) : null;
ConectaProveedores_s_Storage_StorageList_ScreenModel screenModel = new ConectaProveedores_s_Storage_StorageList_ScreenModel(varLcKeyword, varLcTableSort, varLcStartIndex, varLcMaxRecords, _ScreenDataSetStorageList, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
