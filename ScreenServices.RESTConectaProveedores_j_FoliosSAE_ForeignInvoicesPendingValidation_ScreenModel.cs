using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetFolioStatuses")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_c75df7b2e7c6e74a3a45dda7bd7b93e2> ScreenDataSetGetFolioStatuses;
[JsonProperty("GetFolioApprovalLevelsByAssignedTo")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_f71d1ebfeb3771da2f91490300d5ded2> ScreenDataSetGetFolioApprovalLevelsByAssignedTo;
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
[JsonProperty("GetUserData")]
public RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_DataActionGetUserData_Outputs varLcGetUserData;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel ToModel() {string varLcl_ColumnJSONVar = variables.varLcl_ColumnJSONVar == null ? "" : variables.varLcl_ColumnJSONVar;
int varLcl_CountAfterFetch = variables.varLcl_CountAfterFetch == null ? 0 : variables.varLcl_CountAfterFetch.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
string varLcl_TableSort = variables.varLcl_TableSort == null ? "" : variables.varLcl_TableSort;
AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> _ScreenDataSetGetFolioStatuses = (variables.ScreenDataSetGetFolioStatuses != null) ? variables.ScreenDataSetGetFolioStatuses.FromJS((array) => {
return RL_ba9fc810801f4aabee0bc4ef3685a9dd.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_c75df7b2e7c6e74a3a45dda7bd7b93e2.ToStructure);
}
) : null;
AggregateRecord<RL_13a8c992e2340d724ae09e59b85c1da0> _ScreenDataSetGetFolioApprovalLevelsByAssignedTo = (variables.ScreenDataSetGetFolioApprovalLevelsByAssignedTo != null) ? variables.ScreenDataSetGetFolioApprovalLevelsByAssignedTo.FromJS((array) => {
return RL_13a8c992e2340d724ae09e59b85c1da0.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_f71d1ebfeb3771da2f91490300d5ded2.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_DataActionGetUserData_Model _varLcGetUserData = (variables.varLcGetUserData != null) ? RESTConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_DataActionGetUserData_Outputs.ToModel(variables.varLcGetUserData) : null;
ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel(varLcl_ColumnJSONVar, varLcl_CountAfterFetch, varLcl_ReInvokeToggler, varLcl_StartIndex, varLcl_TableSort, _ScreenDataSetGetFolioStatuses, _ScreenDataSetGetFolioApprovalLevelsByAssignedTo, _varLcGetUserData, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
