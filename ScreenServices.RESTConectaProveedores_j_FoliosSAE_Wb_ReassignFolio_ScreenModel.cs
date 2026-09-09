using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetFolioApprovalLevelsByAssignedTo")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_6441282eac0a2260326cac952b2cda40> ScreenDataSetGetFolioApprovalLevelsByAssignedTo;
[JsonProperty("i_IsSidebarOpen")]
public bool? inParami_IsSidebarOpen;
[JsonProperty("i_IsInvoiceApproval")]
public bool? inParami_IsInvoiceApproval;
[JsonProperty("l_Motive")]
public string varLcl_Motive;
[JsonProperty("l_SourceUserId")]
public string varLcl_SourceUserId;
[JsonProperty("l_SubstituteUserId")]
public string varLcl_SubstituteUserId;
[JsonProperty("l_ShowConfirmPopup")]
public bool? varLcl_ShowConfirmPopup;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("MaxRecords")]
public int? varLcMaxRecords;
[JsonProperty("l_IsSelectAll")]
public bool? varLcl_IsSelectAll;
[JsonProperty("l_IsSelect")]
public bool? varLcl_IsSelect;
[JsonProperty("GetUserApplicationRoles")]
public RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_DataActionGetUserApplicationRoles_Outputs varLcGetUserApplicationRoles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ScreenModel ToModel() {bool inParami_IsSidebarOpen = variables.inParami_IsSidebarOpen == null ? false : variables.inParami_IsSidebarOpen.Value;
bool inParami_IsInvoiceApproval = variables.inParami_IsInvoiceApproval == null ? false : variables.inParami_IsInvoiceApproval.Value;
string varLcl_Motive = variables.varLcl_Motive == null ? "" : variables.varLcl_Motive;
string varLcl_SourceUserId = variables.varLcl_SourceUserId == null ? "" : variables.varLcl_SourceUserId;
string varLcl_SubstituteUserId = variables.varLcl_SubstituteUserId == null ? "" : variables.varLcl_SubstituteUserId;
bool varLcl_ShowConfirmPopup = variables.varLcl_ShowConfirmPopup == null ? false : variables.varLcl_ShowConfirmPopup.Value;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 999 : variables.varLcMaxRecords.Value;
bool varLcl_IsSelectAll = variables.varLcl_IsSelectAll == null ? false : variables.varLcl_IsSelectAll.Value;
bool varLcl_IsSelect = variables.varLcl_IsSelect == null ? false : variables.varLcl_IsSelect.Value;
AggregateRecord<RL_c18f46fc1b14374364595e3e32a1c4d4> _ScreenDataSetGetFolioApprovalLevelsByAssignedTo = (variables.ScreenDataSetGetFolioApprovalLevelsByAssignedTo != null) ? variables.ScreenDataSetGetFolioApprovalLevelsByAssignedTo.FromJS((array) => {
return RL_c18f46fc1b14374364595e3e32a1c4d4.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_6441282eac0a2260326cac952b2cda40.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_DataActionGetUserApplicationRoles_Model _varLcGetUserApplicationRoles = (variables.varLcGetUserApplicationRoles != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_DataActionGetUserApplicationRoles_Outputs.ToModel(variables.varLcGetUserApplicationRoles) : null;
ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ScreenModel(inParami_IsSidebarOpen, inParami_IsInvoiceApproval, varLcl_Motive, varLcl_SourceUserId, varLcl_SubstituteUserId, varLcl_ShowConfirmPopup, varLcTableSort, varLcStartIndex, varLcMaxRecords, varLcl_IsSelectAll, varLcl_IsSelect, _ScreenDataSetGetFolioApprovalLevelsByAssignedTo, _varLcGetUserApplicationRoles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
