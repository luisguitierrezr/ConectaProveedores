using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_OrdersApproved_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrdersApprovedFull")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_b4754aede4b6751be05d5ea422ed168c> ScreenDataSetGetOrdersApprovedFull;
[JsonProperty("GetOrdersApproved")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_b4754aede4b6751be05d5ea422ed168c> ScreenDataSetGetOrdersApproved;
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
[JsonProperty("l_ShowOrderApproval")]
public bool? varLcl_ShowOrderApproval;
[JsonProperty("l_OrderIdForPopup")]
public long? varLcl_OrderIdForPopup;
[JsonProperty("IsListFullNeedRefresh")]
public bool? varLcIsListFullNeedRefresh;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_OrdersApproved_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_OrdersApproved_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_OrdersApproved_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_OrdersApproved_ScreenModel ToModel() {string varLcl_TableSort = variables.varLcl_TableSort == null ? "" : variables.varLcl_TableSort;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
string varLcl_ColumnJSONVarGetOrders = variables.varLcl_ColumnJSONVarGetOrders == null ? "" : variables.varLcl_ColumnJSONVarGetOrders;
int varLcl_CountAfterFetchGetOrders = variables.varLcl_CountAfterFetchGetOrders == null ? 0 : variables.varLcl_CountAfterFetchGetOrders.Value;
RL_a59fb62a79f0dae5316722bac67c6766 varLcl_DaysInAssigmentList = RL_a59fb62a79f0dae5316722bac67c6766.FromRestList(variables.varLcl_DaysInAssigmentList, ssConectaProveedores.RestRecords.RESTRC_99fa4277b2264c97bde8f4525bdc92e0.ToStructure);
bool varLcl_ShowOrderApproval = variables.varLcl_ShowOrderApproval == null ? false : variables.varLcl_ShowOrderApproval.Value;
long varLcl_OrderIdForPopup = variables.varLcl_OrderIdForPopup == null ? 0L : variables.varLcl_OrderIdForPopup.Value;
bool varLcIsListFullNeedRefresh = variables.varLcIsListFullNeedRefresh == null ? false : variables.varLcIsListFullNeedRefresh.Value;
AggregateRecord<RL_e72491aae94589c6bfa425f20599b823> _ScreenDataSetGetOrdersApprovedFull = (variables.ScreenDataSetGetOrdersApprovedFull != null) ? variables.ScreenDataSetGetOrdersApprovedFull.FromJS((array) => {
return RL_e72491aae94589c6bfa425f20599b823.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_b4754aede4b6751be05d5ea422ed168c.ToStructure);
}
) : null;
AggregateRecord<RL_e72491aae94589c6bfa425f20599b823> _ScreenDataSetGetOrdersApproved = (variables.ScreenDataSetGetOrdersApproved != null) ? variables.ScreenDataSetGetOrdersApproved.FromJS((array) => {
return RL_e72491aae94589c6bfa425f20599b823.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_b4754aede4b6751be05d5ea422ed168c.ToStructure);
}
) : null;
ConectaProveedores_e_Orders_OrdersApproved_ScreenModel screenModel = new ConectaProveedores_e_Orders_OrdersApproved_ScreenModel(varLcl_TableSort, varLcl_StartIndex, varLcl_ReInvokeToggler, varLcl_ColumnJSONVarGetOrders, varLcl_CountAfterFetchGetOrders, varLcl_DaysInAssigmentList, varLcl_ShowOrderApproval, varLcl_OrderIdForPopup, varLcIsListFullNeedRefresh, _ScreenDataSetGetOrdersApprovedFull, _ScreenDataSetGetOrdersApproved, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
