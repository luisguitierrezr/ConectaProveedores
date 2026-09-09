using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetApprovalStatuses")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_5e94710ba0de64845af2f9d1cc088302> ScreenDataSetGetApprovalStatuses;
[JsonProperty("GetProposalLinesByProposalId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_b34001d496bee16bcec019df0c313eb6> ScreenDataSetGetProposalLinesByProposalId;
[JsonProperty("GetProposalById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_931c5818c70fb94c867f1591b8f8bd0d> ScreenDataSetGetProposalById;
[JsonProperty("i_ProposalId")]
public long? inParami_ProposalId;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("l_IsSelected")]
public bool? varLcl_IsSelected;
[JsonProperty("l_IsSelectAll")]
public bool? varLcl_IsSelectAll;
[JsonProperty("i_IsShowSelectAll")]
public bool? varLci_IsShowSelectAll;
[JsonProperty("DateTextFormatted")]
public string varLcDateTextFormatted;
[JsonProperty("l_RefeshSideBar")]
public String varLcl_RefeshSideBar;
[JsonProperty("l_ShowUnpayPopup")]
public bool? varLcl_ShowUnpayPopup;
[JsonProperty("l_ProposalLineIdForPopup")]
public long? varLcl_ProposalLineIdForPopup;
[JsonProperty("l_PaymentStatus")]
public int? varLcl_PaymentStatus;
[JsonProperty("l_ShowUnpaidDetailPopup")]
public bool? varLcl_ShowUnpaidDetailPopup;
[JsonProperty("l_ProposalLinelIdUnpaidDetail")]
public long? varLcl_ProposalLinelIdUnpaidDetail;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_ColumnJSONVarGetProposalDetailTreasury")]
public string varLcl_ColumnJSONVarGetProposalDetailTreasury;
[JsonProperty("l_CountAfterFetchGetProposalDetailTreasury")]
public int? varLcl_CountAfterFetchGetProposalDetailTreasury;
[JsonProperty("l_Loading")]
public bool? varLcl_Loading;
[JsonProperty("l_SelectdLogDocumentId")]
public long? varLcl_SelectdLogDocumentId;
[JsonProperty("l_SelectdLogDocumentNumber")]
public string varLcl_SelectdLogDocumentNumber;
[JsonProperty("l_RefeshDocumentSideBar")]
public String varLcl_RefeshDocumentSideBar;
[JsonProperty("l_ClaimEnable")]
public bool? varLcl_ClaimEnable;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel ToModel() {long inParami_ProposalId = variables.inParami_ProposalId == null ? 0L : variables.inParami_ProposalId.Value;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
bool varLcl_IsSelected = variables.varLcl_IsSelected == null ? false : variables.varLcl_IsSelected.Value;
bool varLcl_IsSelectAll = variables.varLcl_IsSelectAll == null ? false : variables.varLcl_IsSelectAll.Value;
bool varLci_IsShowSelectAll = variables.varLci_IsShowSelectAll == null ? false : variables.varLci_IsShowSelectAll.Value;
string varLcDateTextFormatted = variables.varLcDateTextFormatted == null ? "" : variables.varLcDateTextFormatted;
DateTime varLcl_RefeshSideBar = variables.varLcl_RefeshSideBar == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcl_RefeshSideBar, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
bool varLcl_ShowUnpayPopup = variables.varLcl_ShowUnpayPopup == null ? false : variables.varLcl_ShowUnpayPopup.Value;
long varLcl_ProposalLineIdForPopup = variables.varLcl_ProposalLineIdForPopup == null ? 0L : variables.varLcl_ProposalLineIdForPopup.Value;
int varLcl_PaymentStatus = variables.varLcl_PaymentStatus == null ? 0 : variables.varLcl_PaymentStatus.Value;
bool varLcl_ShowUnpaidDetailPopup = variables.varLcl_ShowUnpaidDetailPopup == null ? false : variables.varLcl_ShowUnpaidDetailPopup.Value;
long varLcl_ProposalLinelIdUnpaidDetail = variables.varLcl_ProposalLinelIdUnpaidDetail == null ? 0L : variables.varLcl_ProposalLinelIdUnpaidDetail.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
string varLcl_ColumnJSONVarGetProposalDetailTreasury = variables.varLcl_ColumnJSONVarGetProposalDetailTreasury == null ? "" : variables.varLcl_ColumnJSONVarGetProposalDetailTreasury;
int varLcl_CountAfterFetchGetProposalDetailTreasury = variables.varLcl_CountAfterFetchGetProposalDetailTreasury == null ? 0 : variables.varLcl_CountAfterFetchGetProposalDetailTreasury.Value;
bool varLcl_Loading = variables.varLcl_Loading == null ? false : variables.varLcl_Loading.Value;
long varLcl_SelectdLogDocumentId = variables.varLcl_SelectdLogDocumentId == null ? 0L : variables.varLcl_SelectdLogDocumentId.Value;
string varLcl_SelectdLogDocumentNumber = variables.varLcl_SelectdLogDocumentNumber == null ? "" : variables.varLcl_SelectdLogDocumentNumber;
DateTime varLcl_RefeshDocumentSideBar = variables.varLcl_RefeshDocumentSideBar == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcl_RefeshDocumentSideBar, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
bool varLcl_ClaimEnable = variables.varLcl_ClaimEnable == null ? true : variables.varLcl_ClaimEnable.Value;
AggregateRecord<RL_51a4e63e168a01408e3f55c611518e13> _ScreenDataSetGetApprovalStatuses = (variables.ScreenDataSetGetApprovalStatuses != null) ? variables.ScreenDataSetGetApprovalStatuses.FromJS((array) => {
return RL_51a4e63e168a01408e3f55c611518e13.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_5e94710ba0de64845af2f9d1cc088302.ToStructure);
}
) : null;
AggregateRecord<RL_db80b9f839f0b93373297ec2051fc003> _ScreenDataSetGetProposalLinesByProposalId = (variables.ScreenDataSetGetProposalLinesByProposalId != null) ? variables.ScreenDataSetGetProposalLinesByProposalId.FromJS((array) => {
return RL_db80b9f839f0b93373297ec2051fc003.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_b34001d496bee16bcec019df0c313eb6.ToStructure);
}
) : null;
AggregateRecord<RL_f4591be205d3928a9fe22daf19d979cd> _ScreenDataSetGetProposalById = (variables.ScreenDataSetGetProposalById != null) ? variables.ScreenDataSetGetProposalById.FromJS((array) => {
return RL_f4591be205d3928a9fe22daf19d979cd.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_931c5818c70fb94c867f1591b8f8bd0d.ToStructure);
}
) : null;
ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel screenModel = new ConectaProveedores_b_CyA_TreasuryCommissionsLeasing_ProposalDetailTreasury_ScreenModel(inParami_ProposalId, varLcTableSort, varLcStartIndex, varLcl_IsSelected, varLcl_IsSelectAll, varLci_IsShowSelectAll, varLcDateTextFormatted, varLcl_RefeshSideBar, varLcl_ShowUnpayPopup, varLcl_ProposalLineIdForPopup, varLcl_PaymentStatus, varLcl_ShowUnpaidDetailPopup, varLcl_ProposalLinelIdUnpaidDetail, varLcl_ReInvokeToggler, varLcl_ColumnJSONVarGetProposalDetailTreasury, varLcl_CountAfterFetchGetProposalDetailTreasury, varLcl_Loading, varLcl_SelectdLogDocumentId, varLcl_SelectdLogDocumentNumber, varLcl_RefeshDocumentSideBar, varLcl_ClaimEnable, _ScreenDataSetGetApprovalStatuses, _ScreenDataSetGetProposalLinesByProposalId, _ScreenDataSetGetProposalById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
