using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_OrdersToComplement_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrdersToComplement")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_96ee18663de42b81d96c758873824c1f> ScreenDataSetGetOrdersToComplement;
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
[JsonProperty("l_Loading")]
public bool? varLcl_Loading;
[JsonProperty("l_DaysWithoutAssigmentList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_99fa4277b2264c97bde8f4525bdc92e0> varLcl_DaysWithoutAssigmentList;
[JsonProperty("l_ShowAssignPopUp")]
public ssConectaProveedores.RestRecords.RESTRC_b2bab424cbee127fcb27bb237f9cab05 varLcl_ShowAssignPopUp;
[JsonProperty("l_ShowRejectPopUp")]
public bool? varLcl_ShowRejectPopUp;
[JsonProperty("l_IsSelectAll")]
public bool? varLcl_IsSelectAll;
[JsonProperty("l_IsAnyLineSelected")]
public bool? varLcl_IsAnyLineSelected;
[JsonProperty("IsExecuting")]
public bool? varLcIsExecuting;
[JsonProperty("l_OrderList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_26cbbaf47ee3c0155ebd57237529c97f> varLcl_OrderList;
[JsonProperty("l_OrderIdToReject")]
public long? varLcl_OrderIdToReject;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_OrdersToComplement_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_OrdersToComplement_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_OrdersToComplement_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_OrdersToComplement_ScreenModel ToModel() {string varLcl_TableSort = variables.varLcl_TableSort == null ? "" : variables.varLcl_TableSort;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
string varLcl_ColumnJSONVarGetOrders = variables.varLcl_ColumnJSONVarGetOrders == null ? "" : variables.varLcl_ColumnJSONVarGetOrders;
int varLcl_CountAfterFetchGetOrders = variables.varLcl_CountAfterFetchGetOrders == null ? 0 : variables.varLcl_CountAfterFetchGetOrders.Value;
bool varLcl_Loading = variables.varLcl_Loading == null ? false : variables.varLcl_Loading.Value;
RL_a59fb62a79f0dae5316722bac67c6766 varLcl_DaysWithoutAssigmentList = RL_a59fb62a79f0dae5316722bac67c6766.FromRestList(variables.varLcl_DaysWithoutAssigmentList, ssConectaProveedores.RestRecords.RESTRC_99fa4277b2264c97bde8f4525bdc92e0.ToStructure);
RC_b2bab424cbee127fcb27bb237f9cab05 varLcl_ShowAssignPopUp = ssConectaProveedores.RestRecords.RESTRC_b2bab424cbee127fcb27bb237f9cab05.ToStructure(variables.varLcl_ShowAssignPopUp);
bool varLcl_ShowRejectPopUp = variables.varLcl_ShowRejectPopUp == null ? false : variables.varLcl_ShowRejectPopUp.Value;
bool varLcl_IsSelectAll = variables.varLcl_IsSelectAll == null ? false : variables.varLcl_IsSelectAll.Value;
bool varLcl_IsAnyLineSelected = variables.varLcl_IsAnyLineSelected == null ? false : variables.varLcl_IsAnyLineSelected.Value;
bool varLcIsExecuting = variables.varLcIsExecuting == null ? false : variables.varLcIsExecuting.Value;
RL_e86d03b22fb6d164e868d40e92a28f1a varLcl_OrderList = RL_e86d03b22fb6d164e868d40e92a28f1a.FromRestList(variables.varLcl_OrderList, ssConectaProveedores.RestRecords.RESTRC_26cbbaf47ee3c0155ebd57237529c97f.ToStructure);
long varLcl_OrderIdToReject = variables.varLcl_OrderIdToReject == null ? 0L : variables.varLcl_OrderIdToReject.Value;
AggregateRecord<RL_ae89b43259faf914dcb9547c573c4cd7> _ScreenDataSetGetOrdersToComplement = (variables.ScreenDataSetGetOrdersToComplement != null) ? variables.ScreenDataSetGetOrdersToComplement.FromJS((array) => {
return RL_ae89b43259faf914dcb9547c573c4cd7.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_96ee18663de42b81d96c758873824c1f.ToStructure);
}
) : null;
ConectaProveedores_e_Orders_OrdersToComplement_ScreenModel screenModel = new ConectaProveedores_e_Orders_OrdersToComplement_ScreenModel(varLcl_TableSort, varLcl_StartIndex, varLcl_ReInvokeToggler, varLcl_ColumnJSONVarGetOrders, varLcl_CountAfterFetchGetOrders, varLcl_Loading, varLcl_DaysWithoutAssigmentList, varLcl_ShowAssignPopUp, varLcl_ShowRejectPopUp, varLcl_IsSelectAll, varLcl_IsAnyLineSelected, varLcIsExecuting, varLcl_OrderList, varLcl_OrderIdToReject, _ScreenDataSetGetOrdersToComplement, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
