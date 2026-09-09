using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetUserOriginal")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_184336c68155ad9e77005f91e8e8b363> ScreenDataSetGetUserOriginal;
[JsonProperty("GetOrderStatuses")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_919d72dc5292e812597af4fac0a808e4> ScreenDataSetGetOrderStatuses;
[JsonProperty("GetInvoices")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_acb134934352a9d72fd2cc0509d2f469> ScreenDataSetGetInvoices;
[JsonProperty("GetOrderApprovalLevelsByAssignedTo")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_a2ea85a9f362412e4b6f04be74bb4c8a> ScreenDataSetGetOrderApprovalLevelsByAssignedTo;
[JsonProperty("UserOriginal")]
public string varLcUserOriginal;
[JsonProperty("UserSubstitute")]
public string varLcUserSubstitute;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("MaxRecords")]
public int? varLcMaxRecords;
[JsonProperty("OrderNumberFilter")]
public string varLcOrderNumberFilter;
[JsonProperty("OrderStatusId")]
public int? varLcOrderStatusId;
[JsonProperty("GetRequisitions")]
public RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetRequisitions_Outputs varLcGetRequisitions;
[JsonProperty("GetUserApplicationRolesAndMore")]
public RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetUserApplicationRolesAndMore_Outputs varLcGetUserApplicationRolesAndMore;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel ToModel() {string varLcUserOriginal = variables.varLcUserOriginal == null ? "" : variables.varLcUserOriginal;
string varLcUserSubstitute = variables.varLcUserSubstitute == null ? "" : variables.varLcUserSubstitute;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 50 : variables.varLcMaxRecords.Value;
string varLcOrderNumberFilter = variables.varLcOrderNumberFilter == null ? "" : variables.varLcOrderNumberFilter;
int varLcOrderStatusId = variables.varLcOrderStatusId == null ? 0 : variables.varLcOrderStatusId.Value;
AggregateRecord<RL_bc2063fe1d05aa544017f329fb1e030b> _ScreenDataSetGetUserOriginal = (variables.ScreenDataSetGetUserOriginal != null) ? variables.ScreenDataSetGetUserOriginal.FromJS((array) => {
return RL_bc2063fe1d05aa544017f329fb1e030b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_184336c68155ad9e77005f91e8e8b363.ToStructure);
}
) : null;
AggregateRecord<RL_cf716c649767b1312d0b25fa52ff2f38> _ScreenDataSetGetOrderStatuses = (variables.ScreenDataSetGetOrderStatuses != null) ? variables.ScreenDataSetGetOrderStatuses.FromJS((array) => {
return RL_cf716c649767b1312d0b25fa52ff2f38.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_919d72dc5292e812597af4fac0a808e4.ToStructure);
}
) : null;
AggregateRecord<RL_c5ca0a80d78493d156f2b1a68d86a831> _ScreenDataSetGetInvoices = (variables.ScreenDataSetGetInvoices != null) ? variables.ScreenDataSetGetInvoices.FromJS((array) => {
return RL_c5ca0a80d78493d156f2b1a68d86a831.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_acb134934352a9d72fd2cc0509d2f469.ToStructure);
}
) : null;
AggregateRecord<RL_6a0d508a138cc1e49e6d938f0b4069dd> _ScreenDataSetGetOrderApprovalLevelsByAssignedTo = (variables.ScreenDataSetGetOrderApprovalLevelsByAssignedTo != null) ? variables.ScreenDataSetGetOrderApprovalLevelsByAssignedTo.FromJS((array) => {
return RL_6a0d508a138cc1e49e6d938f0b4069dd.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_a2ea85a9f362412e4b6f04be74bb4c8a.ToStructure);
}
) : null;
ConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetRequisitions_Model _varLcGetRequisitions = (variables.varLcGetRequisitions != null) ? RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetRequisitions_Outputs.ToModel(variables.varLcGetRequisitions) : null;
ConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetUserApplicationRolesAndMore_Model _varLcGetUserApplicationRolesAndMore = (variables.varLcGetUserApplicationRolesAndMore != null) ? RESTConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetUserApplicationRolesAndMore_Outputs.ToModel(variables.varLcGetUserApplicationRolesAndMore) : null;
ConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel screenModel = new ConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel(varLcUserOriginal, varLcUserSubstitute, varLcTableSort, varLcStartIndex, varLcMaxRecords, varLcOrderNumberFilter, varLcOrderStatusId, _ScreenDataSetGetUserOriginal, _ScreenDataSetGetOrderStatuses, _ScreenDataSetGetInvoices, _ScreenDataSetGetOrderApprovalLevelsByAssignedTo, _varLcGetRequisitions, _varLcGetUserApplicationRolesAndMore, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
