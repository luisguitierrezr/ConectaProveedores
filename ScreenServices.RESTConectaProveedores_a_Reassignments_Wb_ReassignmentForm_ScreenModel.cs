using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetSourceUserByEntraId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_6783422774b4547f1160d86529102520> ScreenDataSetGetSourceUserByEntraId;
[JsonProperty("i_IsSidebarOpen")]
public bool? inParami_IsSidebarOpen;
[JsonProperty("Search")]
public string varLcSearch;
[JsonProperty("l_IsAllowConfirm")]
public bool? varLcl_IsAllowConfirm;
[JsonProperty("l_SourceUserEntraId")]
public string varLcl_SourceUserEntraId;
[JsonProperty("l_SourceUserId")]
public string varLcl_SourceUserId;
[JsonProperty("l_TargetUserAUEntraId")]
public string varLcl_TargetUserAUEntraId;
[JsonProperty("l_Reason")]
public string varLcl_Reason;
[JsonProperty("GetSourceUserContent")]
public RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetSourceUserContent_Outputs varLcGetSourceUserContent;
[JsonProperty("GetUsersTarget")]
public RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersTarget_Outputs varLcGetUsersTarget;
[JsonProperty("GetUsersSource")]
public RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersSource_Outputs varLcGetUsersSource;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel ToModel() {bool inParami_IsSidebarOpen = variables.inParami_IsSidebarOpen == null ? false : variables.inParami_IsSidebarOpen.Value;
string varLcSearch = variables.varLcSearch == null ? "" : variables.varLcSearch;
bool varLcl_IsAllowConfirm = variables.varLcl_IsAllowConfirm == null ? false : variables.varLcl_IsAllowConfirm.Value;
string varLcl_SourceUserEntraId = variables.varLcl_SourceUserEntraId == null ? "" : variables.varLcl_SourceUserEntraId;
string varLcl_SourceUserId = variables.varLcl_SourceUserId == null ? "" : variables.varLcl_SourceUserId;
string varLcl_TargetUserAUEntraId = variables.varLcl_TargetUserAUEntraId == null ? "" : variables.varLcl_TargetUserAUEntraId;
string varLcl_Reason = variables.varLcl_Reason == null ? "" : variables.varLcl_Reason;
AggregateRecord<RL_3a99147a5a14669e8ced82dd9eebacf0> _ScreenDataSetGetSourceUserByEntraId = (variables.ScreenDataSetGetSourceUserByEntraId != null) ? variables.ScreenDataSetGetSourceUserByEntraId.FromJS((array) => {
return RL_3a99147a5a14669e8ced82dd9eebacf0.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_6783422774b4547f1160d86529102520.ToStructure);
}
) : null;
ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetSourceUserContent_Model _varLcGetSourceUserContent = (variables.varLcGetSourceUserContent != null) ? RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetSourceUserContent_Outputs.ToModel(variables.varLcGetSourceUserContent) : null;
ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersTarget_Model _varLcGetUsersTarget = (variables.varLcGetUsersTarget != null) ? RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersTarget_Outputs.ToModel(variables.varLcGetUsersTarget) : null;
ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersSource_Model _varLcGetUsersSource = (variables.varLcGetUsersSource != null) ? RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetUsersSource_Outputs.ToModel(variables.varLcGetUsersSource) : null;
ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel screenModel = new ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_ScreenModel(inParami_IsSidebarOpen, varLcSearch, varLcl_IsAllowConfirm, varLcl_SourceUserEntraId, varLcl_SourceUserId, varLcl_TargetUserAUEntraId, varLcl_Reason, _ScreenDataSetGetSourceUserByEntraId, _varLcGetSourceUserContent, _varLcGetUsersTarget, _varLcGetUsersSource, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
