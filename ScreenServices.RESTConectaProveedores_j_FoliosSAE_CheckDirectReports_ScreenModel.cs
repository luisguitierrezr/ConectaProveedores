using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_CheckDirectReports_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("l_ColumnJSONVar")]
public string varLcl_ColumnJSONVar;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_TableSort")]
public string varLcl_TableSort;
[JsonProperty("l_StartIndex")]
public int? varLcl_StartIndex;
[JsonProperty("GetFolios")]
public RESTConectaProveedores_j_FoliosSAE_CheckDirectReports_DataActionGetFolios_Outputs varLcGetFolios;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_CheckDirectReports_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_CheckDirectReports_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_CheckDirectReports_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_CheckDirectReports_ScreenModel ToModel() {string varLcl_ColumnJSONVar = variables.varLcl_ColumnJSONVar == null ? "" : variables.varLcl_ColumnJSONVar;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
string varLcl_TableSort = variables.varLcl_TableSort == null ? "" : variables.varLcl_TableSort;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
ConectaProveedores_j_FoliosSAE_CheckDirectReports_DataActionGetFolios_Model _varLcGetFolios = (variables.varLcGetFolios != null) ? RESTConectaProveedores_j_FoliosSAE_CheckDirectReports_DataActionGetFolios_Outputs.ToModel(variables.varLcGetFolios) : null;
ConectaProveedores_j_FoliosSAE_CheckDirectReports_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_CheckDirectReports_ScreenModel(varLcl_ColumnJSONVar, varLcl_ReInvokeToggler, varLcl_TableSort, varLcl_StartIndex, _varLcGetFolios, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
