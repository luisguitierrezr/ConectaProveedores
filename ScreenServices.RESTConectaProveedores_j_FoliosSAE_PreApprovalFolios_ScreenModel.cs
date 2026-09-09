using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_PreApprovalFolios_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetPreApprovalFolios")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_e2b9f65e0c0c00d0e673b5a8e6e47435> ScreenDataSetGetPreApprovalFolios;
[JsonProperty("GetRegions")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0> ScreenDataSetGetRegions;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_ColumnJSONVar")]
public string varLcl_ColumnJSONVar;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_PreApprovalFolios_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_PreApprovalFolios_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_PreApprovalFolios_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_PreApprovalFolios_ScreenModel ToModel() {string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
string varLcl_ColumnJSONVar = variables.varLcl_ColumnJSONVar == null ? "" : variables.varLcl_ColumnJSONVar;
AggregateRecord<RL_e9c01eb22ad9114f17ae2b674328008c> _ScreenDataSetGetPreApprovalFolios = (variables.ScreenDataSetGetPreApprovalFolios != null) ? variables.ScreenDataSetGetPreApprovalFolios.FromJS((array) => {
return RL_e9c01eb22ad9114f17ae2b674328008c.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_e2b9f65e0c0c00d0e673b5a8e6e47435.ToStructure);
}
) : null;
AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> _ScreenDataSetGetRegions = (variables.ScreenDataSetGetRegions != null) ? variables.ScreenDataSetGetRegions.FromJS((array) => {
return RL_5d3a02aa993c7474297e33d992f39ad0.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_deb85dc36640fa928dae5df2493065d0.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_PreApprovalFolios_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_PreApprovalFolios_ScreenModel(varLcTableSort, varLcStartIndex, varLcl_ReInvokeToggler, varLcl_ColumnJSONVar, _ScreenDataSetGetPreApprovalFolios, _ScreenDataSetGetRegions, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
