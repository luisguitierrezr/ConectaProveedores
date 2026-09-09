using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetFolioApprovalLevelById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_e278706027049cb67d7e751f6d362f51> ScreenDataSetGetFolioApprovalLevelById;
[JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("i_DirectReport")]
public bool? inParami_DirectReport;
[JsonProperty("l_PopupTitle")]
public string varLcl_PopupTitle;
[JsonProperty("l_ShowPopUp")]
public bool? varLcl_ShowPopUp;
[JsonProperty("l_ShowApprovePopup")]
public bool? varLcl_ShowApprovePopup;
[JsonProperty("l_ShowEstablishFlowPopup")]
public bool? varLcl_ShowEstablishFlowPopup;
[JsonProperty("l_ShowReassignPopup")]
public bool? varLcl_ShowReassignPopup;
[JsonProperty("l_ShowCompleteEntryPopup")]
public bool? varLcl_ShowCompleteEntryPopup;
[JsonProperty("l_ShowResendEntryPopup")]
public bool? varLcl_ShowResendEntryPopup;
[JsonProperty("l_EvidenceRequest")]
public bool? varLcl_EvidenceRequest;
[JsonProperty("l_Reject")]
public bool? varLcl_Reject;
[JsonProperty("l_Comment")]
public bool? varLcl_Comment;
[JsonProperty("l_Cancel")]
public bool? varLcl_Cancel;
[JsonProperty("l_IsFirstApprover")]
public bool? varLcl_IsFirstApprover;
[JsonProperty("I_ShowCancelPopup")]
public bool? varLcI_ShowCancelPopup;
[JsonProperty("l_ShowIncorrectAssignmentPopup")]
public bool? varLcl_ShowIncorrectAssignmentPopup;
[JsonProperty("l_ShowReassignFolioFromRejectPopup")]
public bool? varLcl_ShowReassignFolioFromRejectPopup;
[JsonProperty("GetFolioTypeDA")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetFolioTypeDA_Outputs varLcGetFolioTypeDA;
[JsonProperty("GetUserInfo")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserInfo_Outputs varLcGetUserInfo;
[JsonProperty("GetUserApplicationRoles")]
public RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserApplicationRoles_Outputs varLcGetUserApplicationRoles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel ToModel() {long inParami_FolioId = variables.inParami_FolioId == null ? 0L : variables.inParami_FolioId.Value;
bool inParami_DirectReport = variables.inParami_DirectReport == null ? false : variables.inParami_DirectReport.Value;
string varLcl_PopupTitle = variables.varLcl_PopupTitle == null ? "" : variables.varLcl_PopupTitle;
bool varLcl_ShowPopUp = variables.varLcl_ShowPopUp == null ? false : variables.varLcl_ShowPopUp.Value;
bool varLcl_ShowApprovePopup = variables.varLcl_ShowApprovePopup == null ? false : variables.varLcl_ShowApprovePopup.Value;
bool varLcl_ShowEstablishFlowPopup = variables.varLcl_ShowEstablishFlowPopup == null ? false : variables.varLcl_ShowEstablishFlowPopup.Value;
bool varLcl_ShowReassignPopup = variables.varLcl_ShowReassignPopup == null ? false : variables.varLcl_ShowReassignPopup.Value;
bool varLcl_ShowCompleteEntryPopup = variables.varLcl_ShowCompleteEntryPopup == null ? false : variables.varLcl_ShowCompleteEntryPopup.Value;
bool varLcl_ShowResendEntryPopup = variables.varLcl_ShowResendEntryPopup == null ? false : variables.varLcl_ShowResendEntryPopup.Value;
bool varLcl_EvidenceRequest = variables.varLcl_EvidenceRequest == null ? false : variables.varLcl_EvidenceRequest.Value;
bool varLcl_Reject = variables.varLcl_Reject == null ? false : variables.varLcl_Reject.Value;
bool varLcl_Comment = variables.varLcl_Comment == null ? false : variables.varLcl_Comment.Value;
bool varLcl_Cancel = variables.varLcl_Cancel == null ? false : variables.varLcl_Cancel.Value;
bool varLcl_IsFirstApprover = variables.varLcl_IsFirstApprover == null ? false : variables.varLcl_IsFirstApprover.Value;
bool varLcI_ShowCancelPopup = variables.varLcI_ShowCancelPopup == null ? false : variables.varLcI_ShowCancelPopup.Value;
bool varLcl_ShowIncorrectAssignmentPopup = variables.varLcl_ShowIncorrectAssignmentPopup == null ? false : variables.varLcl_ShowIncorrectAssignmentPopup.Value;
bool varLcl_ShowReassignFolioFromRejectPopup = variables.varLcl_ShowReassignFolioFromRejectPopup == null ? false : variables.varLcl_ShowReassignFolioFromRejectPopup.Value;
AggregateRecord<RL_eed3c87ea3369e022265db9ef075a8c7> _ScreenDataSetGetFolioApprovalLevelById = (variables.ScreenDataSetGetFolioApprovalLevelById != null) ? variables.ScreenDataSetGetFolioApprovalLevelById.FromJS((array) => {
return RL_eed3c87ea3369e022265db9ef075a8c7.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_e278706027049cb67d7e751f6d362f51.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetFolioTypeDA_Model _varLcGetFolioTypeDA = (variables.varLcGetFolioTypeDA != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetFolioTypeDA_Outputs.ToModel(variables.varLcGetFolioTypeDA) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserInfo_Model _varLcGetUserInfo = (variables.varLcGetUserInfo != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserInfo_Outputs.ToModel(variables.varLcGetUserInfo) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserApplicationRoles_Model _varLcGetUserApplicationRoles = (variables.varLcGetUserApplicationRoles != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_FolioActions_DataActionGetUserApplicationRoles_Outputs.ToModel(variables.varLcGetUserApplicationRoles) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_FolioActions_ScreenModel(inParami_FolioId, inParami_DirectReport, varLcl_PopupTitle, varLcl_ShowPopUp, varLcl_ShowApprovePopup, varLcl_ShowEstablishFlowPopup, varLcl_ShowReassignPopup, varLcl_ShowCompleteEntryPopup, varLcl_ShowResendEntryPopup, varLcl_EvidenceRequest, varLcl_Reject, varLcl_Comment, varLcl_Cancel, varLcl_IsFirstApprover, varLcI_ShowCancelPopup, varLcl_ShowIncorrectAssignmentPopup, varLcl_ShowReassignFolioFromRejectPopup, _ScreenDataSetGetFolioApprovalLevelById, _varLcGetFolioTypeDA, _varLcGetUserInfo, _varLcGetUserApplicationRoles, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
