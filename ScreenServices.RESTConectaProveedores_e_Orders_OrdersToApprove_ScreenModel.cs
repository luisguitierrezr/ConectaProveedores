using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_OrdersToApprove_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrdersToApprove")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_0a41c52434474d75060edec9b8b557c0> ScreenDataSetGetOrdersToApprove;
[JsonProperty("l_TableSort")]
public string varLcl_TableSort;
[JsonProperty("l_StartIndex")]
public int? varLcl_StartIndex;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_ColumnJSONVarGetOrders")]
public string varLcl_ColumnJSONVarGetOrders;
[JsonProperty("l_CountAfterFetchGetOrders")]
public int? varLcl_CountAfterFetchGetOrders;
[JsonProperty("l_DaysInAssigmentList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_99fa4277b2264c97bde8f4525bdc92e0> varLcl_DaysInAssigmentList;
[JsonProperty("l_IsSelectAll")]
public bool? varLcl_IsSelectAll;
[JsonProperty("l_IsAnyLineSelected")]
public bool? varLcl_IsAnyLineSelected;
[JsonProperty("l_ShowBulkApproveOrders")]
public bool? varLcl_ShowBulkApproveOrders;
[JsonProperty("l_OrderApprovalLevelList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_6a01c4ef1c8f90eed41c7255c682f6e0> varLcl_OrderApprovalLevelList;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_OrdersToApprove_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_OrdersToApprove_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_OrdersToApprove_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_OrdersToApprove_ScreenModel ToModel() {string varLcl_TableSort = variables.varLcl_TableSort == null ? "" : variables.varLcl_TableSort;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
string varLcl_ColumnJSONVarGetOrders = variables.varLcl_ColumnJSONVarGetOrders == null ? "" : variables.varLcl_ColumnJSONVarGetOrders;
int varLcl_CountAfterFetchGetOrders = variables.varLcl_CountAfterFetchGetOrders == null ? 0 : variables.varLcl_CountAfterFetchGetOrders.Value;
RL_a59fb62a79f0dae5316722bac67c6766 varLcl_DaysInAssigmentList = RL_a59fb62a79f0dae5316722bac67c6766.FromRestList(variables.varLcl_DaysInAssigmentList, ssConectaProveedores.RestRecords.RESTRC_99fa4277b2264c97bde8f4525bdc92e0.ToStructure);
bool varLcl_IsSelectAll = variables.varLcl_IsSelectAll == null ? false : variables.varLcl_IsSelectAll.Value;
bool varLcl_IsAnyLineSelected = variables.varLcl_IsAnyLineSelected == null ? false : variables.varLcl_IsAnyLineSelected.Value;
bool varLcl_ShowBulkApproveOrders = variables.varLcl_ShowBulkApproveOrders == null ? false : variables.varLcl_ShowBulkApproveOrders.Value;
RL_8fd60efb0627be3c248dd395b7512757 varLcl_OrderApprovalLevelList = RL_8fd60efb0627be3c248dd395b7512757.FromRestList(variables.varLcl_OrderApprovalLevelList, ssConectaProveedores.RestRecords.RESTRC_6a01c4ef1c8f90eed41c7255c682f6e0.ToStructure);
AggregateRecord<RL_7394c44f189d8cb48f64219bbd82b88d> _ScreenDataSetGetOrdersToApprove = (variables.ScreenDataSetGetOrdersToApprove != null) ? variables.ScreenDataSetGetOrdersToApprove.FromJS((array) => {
return RL_7394c44f189d8cb48f64219bbd82b88d.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_0a41c52434474d75060edec9b8b557c0.ToStructure);
}
) : null;
ConectaProveedores_e_Orders_OrdersToApprove_ScreenModel screenModel = new ConectaProveedores_e_Orders_OrdersToApprove_ScreenModel(varLcl_TableSort, varLcl_StartIndex, varLcl_ReInvokeToggler, varLcl_ColumnJSONVarGetOrders, varLcl_CountAfterFetchGetOrders, varLcl_DaysInAssigmentList, varLcl_IsSelectAll, varLcl_IsAnyLineSelected, varLcl_ShowBulkApproveOrders, varLcl_OrderApprovalLevelList, _ScreenDataSetGetOrdersToApprove, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
