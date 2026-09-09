using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_FoliosSAERejected_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetFoliosSAE")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_ba39f6bd3c228aee942545da8b2d8590> ScreenDataSetGetFoliosSAE;
[JsonProperty("l_ColumnJSONVar")]
public string varLcl_ColumnJSONVar;
[JsonProperty("l_CountAfterFetch")]
public int? varLcl_CountAfterFetch;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_StartIndex")]
public int? varLcl_StartIndex;
[JsonProperty("l_TableSort")]
public string varLcl_TableSort;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_FoliosSAERejected_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_FoliosSAERejected_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_FoliosSAERejected_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_FoliosSAERejected_ScreenModel ToModel() {string varLcl_ColumnJSONVar = variables.varLcl_ColumnJSONVar == null ? "" : variables.varLcl_ColumnJSONVar;
int varLcl_CountAfterFetch = variables.varLcl_CountAfterFetch == null ? 0 : variables.varLcl_CountAfterFetch.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
string varLcl_TableSort = variables.varLcl_TableSort == null ? "" : variables.varLcl_TableSort;
AggregateRecord<RL_05510f5a58c68804a13d569cb160e3d1> _ScreenDataSetGetFoliosSAE = (variables.ScreenDataSetGetFoliosSAE != null) ? variables.ScreenDataSetGetFoliosSAE.FromJS((array) => {
return RL_05510f5a58c68804a13d569cb160e3d1.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_ba39f6bd3c228aee942545da8b2d8590.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_FoliosSAERejected_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_FoliosSAERejected_ScreenModel(varLcl_ColumnJSONVar, varLcl_CountAfterFetch, varLcl_ReInvokeToggler, varLcl_StartIndex, varLcl_TableSort, _ScreenDataSetGetFoliosSAE, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
