using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_s_Storage_StorageDeleted_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("StorageList")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_1789507e695396bb66757dd83a78c4b5> ScreenDataSetStorageList;
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


    public static RESTConectaProveedores_s_Storage_StorageDeleted_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_s_Storage_StorageDeleted_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_s_Storage_StorageDeleted_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_s_Storage_StorageDeleted_ScreenModel ToModel() {string varLcKeyword = variables.varLcKeyword == null ? "" : variables.varLcKeyword;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 50 : variables.varLcMaxRecords.Value;
AggregateRecord<RL_860298826198654ea08dbde054bb1413> _ScreenDataSetStorageList = (variables.ScreenDataSetStorageList != null) ? variables.ScreenDataSetStorageList.FromJS((array) => {
return RL_860298826198654ea08dbde054bb1413.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_1789507e695396bb66757dd83a78c4b5.ToStructure);
}
) : null;
ConectaProveedores_s_Storage_StorageDeleted_ScreenModel screenModel = new ConectaProveedores_s_Storage_StorageDeleted_ScreenModel(varLcKeyword, varLcTableSort, varLcStartIndex, varLcMaxRecords, _ScreenDataSetStorageList, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
