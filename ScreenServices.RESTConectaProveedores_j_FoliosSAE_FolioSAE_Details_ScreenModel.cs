using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetFolioItemsByFolioId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_95110bc97f34f4c1561c8cbf2b5015b2> ScreenDataSetGetFolioItemsByFolioId;
[JsonProperty("GetFolioApprovalRejectReason")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_131b941598d8581e5466dbb966f5f0a8> ScreenDataSetGetFolioApprovalRejectReason;
[JsonProperty("GetFolioComments")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_017cba02e4fd7f684606081b7269a26b> ScreenDataSetGetFolioComments;
[JsonProperty("GetFirstApproval")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_d41d580f2f54d1ea8dfa839824757d81> ScreenDataSetGetFirstApproval;
[JsonProperty("GetFolioById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_619a3314c0f5e7503d1faa5bd2f55a41> ScreenDataSetGetFolioById;
[JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("i_IsDirectReport")]
public bool? inParami_IsDirectReport;
[JsonProperty("l_RefreshOrderEntra_Historic")]
public String varLcl_RefreshOrderEntra_Historic;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("MaxRecords")]
public int? varLcMaxRecords;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("ShowCancelPopup")]
public bool? varLcShowCancelPopup;
[JsonProperty("GetUserApplicationRoles")]
public RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetUserApplicationRoles_Outputs varLcGetUserApplicationRoles;
[JsonProperty("GetRejectComment")]
public RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetRejectComment_Outputs varLcGetRejectComment;
[JsonProperty("GetFolioApprovalDisplay")]
public RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetFolioApprovalDisplay_Outputs varLcGetFolioApprovalDisplay;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel ToModel() {long inParami_FolioId = variables.inParami_FolioId == null ? 0L : variables.inParami_FolioId.Value;
bool inParami_IsDirectReport = variables.inParami_IsDirectReport == null ? false : variables.inParami_IsDirectReport.Value;
DateTime varLcl_RefreshOrderEntra_Historic = variables.varLcl_RefreshOrderEntra_Historic == null ? BuiltInFunction.CurrDateTime () : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcl_RefreshOrderEntra_Historic, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 50 : variables.varLcMaxRecords.Value;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
bool varLcShowCancelPopup = variables.varLcShowCancelPopup == null ? false : variables.varLcShowCancelPopup.Value;
AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> _ScreenDataSetGetFolioItemsByFolioId = (variables.ScreenDataSetGetFolioItemsByFolioId != null) ? variables.ScreenDataSetGetFolioItemsByFolioId.FromJS((array) => {
return RL_a968cf9f63475dc9358672149b11245a.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_95110bc97f34f4c1561c8cbf2b5015b2.ToStructure);
}
) : null;
AggregateRecord<RL_52e01c48f1745de5266c16d6fe2c0564> _ScreenDataSetGetFolioApprovalRejectReason = (variables.ScreenDataSetGetFolioApprovalRejectReason != null) ? variables.ScreenDataSetGetFolioApprovalRejectReason.FromJS((array) => {
return RL_52e01c48f1745de5266c16d6fe2c0564.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_131b941598d8581e5466dbb966f5f0a8.ToStructure);
}
) : null;
AggregateRecord<RL_994583bfe1c92160ce9fe58b4f4e0d70> _ScreenDataSetGetFolioComments = (variables.ScreenDataSetGetFolioComments != null) ? variables.ScreenDataSetGetFolioComments.FromJS((array) => {
return RL_994583bfe1c92160ce9fe58b4f4e0d70.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_017cba02e4fd7f684606081b7269a26b.ToStructure);
}
) : null;
AggregateRecord<RL_c4a88225f641d9bcf04728601a4668b7> _ScreenDataSetGetFirstApproval = (variables.ScreenDataSetGetFirstApproval != null) ? variables.ScreenDataSetGetFirstApproval.FromJS((array) => {
return RL_c4a88225f641d9bcf04728601a4668b7.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_d41d580f2f54d1ea8dfa839824757d81.ToStructure);
}
) : null;
AggregateRecord<RL_a73c6a3c39840602048be2cd6d699c01> _ScreenDataSetGetFolioById = (variables.ScreenDataSetGetFolioById != null) ? variables.ScreenDataSetGetFolioById.FromJS((array) => {
return RL_a73c6a3c39840602048be2cd6d699c01.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_619a3314c0f5e7503d1faa5bd2f55a41.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetUserApplicationRoles_Model _varLcGetUserApplicationRoles = (variables.varLcGetUserApplicationRoles != null) ? RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetUserApplicationRoles_Outputs.ToModel(variables.varLcGetUserApplicationRoles) : null;
ConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetRejectComment_Model _varLcGetRejectComment = (variables.varLcGetRejectComment != null) ? RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetRejectComment_Outputs.ToModel(variables.varLcGetRejectComment) : null;
ConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetFolioApprovalDisplay_Model _varLcGetFolioApprovalDisplay = (variables.varLcGetFolioApprovalDisplay != null) ? RESTConectaProveedores_j_FoliosSAE_FolioSAE_Details_DataActionGetFolioApprovalDisplay_Outputs.ToModel(variables.varLcGetFolioApprovalDisplay) : null;
ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_FolioSAE_Details_ScreenModel(inParami_FolioId, inParami_IsDirectReport, varLcl_RefreshOrderEntra_Historic, varLcStartIndex, varLcMaxRecords, varLcTableSort, varLcShowCancelPopup, _ScreenDataSetGetFolioItemsByFolioId, _ScreenDataSetGetFolioApprovalRejectReason, _ScreenDataSetGetFolioComments, _ScreenDataSetGetFirstApproval, _ScreenDataSetGetFolioById, _varLcGetUserApplicationRoles, _varLcGetRejectComment, _varLcGetFolioApprovalDisplay, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
