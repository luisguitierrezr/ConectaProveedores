using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetApprovalProcessTypes")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_66db0edcff7ea9b0aa258e335add1ccc> ScreenDataSetGetApprovalProcessTypes;
[JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("l_ActiveTab")]
public int? varLcl_ActiveTab;
[JsonProperty("l_IsExecuting")]
public bool? varLcl_IsExecuting;
[JsonProperty("l_Motive")]
public string varLcl_Motive;
[JsonProperty("l_IsValidSearchUserDropdown")]
public bool? varLcl_IsValidSearchUserDropdown;
[JsonProperty("l_SelectedUser")]
public string varLcl_SelectedUser;
[JsonProperty("l_IsValidSearchApprovalProcessDropdown")]
public bool? varLcl_IsValidSearchApprovalProcessDropdown;
[JsonProperty("l_SelectedApprovalProcess")]
public long? varLcl_SelectedApprovalProcess;
[JsonProperty("l_ApprovalProcessTypeSelected")]
public int? varLcl_ApprovalProcessTypeSelected;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ScreenModel ToModel() {long inParami_FolioId = variables.inParami_FolioId == null ? 0L : variables.inParami_FolioId.Value;
int varLcl_ActiveTab = variables.varLcl_ActiveTab == null ? 0 : variables.varLcl_ActiveTab.Value;
bool varLcl_IsExecuting = variables.varLcl_IsExecuting == null ? false : variables.varLcl_IsExecuting.Value;
string varLcl_Motive = variables.varLcl_Motive == null ? "" : variables.varLcl_Motive;
bool varLcl_IsValidSearchUserDropdown = variables.varLcl_IsValidSearchUserDropdown == null ? true : variables.varLcl_IsValidSearchUserDropdown.Value;
string varLcl_SelectedUser = variables.varLcl_SelectedUser == null ? "" : variables.varLcl_SelectedUser;
bool varLcl_IsValidSearchApprovalProcessDropdown = variables.varLcl_IsValidSearchApprovalProcessDropdown == null ? true : variables.varLcl_IsValidSearchApprovalProcessDropdown.Value;
long varLcl_SelectedApprovalProcess = variables.varLcl_SelectedApprovalProcess == null ? 0L : variables.varLcl_SelectedApprovalProcess.Value;
int varLcl_ApprovalProcessTypeSelected = variables.varLcl_ApprovalProcessTypeSelected == null ? 0 : variables.varLcl_ApprovalProcessTypeSelected.Value;
AggregateRecord<RL_aa462092dd42df329d9d5474c2d56c53> _ScreenDataSetGetApprovalProcessTypes = (variables.ScreenDataSetGetApprovalProcessTypes != null) ? variables.ScreenDataSetGetApprovalProcessTypes.FromJS((array) => {
return RL_aa462092dd42df329d9d5474c2d56c53.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_66db0edcff7ea9b0aa258e335add1ccc.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioFromRejectPopup_ScreenModel(inParami_FolioId, varLcl_ActiveTab, varLcl_IsExecuting, varLcl_Motive, varLcl_IsValidSearchUserDropdown, varLcl_SelectedUser, varLcl_IsValidSearchApprovalProcessDropdown, varLcl_SelectedApprovalProcess, varLcl_ApprovalProcessTypeSelected, _ScreenDataSetGetApprovalProcessTypes, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
