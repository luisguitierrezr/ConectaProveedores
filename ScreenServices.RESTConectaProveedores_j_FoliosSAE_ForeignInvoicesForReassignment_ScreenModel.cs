using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesForReassignment_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetReassignments")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_234ff55477e8affa6c928b8c8c03aedb> ScreenDataSetGetReassignments;
[JsonProperty("l_IsSidebarOpen")]
public bool? varLcl_IsSidebarOpen;
[JsonProperty("NotifContent")]
public ssConectaProveedores.RestRecords.RESTST_6fc999fa8f6e0055c73f2f167c4bad19Structure varLcNotifContent;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("l_ColumnJSONVar")]
public string varLcl_ColumnJSONVar;
[JsonProperty("l_CountAfterFetch")]
public int? varLcl_CountAfterFetch;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesForReassignment_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesForReassignment_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesForReassignment_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_ForeignInvoicesForReassignment_ScreenModel ToModel() {bool varLcl_IsSidebarOpen = variables.varLcl_IsSidebarOpen == null ? false : variables.varLcl_IsSidebarOpen.Value;
ST_6fc999fa8f6e0055c73f2f167c4bad19Structure varLcNotifContent = ssConectaProveedores.RestRecords.RESTST_6fc999fa8f6e0055c73f2f167c4bad19Structure.ToStructure(variables.varLcNotifContent);
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
string varLcl_ColumnJSONVar = variables.varLcl_ColumnJSONVar == null ? "" : variables.varLcl_ColumnJSONVar;
int varLcl_CountAfterFetch = variables.varLcl_CountAfterFetch == null ? 0 : variables.varLcl_CountAfterFetch.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
AggregateRecord<RL_4d1a87a21136b2184fa5a9ef787f7fd6> _ScreenDataSetGetReassignments = (variables.ScreenDataSetGetReassignments != null) ? variables.ScreenDataSetGetReassignments.FromJS((array) => {
return RL_4d1a87a21136b2184fa5a9ef787f7fd6.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_234ff55477e8affa6c928b8c8c03aedb.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_ForeignInvoicesForReassignment_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_ForeignInvoicesForReassignment_ScreenModel(varLcl_IsSidebarOpen, varLcNotifContent, varLcTableSort, varLcStartIndex, varLcl_ColumnJSONVar, varLcl_CountAfterFetch, varLcl_ReInvokeToggler, _ScreenDataSetGetReassignments, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
