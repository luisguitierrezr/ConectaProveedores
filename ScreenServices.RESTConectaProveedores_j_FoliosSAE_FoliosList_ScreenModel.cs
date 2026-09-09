using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_FoliosList_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetFolios")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_f520669a02d9f27d638b5ecc83782607> ScreenDataSetGetFolios;
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


    public static RESTConectaProveedores_j_FoliosSAE_FoliosList_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_FoliosList_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_FoliosList_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_FoliosList_ScreenModel ToModel() {string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 50 : variables.varLcMaxRecords.Value;
AggregateRecord<RL_cb63d2f3bb3714fa686ba5a50757aacf> _ScreenDataSetGetFolios = (variables.ScreenDataSetGetFolios != null) ? variables.ScreenDataSetGetFolios.FromJS((array) => {
return RL_cb63d2f3bb3714fa686ba5a50757aacf.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_f520669a02d9f27d638b5ecc83782607.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_FoliosList_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_FoliosList_ScreenModel(varLcTableSort, varLcStartIndex, varLcMaxRecords, _ScreenDataSetGetFolios, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
