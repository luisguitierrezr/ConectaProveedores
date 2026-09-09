using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_OrdersInComplement_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrdersInComplementFull")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_d18f18b6c2e290ef15fc1a9c5cb968d2> ScreenDataSetGetOrdersInComplementFull;
[JsonProperty("GetOrdersInComplement")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_d18f18b6c2e290ef15fc1a9c5cb968d2> ScreenDataSetGetOrdersInComplement;
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
[JsonProperty("l_DaysInAssigmentList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_99fa4277b2264c97bde8f4525bdc92e0> varLcl_DaysInAssigmentList;
[JsonProperty("IsListFullNeedRefresh")]
public bool? varLcIsListFullNeedRefresh;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_OrdersInComplement_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_OrdersInComplement_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_OrdersInComplement_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_OrdersInComplement_ScreenModel ToModel() {string varLcl_TableSort = variables.varLcl_TableSort == null ? "" : variables.varLcl_TableSort;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
string varLcl_ColumnJSONVarGetOrders = variables.varLcl_ColumnJSONVarGetOrders == null ? "" : variables.varLcl_ColumnJSONVarGetOrders;
int varLcl_CountAfterFetchGetOrders = variables.varLcl_CountAfterFetchGetOrders == null ? 0 : variables.varLcl_CountAfterFetchGetOrders.Value;
bool varLcl_Loading = variables.varLcl_Loading == null ? false : variables.varLcl_Loading.Value;
RL_a59fb62a79f0dae5316722bac67c6766 varLcl_DaysInAssigmentList = RL_a59fb62a79f0dae5316722bac67c6766.FromRestList(variables.varLcl_DaysInAssigmentList, ssConectaProveedores.RestRecords.RESTRC_99fa4277b2264c97bde8f4525bdc92e0.ToStructure);
bool varLcIsListFullNeedRefresh = variables.varLcIsListFullNeedRefresh == null ? false : variables.varLcIsListFullNeedRefresh.Value;
AggregateRecord<RL_b7a22557f49e97dcd2b91bca0c98fab2> _ScreenDataSetGetOrdersInComplementFull = (variables.ScreenDataSetGetOrdersInComplementFull != null) ? variables.ScreenDataSetGetOrdersInComplementFull.FromJS((array) => {
return RL_b7a22557f49e97dcd2b91bca0c98fab2.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_d18f18b6c2e290ef15fc1a9c5cb968d2.ToStructure);
}
) : null;
AggregateRecord<RL_b7a22557f49e97dcd2b91bca0c98fab2> _ScreenDataSetGetOrdersInComplement = (variables.ScreenDataSetGetOrdersInComplement != null) ? variables.ScreenDataSetGetOrdersInComplement.FromJS((array) => {
return RL_b7a22557f49e97dcd2b91bca0c98fab2.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_d18f18b6c2e290ef15fc1a9c5cb968d2.ToStructure);
}
) : null;
ConectaProveedores_e_Orders_OrdersInComplement_ScreenModel screenModel = new ConectaProveedores_e_Orders_OrdersInComplement_ScreenModel(varLcl_TableSort, varLcl_StartIndex, varLcl_ReInvokeToggler, varLcl_ColumnJSONVarGetOrders, varLcl_CountAfterFetchGetOrders, varLcl_Loading, varLcl_DaysInAssigmentList, varLcIsListFullNeedRefresh, _ScreenDataSetGetOrdersInComplementFull, _ScreenDataSetGetOrdersInComplement, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
