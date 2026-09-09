using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_OrdersRequestErrorDistribution_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrdersWithErrors")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_f100e5d5057b18be95e8602dfe9dd2af> ScreenDataSetGetOrdersWithErrors;
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
[JsonProperty("l_Refresh")]
public String varLcl_Refresh;
[JsonProperty("l_OrderMainId")]
public long? varLcl_OrderMainId;
[JsonProperty("l_LogsPopUp")]
public bool? varLcl_LogsPopUp;
[JsonProperty("l_DistributionPopUp")]
public bool? varLcl_DistributionPopUp;
[JsonProperty("l_OrderNumber")]
public string varLcl_OrderNumber;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_OrdersRequestErrorDistribution_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_OrdersRequestErrorDistribution_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_OrdersRequestErrorDistribution_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_OrdersRequestErrorDistribution_ScreenModel ToModel() {string varLcl_TableSort = variables.varLcl_TableSort == null ? "" : variables.varLcl_TableSort;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
string varLcl_ColumnJSONVarGetOrders = variables.varLcl_ColumnJSONVarGetOrders == null ? "" : variables.varLcl_ColumnJSONVarGetOrders;
int varLcl_CountAfterFetchGetOrders = variables.varLcl_CountAfterFetchGetOrders == null ? 0 : variables.varLcl_CountAfterFetchGetOrders.Value;
bool varLcl_Loading = variables.varLcl_Loading == null ? false : variables.varLcl_Loading.Value;
RL_a59fb62a79f0dae5316722bac67c6766 varLcl_DaysInAssigmentList = RL_a59fb62a79f0dae5316722bac67c6766.FromRestList(variables.varLcl_DaysInAssigmentList, ssConectaProveedores.RestRecords.RESTRC_99fa4277b2264c97bde8f4525bdc92e0.ToStructure);
DateTime varLcl_Refresh = variables.varLcl_Refresh == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcl_Refresh, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
long varLcl_OrderMainId = variables.varLcl_OrderMainId == null ? 0L : variables.varLcl_OrderMainId.Value;
bool varLcl_LogsPopUp = variables.varLcl_LogsPopUp == null ? false : variables.varLcl_LogsPopUp.Value;
bool varLcl_DistributionPopUp = variables.varLcl_DistributionPopUp == null ? false : variables.varLcl_DistributionPopUp.Value;
string varLcl_OrderNumber = variables.varLcl_OrderNumber == null ? "" : variables.varLcl_OrderNumber;
AggregateRecord<RL_7ea77cbfb509e64003daa02c749dcc25> _ScreenDataSetGetOrdersWithErrors = (variables.ScreenDataSetGetOrdersWithErrors != null) ? variables.ScreenDataSetGetOrdersWithErrors.FromJS((array) => {
return RL_7ea77cbfb509e64003daa02c749dcc25.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_f100e5d5057b18be95e8602dfe9dd2af.ToStructure);
}
) : null;
ConectaProveedores_e_Orders_OrdersRequestErrorDistribution_ScreenModel screenModel = new ConectaProveedores_e_Orders_OrdersRequestErrorDistribution_ScreenModel(varLcl_TableSort, varLcl_StartIndex, varLcl_ReInvokeToggler, varLcl_ColumnJSONVarGetOrders, varLcl_CountAfterFetchGetOrders, varLcl_Loading, varLcl_DaysInAssigmentList, varLcl_Refresh, varLcl_OrderMainId, varLcl_LogsPopUp, varLcl_DistributionPopUp, varLcl_OrderNumber, _ScreenDataSetGetOrdersWithErrors, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
