using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_SupportSAEUpload_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetSupplierUsersByUserId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_187912d0df64c67be181be3d4f7af5f3> ScreenDataSetGetSupplierUsersByUserId;
[JsonProperty("ErrorMsg")]
public string varLcErrorMsg;
[JsonProperty("FilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> varLcFilesList;
[JsonProperty("HasChanged")]
public bool? varLcHasChanged;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_SupportSAEUpload_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_SupportSAEUpload_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_SupportSAEUpload_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUpload_ScreenModel ToModel() {string varLcErrorMsg = variables.varLcErrorMsg == null ? "" : variables.varLcErrorMsg;
RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.varLcFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
bool varLcHasChanged = variables.varLcHasChanged == null ? false : variables.varLcHasChanged.Value;
AggregateRecord<RL_5a0829a2b3c6573471cd9bfcbf323787> _ScreenDataSetGetSupplierUsersByUserId = (variables.ScreenDataSetGetSupplierUsersByUserId != null) ? variables.ScreenDataSetGetSupplierUsersByUserId.FromJS((array) => {
return RL_5a0829a2b3c6573471cd9bfcbf323787.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_187912d0df64c67be181be3d4f7af5f3.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUpload_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUpload_ScreenModel(varLcErrorMsg, varLcFilesList, varLcHasChanged, _ScreenDataSetGetSupplierUsersByUserId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
